using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VisionStepResultsItemAngleCheck
{
    /// <summary>
    /// The configured angle allowance range (in degrees)
    /// </summary>
    [JsonPropertyName("angleConfigured")]
    public V1VisionStepResultsItemAngleCheckAngleConfigured? AngleConfigured { get; set; }

    /// <summary>
    /// The counter-clockwise angle detected from the first edge to the second edge
    /// </summary>
    [JsonPropertyName("angleFound")]
    public long? AngleFound { get; set; }

    /// <summary>
    /// The name of the second reference step used to check the angle
    /// </summary>
    [JsonPropertyName("endStepName")]
    public string? EndStepName { get; set; }

    /// <summary>
    /// The name of the first reference step used to check the angle
    /// </summary>
    [JsonPropertyName("startStepName")]
    public string? StartStepName { get; set; }

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
