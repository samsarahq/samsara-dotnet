using System.Security.Cryptography;
using System.Text;

// ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract

namespace Samsara;

/// <summary>
/// Utility code to help with Samsara Webhooks.
/// </summary>
public static class WebhooksHelper
{
    private const string SignaturePrefix = "v1=";

    /// <summary>
    /// Verify and Validate an Event Notification using the Samsara <c>v1</c> signature scheme.
    /// </summary>
    /// <param name="requestBody">The raw JSON body of the request, exactly as received (do not re-serialize or reformat it).</param>
    /// <param name="signatureHeader">The value of the <c>X-Samsara-Signature</c> header. It has the form <c>v1=&lt;hex&gt;</c>.</param>
    /// <param name="timestampHeader">The value of the <c>X-Samsara-Timestamp</c> header (unix seconds).</param>
    /// <param name="signatureKey">The Base64 signature secret from the Samsara Developer portal for the webhook subscription.</param>
    /// <returns>
    /// <c>true</c> if the signature is valid, indicating that the event can be trusted as it came from Samsara.
    /// <c>false</c> if the signature validation fails, indicating the event did not come from Samsara so may be malicious and should be discarded.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown if <paramref name="signatureKey"/> is not set.
    /// </exception>
    /// <remarks>
    /// Samsara signs each webhook by computing <c>HMAC-SHA256</c> over the base string
    /// <c>v1:{timestamp}:{rawBody}</c>, using the Base64-decoded signature secret as the key, and sends the
    /// result as a lowercase hex string in the <c>X-Samsara-Signature</c> header, prefixed with <c>v1=</c>.
    /// See https://developers.samsara.com/docs/webhooks#webhook-signatures.
    /// <example>
    /// For example, if you wanted to verify a webhook notification that was sent to an ASP.NET endpoint
    /// in your app, you could do the following:
    /// <code>
    /// public static async System.Threading.Tasks.Task CheckWebhooksEvent(
    ///     Microsoft.AspNetCore.Http.HttpRequest request,
    ///     string signatureKey
    /// )
    /// {
    ///     var signature = request.Headers["X-Samsara-Signature"].ToString();
    ///     var timestamp = request.Headers["X-Samsara-Timestamp"].ToString();
    ///     using (var reader = new System.IO.StreamReader(request.Body, System.Text.Encoding.UTF8))
    ///     {
    ///         var requestBody = await reader.ReadToEndAsync();
    ///         if (!WebhooksHelper.VerifySignature(requestBody, signature, timestamp, signatureKey))
    ///         {
    ///             throw new System.Exception("A webhook event was received that was not from Samsara.");
    ///         }
    ///     }
    /// }
    /// </code>
    /// </example>
    /// </remarks>
    public static bool VerifySignature(
        string requestBody,
        string signatureHeader,
        string timestampHeader,
        string signatureKey
    )
    {
        if (string.IsNullOrEmpty(signatureKey))
        {
            throw new ArgumentNullException(nameof(signatureKey));
        }

        if (
            requestBody is null
            || string.IsNullOrEmpty(signatureHeader)
            || string.IsNullOrEmpty(timestampHeader)
        )
        {
            return false;
        }

        // Step 1: The signature header is "v1=<hex>". Strip the "v1=" prefix.
        if (!signatureHeader.StartsWith(SignaturePrefix, StringComparison.Ordinal))
        {
            return false;
        }
        var providedHex = signatureHeader.Substring(SignaturePrefix.Length);

        // Step 2: The portal secret is Base64. Decode it to get the raw HMAC key bytes.
        byte[] keyBytes;
        try
        {
            keyBytes = Convert.FromBase64String(signatureKey);
        }
        catch (FormatException)
        {
            return false;
        }

        // Step 3: Build the base string "v1:{timestamp}:{rawBody}" and HMAC-SHA256 it.
        var baseString = $"v1:{timestampHeader}:{requestBody}";
        var baseBytes = Encoding.UTF8.GetBytes(baseString);

        byte[] computedHash;
        using (var hmac = new HMACSHA256(keyBytes))
        {
            computedHash = hmac.ComputeHash(baseBytes);
        }

        // Step 4: Hex-encode the HMAC (lowercase) and compare to the provided signature in constant time.
        var computedHex = ToLowerHex(computedHash);
        return FixedTimeEquals(
            Encoding.ASCII.GetBytes(computedHex),
            Encoding.ASCII.GetBytes(providedHex)
        );
    }

    /// <summary>
    /// Encodes <paramref name="bytes"/> as a lowercase hexadecimal string.
    /// </summary>
    private static string ToLowerHex(byte[] bytes)
    {
#if NET6_0_OR_GREATER
        return Convert.ToHexString(bytes).ToLowerInvariant();
#else
        const string hexChars = "0123456789abcdef";
        var chars = new char[bytes.Length * 2];
        for (var i = 0; i < bytes.Length; i++)
        {
            chars[i * 2] = hexChars[bytes[i] >> 4];
            chars[i * 2 + 1] = hexChars[bytes[i] & 0xF];
        }
        return new string(chars);
#endif
    }

    /// <summary>
    /// Compares two byte arrays in constant time to prevent timing attacks.
    /// </summary>
    private static bool FixedTimeEquals(byte[] a, byte[] b)
    {
#if NET6_0_OR_GREATER
        return CryptographicOperations.FixedTimeEquals(a, b);
#else
        // Constant-time comparison for frameworks without CryptographicOperations
        // (net462, netstandard2.0). Every byte is inspected regardless of an early mismatch.
        if (a.Length != b.Length)
        {
            return false;
        }

        var result = 0;
        for (var i = 0; i < a.Length; i++)
        {
            result |= a[i] ^ b[i];
        }
        return result == 0;
#endif
    }
}
