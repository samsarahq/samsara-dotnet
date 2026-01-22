using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A single J1939D1 status
/// </summary>
[Serializable]
public record J1939D1StatusDataPointValue : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("amberLampStatus")]
    public int? AmberLampStatus { get; set; }

    [JsonPropertyName("fmi")]
    public int? Fmi { get; set; }

    [JsonPropertyName("milStatus")]
    public int? MilStatus { get; set; }

    [JsonPropertyName("occuranceCount")]
    public int? OccuranceCount { get; set; }

    [JsonPropertyName("protectLampStatus")]
    public int? ProtectLampStatus { get; set; }

    [JsonPropertyName("redLampStatus")]
    public int? RedLampStatus { get; set; }

    [JsonPropertyName("spn")]
    public int? Spn { get; set; }

    [JsonPropertyName("txId")]
    public int? TxId { get; set; }

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
