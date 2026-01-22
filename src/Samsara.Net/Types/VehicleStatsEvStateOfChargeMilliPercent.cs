using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// State of Charge for electric and hybrid vehicles. Not all EV and HEVs may report this field.
/// </summary>
[Serializable]
public record VehicleStatsEvStateOfChargeMilliPercent : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Milli percent State of Charge for electric and hybrid vehicles.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; set; }

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
