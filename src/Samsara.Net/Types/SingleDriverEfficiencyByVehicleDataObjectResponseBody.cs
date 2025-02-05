using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record SingleDriverEfficiencyByVehicleDataObjectResponseBody
{
    [JsonPropertyName("difficultyScore")]
    public DriverEfficiencyDifficultyScoreDataObjectResponseBody? DifficultyScore { get; set; }

    [JsonPropertyName("percentageData")]
    public DriverEfficiencyPercentageDataObjectResponseBody? PercentageData { get; set; }

    [JsonPropertyName("rawData")]
    public DriverEfficiencyRawDataObjectResponseBody? RawData { get; set; }

    [JsonPropertyName("scoreData")]
    public DriverEfficiencyDataObjectResponseBody? ScoreData { get; set; }

    /// <summary>
    /// ID of the vehicle.
    /// </summary>
    [JsonPropertyName("vehicleId")]
    public required string VehicleId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
