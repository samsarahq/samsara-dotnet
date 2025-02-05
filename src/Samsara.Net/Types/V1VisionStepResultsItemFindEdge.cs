using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VisionStepResultsItemFindEdge
{
    /// <summary>
    /// The detected angle in degrees
    /// </summary>
    [JsonPropertyName("angleFound")]
    public int? AngleFound { get; set; }

    /// <summary>
    /// The configured angle allowance range
    /// </summary>
    [JsonPropertyName("angleRange")]
    public V1VisionStepResultsItemFindEdgeAngleRange? AngleRange { get; set; }

    /// <summary>
    /// The detected contrast percentage
    /// </summary>
    [JsonPropertyName("contrastPercent")]
    public int? ContrastPercent { get; set; }

    /// <summary>
    /// The configured contrast allowance range
    /// </summary>
    [JsonPropertyName("contrastRange")]
    public V1VisionStepResultsItemFindEdgeContrastRange? ContrastRange { get; set; }

    /// <summary>
    /// The configured polarity for finding edges. Valid values: `LIGHT TO DARK`, `DARK TO LIGHT`.
    /// </summary>
    [JsonPropertyName("filterPolarity")]
    public string? FilterPolarity { get; set; }

    /// <summary>
    /// The detected sharpness percentage
    /// </summary>
    [JsonPropertyName("sharpnessPercent")]
    public int? SharpnessPercent { get; set; }

    /// <summary>
    /// The configured sharpness allowance range
    /// </summary>
    [JsonPropertyName("sharpnessRange")]
    public V1VisionStepResultsItemFindEdgeSharpnessRange? SharpnessRange { get; set; }

    /// <summary>
    /// The detected straightness percentage
    /// </summary>
    [JsonPropertyName("straightnessFound")]
    public int? StraightnessFound { get; set; }

    /// <summary>
    /// The configured straightness allowance range
    /// </summary>
    [JsonPropertyName("straightnessRange")]
    public V1VisionStepResultsItemFindEdgeStraightnessRange? StraightnessRange { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
