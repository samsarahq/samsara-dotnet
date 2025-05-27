using System.Text.Json;
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
