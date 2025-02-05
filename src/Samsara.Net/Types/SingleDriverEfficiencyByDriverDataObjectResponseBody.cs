using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record SingleDriverEfficiencyByDriverDataObjectResponseBody
{
    [JsonPropertyName("difficultyScore")]
    public DriverEfficiencyDifficultyScoreDataObjectResponseBody? DifficultyScore { get; set; }

    /// <summary>
    /// ID of the driver.
    /// </summary>
    [JsonPropertyName("driverId")]
    public required string DriverId { get; set; }

    [JsonPropertyName("percentageData")]
    public DriverEfficiencyPercentageDataObjectResponseBody? PercentageData { get; set; }

    [JsonPropertyName("rawData")]
    public DriverEfficiencyRawDataObjectResponseBody? RawData { get; set; }

    [JsonPropertyName("scoreData")]
    public DriverEfficiencyDataObjectResponseBody? ScoreData { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
