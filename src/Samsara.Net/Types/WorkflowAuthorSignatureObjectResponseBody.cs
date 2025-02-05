using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record WorkflowAuthorSignatureObjectResponseBody
{
    [JsonPropertyName("signatoryUser")]
    public required WorkflowSignatoryUserObjectResponseBody SignatoryUser { get; set; }

    /// <summary>
    /// The time when the DVIR was signed. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("signedAtTime")]
    public required string SignedAtTime { get; set; }

    /// <summary>
    /// Whether the DVIR was submitted by a driver or mechanic.  Valid values: `driver`, `mechanic`
    /// </summary>
    [JsonPropertyName("type")]
    public required WorkflowAuthorSignatureObjectResponseBodyType Type { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
