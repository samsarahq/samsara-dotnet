using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Vehicle cumulative fuel consumption reading in milliliters.
/// </summary>
[Serializable]
public record VehicleStatsFuelConsumedMillilitersWithDecoration : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("decorations")]
    public VehicleStatsDecorations? Decorations { get; set; }

    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// The cumulative fuel consumption in milliliters for vehicles. Cumulative values always increase. This includes all fuel consumption reported by vehicles without filtering of invalid data points. For filtered fuel consumption that matches the Fuel & Energy Report, please use <a href="https://developers.samsara.com/reference/getfuelenergyvehiclereports" target="_blank">the Fuel and Energy API</a>.
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
