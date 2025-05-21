using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Difficulty score won't be available if there is no data to compute it against.
/// </summary>
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
