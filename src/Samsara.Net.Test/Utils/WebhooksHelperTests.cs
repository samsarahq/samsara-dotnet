using NUnit.Framework;

// ReSharper disable NullableWarningSuppressionIsUsed

namespace Samsara.Test.Unit;

/// <summary>
/// Tests for <see cref="WebhooksHelper.VerifySignature"/>, which implements the Samsara <c>v1</c>
/// webhook signature scheme (see https://developers.samsara.com/docs/webhooks#webhook-signatures):
///   - header <c>X-Samsara-Signature</c> with value <c>v1=&lt;hex&gt;</c>
///   - header <c>X-Samsara-Timestamp</c> (unix seconds)
///   - HMAC-SHA256 over the base string <c>v1:{timestamp}:{rawBody}</c>
///   - the HMAC key is the Base64-decoded signature secret from the Developer portal
///   - the signature is lowercase hex, prefixed with <c>v1=</c>
/// </summary>
[TestFixture]
public class WebhooksHelperTests
{
    // Golden vector, pinned to the backend signer ComputeV1Signature
    // (go/src/samsaradev.io/infra/api/webhooks/helpers/helper_test.go, TestComputeV1Signature_GoldenValue):
    //   ComputeV1Signature("test-body", "test-secret", 1700000000)
    //     == "v1=e05d9d1f326a1f8a845d2520d09d45c6b20c1931828bbd1dd3858446e7ae7082"
    private const string BodyString = "test-body";
    private const string Timestamp = "1700000000";

    // The signature secret shown in the Samsara Developer portal is Base64. Its decoded bytes
    // ("test-secret") are the actual HMAC key. Base64("test-secret") == "dGVzdC1zZWNyZXQ=".
    private const string SignatureKey = "dGVzdC1zZWNyZXQ=";

    private const string SignatureHeader =
        "v1=e05d9d1f326a1f8a845d2520d09d45c6b20c1931828bbd1dd3858446e7ae7082";

    [Test]
    public void VerifySignatureMatchesGoldenVector()
    {
        var result = WebhooksHelper.VerifySignature(
            BodyString,
            SignatureHeader,
            Timestamp,
            SignatureKey
        );
        Assert.That(result, Is.True);
    }

    [Test]
    public void VerifySignatureIsTrueForEscapedBodyValidNotification()
    {
        // Signature computed with the same v1 scheme over a body containing escaped characters.
        const string escapedRequestBody = "{\"data\":{\"type\":\"webhooks\",\"id\":\">id<\"}}";
        var signatureHeader = ComputeV1SignatureHeader(escapedRequestBody, Timestamp, SignatureKey);

        var result = WebhooksHelper.VerifySignature(
            escapedRequestBody,
            signatureHeader,
            Timestamp,
            SignatureKey
        );
        Assert.That(result, Is.True);
    }

    [Test]
    public void VerifySignatureIsFalseIfBodyTampered()
    {
        var result = WebhooksHelper.VerifySignature(
            "test-body-tampered",
            SignatureHeader,
            Timestamp,
            SignatureKey
        );
        Assert.That(result, Is.False);
    }

    [Test]
    public void VerifySignatureIsFalseIfBodyIsFormatted()
    {
        // The raw body must be verified byte-for-byte; reformatting invalidates the signature.
        const string formattedBody = "test-body\n";
        var result = WebhooksHelper.VerifySignature(
            formattedBody,
            SignatureHeader,
            Timestamp,
            SignatureKey
        );
        Assert.That(result, Is.False);
    }

    [Test]
    public void VerifySignatureIsFalseIfSecretIsWrong()
    {
        // A different (but validly Base64-encoded) secret must not verify.
        const string wrongSecret = "YW5vdGhlci1zZWNyZXQ="; // Base64("another-secret")
        var result = WebhooksHelper.VerifySignature(
            BodyString,
            SignatureHeader,
            Timestamp,
            wrongSecret
        );
        Assert.That(result, Is.False);
    }

    [Test]
    public void VerifySignatureIsFalseIfSecretIsNotValidBase64()
    {
        var result = WebhooksHelper.VerifySignature(
            BodyString,
            SignatureHeader,
            Timestamp,
            "not valid base64 !!!"
        );
        Assert.That(result, Is.False);
    }

