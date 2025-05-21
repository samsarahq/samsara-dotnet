using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Contains all the state changes of the reefer for the included stat types. Each state change is recorded independently, so the number of records in each array may differ depending on when that stat changed state. Stat types with a continuous value (such as temperature) will be recorded at different rates depending on the reefer, but generally readings have a frequency on the order of seconds.
/// </summary>
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
