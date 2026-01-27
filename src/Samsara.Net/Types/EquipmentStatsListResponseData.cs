using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A unit of equipment and its time-series of stats events.
/// </summary>
[Serializable]
public record EquipmentStatsListResponseData : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A time-series of engine RPM readings for the given unit of equipment.
    /// </summary>
    [JsonPropertyName("engineRpm")]
    public IEnumerable<EquipmentEngineRpm>? EngineRpm { get; set; }

    /// <summary>
    /// [DEPRECATED] Please use either `gatewayEngineSeconds`, `obdEngineSeconds`, or `gatewayJ1939EngineSeconds`.
    /// </summary>
    [JsonPropertyName("engineSeconds")]
    public IEnumerable<EquipmentEngineSeconds>? EngineSeconds { get; set; }

    /// <summary>
    /// [DEPRECATED] Please use either `gatewayEngineStates` or `obdEngineStates`.
    /// </summary>
    [JsonPropertyName("engineStates")]
    public IEnumerable<EquipmentEngineState>? EngineStates { get; set; }

    /// <summary>
    /// A time-series of engine total idle time minutes. (Beta)
    /// </summary>
    [JsonPropertyName("engineTotalIdleTimeMinutes")]
    public IEnumerable<EquipmentEngineTotalIdleTimeMinutes>? EngineTotalIdleTimeMinutes { get; set; }

    /// <summary>
    /// A time-series of fuel percent level changes for the given unit of equipment.
    /// </summary>
    [JsonPropertyName("fuelPercents")]
    public IEnumerable<EquipmentFuelPercent>? FuelPercents { get; set; }

    /// <summary>
    /// A time-series of engine seconds readings for the given unit of equipment as an approximate based on readings from the AG26's aux/digio cable.
    /// </summary>
    [JsonPropertyName("gatewayEngineSeconds")]
    public IEnumerable<EquipmentGatewayEngineSeconds>? GatewayEngineSeconds { get; set; }

    /// <summary>
    /// A time-series of engine state changes (as read from the AG26's aux/digio cable) for the given unit of equipment.
    /// </summary>
    [JsonPropertyName("gatewayEngineStates")]
    public IEnumerable<EquipmentGatewayEngineState>? GatewayEngineStates { get; set; }

    /// <summary>
    /// A time-series of engine seconds readings for the given unit of equipment as an approximate based on readings from the AG26's CAT/J1939 cable.
    /// </summary>
    [JsonPropertyName("gatewayJ1939EngineSeconds")]
    public IEnumerable<EquipmentGatewayJ1939EngineSeconds>? GatewayJ1939EngineSeconds { get; set; }

    /// <summary>
    /// A time-series of GPS locations.
    /// </summary>
    [JsonPropertyName("gps")]
    public IEnumerable<EquipmentStatsGps>? Gps { get; set; }

    /// <summary>
    /// A time-series of GPS odometer readings for the given unit of equipment.
    /// </summary>
    [JsonPropertyName("gpsOdometerMeters")]
    public IEnumerable<EquipmentGpsOdometerMeters>? GpsOdometerMeters { get; set; }

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// A time-series of engine seconds readings for the given unit of equipment directly from on-board diagnostics.
    /// </summary>
    [JsonPropertyName("obdEngineSeconds")]
    public IEnumerable<EquipmentObdEngineSeconds>? ObdEngineSeconds { get; set; }

    /// <summary>
    /// A time-series of engine state changes (as read from on-board diagnostics) for the given unit of equipment.
    /// </summary>
    [JsonPropertyName("obdEngineStates")]
    public IEnumerable<EquipmentObdEngineState>? ObdEngineStates { get; set; }

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
