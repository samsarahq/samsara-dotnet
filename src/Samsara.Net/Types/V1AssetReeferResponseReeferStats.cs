using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1AssetReeferResponseReeferStats
{
    /// <summary>
    /// Reefer alarms
    /// </summary>
    [JsonPropertyName("alarms")]
    public IEnumerable<V1AssetReeferResponseReeferStatsAlarms1>? Alarms { get; set; }

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
    public IEnumerable<V1AssetReeferResponseReeferStatsPowerStatus>? PowerStatus { get; set; }

    /// <summary>
    /// Return air temperature of the reefer
    /// </summary>
    [JsonPropertyName("returnAirTemp")]
    public IEnumerable<V1AssetReeferResponseReeferStatsReturnAirTemp>? ReturnAirTemp { get; set; }

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
