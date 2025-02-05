using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1AssetsReeferReeferStats
{
    /// <summary>
    /// Ambient temperature of the reefer. This is the temperature of the air around the Samsara Asset Gateway.
    /// </summary>
    [JsonPropertyName("ambientAirTemperature")]
    public IEnumerable<V1AssetsReeferReeferStatsAmbientAirTemperature>? AmbientAirTemperature { get; set; }

    /// <summary>
    /// Discharge air temperature of the reefer. This is the temperature of the air as it leaves the cooling unit.
    /// </summary>
    [JsonPropertyName("dischargeAirTemperature")]
    public IEnumerable<V1AssetsReeferReeferStatsDischargeAirTemperature>? DischargeAirTemperature { get; set; }

    /// <summary>
    /// Engine hours of the reefer
    /// </summary>
    [JsonPropertyName("engineHours")]
    public IEnumerable<V1AssetReeferResponseReeferStatsEngineHours>? EngineHours { get; set; }

    /// <summary>
    /// Fuel percentage of the reefer
    /// </summary>
    [JsonPropertyName("fuelPercentage")]
    public IEnumerable<V1AssetReeferResponseReeferStatsFuelPercentage>? FuelPercentage { get; set; }

    /// <summary>
    /// Power status of the reefer
    /// </summary>
    [JsonPropertyName("powerStatus")]
    public IEnumerable<V1AssetsReeferReeferStatsPowerStatus>? PowerStatus { get; set; }

    /// <summary>
    /// Reefer alarms
    /// </summary>
    [JsonPropertyName("reeferAlarms")]
    public IEnumerable<V1AssetReeferResponseReeferStatsAlarms1>? ReeferAlarms { get; set; }

    /// <summary>
    /// Return air temperature of the reefer. This is the temperature read by the reefer module (Carrier, Thermo King) that shows the temperature of the air as it enters the system.
    /// </summary>
    [JsonPropertyName("returnAirTemperature")]
    public IEnumerable<V1AssetReeferResponseReeferStatsReturnAirTemp>? ReturnAirTemperature { get; set; }

    /// <summary>
    /// Set point temperature of the reefer
    /// </summary>
    [JsonPropertyName("setPoint")]
    public IEnumerable<V1AssetReeferResponseReeferStatsSetPoint>? SetPoint { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
