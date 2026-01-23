using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record V1VisionStepResultsItemCaliper : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The configured angle allowance range
    /// </summary>
    [JsonPropertyName("angleRange")]
    public V1VisionStepResultsItemCaliperAngleRange? AngleRange { get; set; }

    /// <summary>
    /// The configured contrast allowance range
    /// </summary>
    [JsonPropertyName("contrastRange")]
    public V1VisionStepResultsItemCaliperContrastRange? ContrastRange { get; set; }

    /// <summary>
    /// The distance found between the found edges
    /// </summary>
    [JsonPropertyName("distanceFound")]
    public float? DistanceFound { get; set; }

    /// <summary>
    /// The configured polarity for finding edges. Valid values: `LIGHT TO DARK`, `DARK TO LIGHT`.
    /// </summary>
    [JsonPropertyName("filterPolarity")]
    public V1VisionStepResultsItemCaliperFilterPolarity? FilterPolarity { get; set; }

    /// <summary>
    /// The maximum allowed distance threshold
    /// </summary>
    [JsonPropertyName("maxDistance")]
    public float? MaxDistance { get; set; }

    /// <summary>
    /// The minumum allowed distance threshold
    /// </summary>
    [JsonPropertyName("minDistance")]
    public float? MinDistance { get; set; }

    /// <summary>
    /// The configured sharpness allowance range
    /// </summary>
    [JsonPropertyName("sharpnessRange")]
    public V1VisionStepResultsItemCaliperSharpnessRange? SharpnessRange { get; set; }

    /// <summary>
    /// The configured straightness allowance range
    /// </summary>
    [JsonPropertyName("straightnessRange")]
    public V1VisionStepResultsItemCaliperStraightnessRange? StraightnessRange { get; set; }

    /// <summary>
    /// The measurement unit of the distance found and the min and max distance threshold
    /// </summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
