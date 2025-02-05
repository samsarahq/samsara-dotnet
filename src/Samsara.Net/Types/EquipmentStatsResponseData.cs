using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EquipmentStatsResponseData
{
    [JsonPropertyName("engineRpm")]
    public EquipmentEngineRpm? EngineRpm { get; set; }

    [JsonPropertyName("engineSeconds")]
    public EquipmentEngineSeconds? EngineSeconds { get; set; }

    [JsonPropertyName("engineState")]
    public EquipmentEngineState? EngineState { get; set; }

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
