using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// An author signature for DVIRs with a signed time.
/// </summary>
public record AuthorSignatureObjectResponseBody
{
    [JsonPropertyName("signatoryUser")]
    public required SignatoryUserObjectResponseBody SignatoryUser { get; set; }

    /// <summary>
    /// The time when the DVIR was signed. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("signedAtTime")]
    public required string SignedAtTime { get; set; }

    /// <summary>
    /// Whether the DVIR was submitted by a driver or mechanic.  Valid values: `driver`, `mechanic`
    /// </summary>
    [JsonPropertyName("type")]
    public required AuthorSignatureObjectResponseBodyType Type { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
