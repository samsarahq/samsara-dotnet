using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VisionStepResultsItemDistance
{
    /// <summary>
    /// The distance found between the start and end references
    /// </summary>
    [JsonPropertyName("distanceFound")]
    public int? DistanceFound { get; set; }

    /// <summary>
    /// The name of the second reference step that we're checking the distances between
    /// </summary>
    [JsonPropertyName("endStepName")]
    public string? EndStepName { get; set; }

    /// <summary>
    /// Whether an offset angle range is enforced
    /// </summary>
    [JsonPropertyName("enforceOffsetAngleRange")]
    public bool? EnforceOffsetAngleRange { get; set; }

    /// <summary>
    /// The maximum allowed distance threshold
    /// </summary>
    [JsonPropertyName("maxDistance")]
    public int? MaxDistance { get; set; }

    /// <summary>
    /// The maximum angle allowance (in degrees) if enforceOffsetAngleRange is true
    /// </summary>
    [JsonPropertyName("maxOffsetAngle")]
    public long? MaxOffsetAngle { get; set; }

    /// <summary>
    /// The minumum allowed distance threshold
    /// </summary>
    [JsonPropertyName("minDistance")]
    public int? MinDistance { get; set; }

    /// <summary>
    /// The minimum angle allowance (in degrees) if enforceOffsetAngleRange is true
    /// </summary>
    [JsonPropertyName("minOffsetAngle")]
    public long? MinOffsetAngle { get; set; }

    /// <summary>
    /// The counter-clockwise angle (in degrees) found between the horizontal axis of the start reference step and the last
    /// </summary>
    [JsonPropertyName("offsetAngleFound")]
    public long? OffsetAngleFound { get; set; }

    /// <summary>
    /// The name of the first reference step that we're checking the distances between
    /// </summary>
    [JsonPropertyName("startStepName")]
    public string? StartStepName { get; set; }

    /// <summary>
    /// The measurement unit of the distance found and the min and max distance threshold
    /// </summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

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
