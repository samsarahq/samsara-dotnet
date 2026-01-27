using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// An author signature for DVIRs with a signed time.
/// </summary>
[Serializable]
public record AuthorSignatureObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