    [Test]
    public void VerifySignatureIsFalseIfTimestampIsWrong()
    {
        var result = WebhooksHelper.VerifySignature(
            BodyString,
            SignatureHeader,
            "1700000001",
            SignatureKey
        );
        Assert.That(result, Is.False);
    }

    [Test]
    public void VerifySignatureIsFalseIfTimestampIsNonNumeric()
    {
        var result = WebhooksHelper.VerifySignature(
            BodyString,
            SignatureHeader,
            "not-a-timestamp",
            SignatureKey
        );
        Assert.That(result, Is.False);
    }

    [Test]
    public void VerifySignatureIsFalseIfTimestampIsEmpty()
    {
        var result = WebhooksHelper.VerifySignature(BodyString, SignatureHeader, "", SignatureKey);
        Assert.That(result, Is.False);
    }

    [Test]
    public void VerifySignatureIsFalseIfTimestampIsNull()
    {
        var result = WebhooksHelper.VerifySignature(
            BodyString,
            SignatureHeader,
            null!,
            SignatureKey
        );
        Assert.That(result, Is.False);
    }

    [Test]
    public void VerifySignatureIsFalseIfSignatureHeaderMissingV1Prefix()
    {
        // Same hex, but without the required "v1=" prefix.
        const string headerWithoutPrefix =
            "e05d9d1f326a1f8a845d2520d09d45c6b20c1931828bbd1dd3858446e7ae7082";
        var result = WebhooksHelper.VerifySignature(
            BodyString,
            headerWithoutPrefix,
            Timestamp,
            SignatureKey
        );
        Assert.That(result, Is.False);
    }

    [Test]
    public void VerifySignatureIsFalseIfSignatureHeaderIsInvalid()
    {
        var result = WebhooksHelper.VerifySignature(
            BodyString,
            "v1=deadbeef",
            Timestamp,
            SignatureKey
        );
        Assert.That(result, Is.False);
    }

    [Test]
    public void VerifySignatureIsFalseIfSignatureHeaderIsEmpty()
    {
        var result = WebhooksHelper.VerifySignature(BodyString, "", Timestamp, SignatureKey);
        Assert.That(result, Is.False);
    }

    [Test]
    public void VerifySignatureIsFalseIfSignatureHeaderIsNull()
    {
        var result = WebhooksHelper.VerifySignature(BodyString, null!, Timestamp, SignatureKey);
        Assert.That(result, Is.False);
    }

    [Test]
    public void VerifySignatureIsFalseIfBodyIsEmpty()
    {
        var result = WebhooksHelper.VerifySignature("", SignatureHeader, Timestamp, SignatureKey);
        Assert.That(result, Is.False);
    }

    [Test]
    public void VerifySignatureIsFalseIfBodyIsNull()
    {
        var result = WebhooksHelper.VerifySignature(null!, SignatureHeader, Timestamp, SignatureKey);
        Assert.That(result, Is.False);
    }

    [Test]
    public void VerifySignatureThrowsIfSignatureKeyIsEmpty()
    {
        var result = Assert.Throws<ArgumentNullException>(
            () => WebhooksHelper.VerifySignature(BodyString, SignatureHeader, Timestamp, "")
        );
        Assert.That(result.Message, Does.StartWith("Value cannot be null."));
        Assert.That(result.Message, Does.Contain("signatureKey"));
    }

    [Test]
    public void VerifySignatureThrowsIfSignatureKeyIsNull()
    {
        var result = Assert.Throws<ArgumentNullException>(
            () => WebhooksHelper.VerifySignature(BodyString, SignatureHeader, Timestamp, null!)
        );
        Assert.That(result.Message, Does.StartWith("Value cannot be null."));
        Assert.That(result.Message, Does.Contain("signatureKey"));
    }

    /// <summary>
    /// Emulates the Samsara backend signer: HMAC-SHA256 over <c>v1:{timestamp}:{body}</c> using the
    /// Base64-decoded secret, returned as <c>v1=&lt;hex&gt;</c>. Used to derive vectors for bodies other
    /// than the pinned golden vector.
    /// </summary>
    private static string ComputeV1SignatureHeader(
        string body,
        string timestamp,
        string portalSecretBase64
    )
    {
        var key = Convert.FromBase64String(portalSecretBase64);
        var baseString = $"v1:{timestamp}:{body}";
        using var hmac = new System.Security.Cryptography.HMACSHA256(key);
        var hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(baseString));
        return "v1=" + System.Convert.ToHexString(hash).ToLowerInvariant();
    }
}
