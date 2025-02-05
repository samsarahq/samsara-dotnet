using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverEfficiencyDifficultyScoreDataObjectResponseBody
{
    /// <summary>
    /// Represents the overall difficulty score. It has scores from 1 to 5.
    /// </summary>
    [JsonPropertyName("overallScore")]
    public string? OverallScore { get; set; }

    /// <summary>
    /// Represents the topography difficulty score. It has scores from 1 to 5.
    /// </summary>
    [JsonPropertyName("topographyScore")]
    public string? TopographyScore { get; set; }

    /// <summary>
    /// Represents the average vehicle weight score. It has scores from 1 to 5.
    /// </summary>
    [JsonPropertyName("vehicleWeightScore")]
    public string? VehicleWeightScore { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
