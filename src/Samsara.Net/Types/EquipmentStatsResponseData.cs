using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A unit of equipment and its most recent stat.
/// </summary>
[Serializable]
public record EquipmentStatsResponseData : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("engineRpm")]
    public EquipmentEngineRpm? EngineRpm { get; set; }

    [JsonPropertyName("engineSeconds")]
    public EquipmentEngineSeconds? EngineSeconds { get; set; }

    [JsonPropertyName("engineState")]
    public EquipmentEngineState? EngineState { get; set; }

    [JsonPropertyName("engineTotalIdleTimeMinutes")]
    public EquipmentEngineTotalIdleTimeMinutes? EngineTotalIdleTimeMinutes { get; set; }

    [JsonPropertyName("fuelPercent")]
    public EquipmentFuelPercent? FuelPercent { get; set; }

    [JsonPropertyName("gatewayEngineSeconds")]
    public EquipmentGatewayEngineSeconds? GatewayEngineSeconds { get; set; }

    [JsonPropertyName("gatewayEngineState")]
    public EquipmentGatewayEngineState? GatewayEngineState { get; set; }

    [JsonPropertyName("gps")]
    public EquipmentStatsGps? Gps { get; set; }

    [JsonPropertyName("gpsOdometerMeters")]
    public EquipmentGpsOdometerMeters? GpsOdometerMeters { get; set; }

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("obdEngineSeconds")]
    public EquipmentObdEngineSeconds? ObdEngineSeconds { get; set; }

    [JsonPropertyName("obdEngineState")]
    public EquipmentObdEngineState? ObdEngineState { get; set; }

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
