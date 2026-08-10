using System.Security.Cryptography;
using System.Text;
using NUnit.Framework;

namespace Samsara.Test.Unit;

/// <summary>
/// Regression test for API-6900: the official .NET SDK helper
/// <see cref="WebhooksHelper.VerifySignature(string, string, string, string)"/> must verify a
/// genuine Samsara webhook signature.
///
/// Samsara signs webhooks with the "v1" scheme (see the backend signer
/// <c>ComputeV1Signature</c> in <c>infra/api/webhooks/helpers/helper.go</c> and the docs at
/// https://developers.samsara.com/docs/webhooks#webhook-signatures):
///   - header <c>X-Samsara-Signature</c> with value <c>v1=&lt;hex&gt;</c>
///   - header <c>X-Samsara-Timestamp</c> (unix seconds)
///   - HMAC-SHA256 over the base string <c>v1:{timestamp}:{rawBody}</c>
///   - the HMAC key is the Base64-decoded webhook secret token
///   - the signature is lowercase hex, prefixed with <c>v1=</c>
///
/// Before the fix, the SDK helper HMACed <c>{notificationUrl}{rawBody}</c>, treated the secret as a
/// UTF-8 string (no Base64 decode), Base64-encoded the result, ignored the timestamp, and read a
/// header (<c>x-samsara-hmacsha256-signature</c>) that Samsara does not send, so it rejected every
/// real Samsara webhook. This test pins the corrected behavior.
/// </summary>
[TestFixture]
public class WebhooksHelperV1SignatureIssueTests
{
    // Anchored to the backend golden vector in
    // go/src/samsaradev.io/infra/api/webhooks/helpers/helper_test.go (TestComputeV1Signature_GoldenValue):
    //   ComputeV1Signature("test-body", "test-secret", 1700000000)
    //     == "v1=e05d9d1f326a1f8a845d2520d09d45c6b20c1931828bbd1dd3858446e7ae7082"
    private const string RawBody = "test-body";
    private const long TimestampSeconds = 1700000000;

    // The webhook secret as shown in the Samsara Developer portal is Base64. Its decoded bytes
    // ("test-secret") are the actual HMAC key. Base64("test-secret") == "dGVzdC1zZWNyZXQ=".
    private const string PortalSecretBase64 = "dGVzdC1zZWNyZXQ=";

    private const string ExpectedV1SignatureHeader =
        "v1=e05d9d1f326a1f8a845d2520d09d45c6b20c1931828bbd1dd3858446e7ae7082";

    [Test]
    public void OurEmulatedSamsaraSignerMatchesBackendGoldenVector()
    {
        // Sanity check: prove the value we feed the SDK below is a genuine Samsara v1 signature by
        // matching the backend's pinned golden vector byte-for-byte.
        var signatureHeader = ComputeSamsaraV1SignatureHeader(
            RawBody,
            PortalSecretBase64,
            TimestampSeconds
        );

        Assert.That(signatureHeader, Is.EqualTo(ExpectedV1SignatureHeader));
    }

    [Test]
    public void CorrectV1VerifierAcceptsGenuineSamsaraWebhook()
    {
        // Positive control: a correct v1 verifier accepts the signature, proving the signature is
        // valid and that any verification failure is the SDK helper's fault, not bad test data.
        var accepted = VerifyV1Reference(
            RawBody,
            ExpectedV1SignatureHeader,
            TimestampSeconds.ToString(),
            PortalSecretBase64
        );

        Assert.That(accepted, Is.True);
    }

    [Test]
    public void SdkHelperVerifiesGenuineSamsaraWebhook_ConfirmsApi6900Fixed()
    {
        // The customer passes exactly what Samsara sends: the X-Samsara-Signature header value, the
        // X-Samsara-Timestamp header value and the portal secret. The fixed SDK helper implements the
        // v1 scheme and accepts the genuine webhook.
        var sdkResult = WebhooksHelper.VerifySignature(
            RawBody,
            ExpectedV1SignatureHeader,
            TimestampSeconds.ToString(),
            PortalSecretBase64
        );

        Assert.That(
            sdkResult,
            Is.True,
            "API-6900: SDK helper must verify a genuine Samsara v1 webhook."
        );
    }

    /// <summary>
    /// Emulates the Samsara backend signer <c>ComputeV1Signature</c>: HMAC-SHA256 over
    /// <c>v1:{timestamp}:{body}</c> using the Base64-decoded secret, returned as <c>v1=&lt;hex&gt;</c>.
    /// </summary>
    private static string ComputeSamsaraV1SignatureHeader(
        string body,
        string portalSecretBase64,
        long timestampSeconds
    )
    {
        var key = Convert.FromBase64String(portalSecretBase64);
        var baseString = $"v1:{timestampSeconds}:{body}";
        using var hmac = new HMACSHA256(key);
        var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(baseString));
        return "v1=" + Convert.ToHexString(hash).ToLowerInvariant();
    }

    /// <summary>
    /// A correct v1 verifier, used only as a positive control in this reproduction.
    /// </summary>
    private static bool VerifyV1Reference(
        string body,
        string signatureHeader,
        string timestampHeader,
        string portalSecretBase64
    )
    {
        if (!signatureHeader.StartsWith("v1=", StringComparison.Ordinal))
        {
            return false;
        }

        var expected = ComputeSamsaraV1SignatureHeader(
            body,
            portalSecretBase64,
            long.Parse(timestampHeader)
        );
        return CryptographicOperations.FixedTimeEquals(
            Encoding.UTF8.GetBytes(expected),
            Encoding.UTF8.GetBytes(signatureHeader)
        );
    }
}
