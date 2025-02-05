using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DvirThirdSignature
{
    [JsonPropertyName("signatoryUser")]
    public DvirSignatureSignatoryUser? SignatoryUser { get; set; }

    /// <summary>
    /// The time when the DVIR was signed. UTC timestamp in RFC 3339 format. Example: `2020-01-27T07:06:25Z`.
    /// </summary>
    [JsonPropertyName("signedAtTime")]
    public string? SignedAtTime { get; set; }

    /// <summary>
    /// Whether the DVIR was submitted by a `driver` or `mechanic`. Valid values: `driver`, `mechanic`.
    /// </summary>
    [JsonPropertyName("type")]
    public DvirSignatureType? Type { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
