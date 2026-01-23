using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record V1VisionStepResultsItemAngleCheck : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
