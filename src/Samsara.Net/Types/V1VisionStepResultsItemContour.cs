using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VisionStepResultsItemContour
{
    /// <summary>
    /// The rotation angle found
    /// </summary>
    [JsonPropertyName("angleDegrees")]
    public long? AngleDegrees { get; set; }

    /// <summary>
    /// The rotation angle allowance
    /// </summary>
    [JsonPropertyName("angleTolerance")]
    public long? AngleTolerance { get; set; }

    /// <summary>
    /// The contour match percentage with the configured contour
    /// </summary>
    [JsonPropertyName("matchPercentage")]
    public long? MatchPercentage { get; set; }

    /// <summary>
    /// The configured match threshold for contours
    /// </summary>
    [JsonPropertyName("matchThreshold")]
    public long? MatchThreshold { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
