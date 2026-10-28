using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Inclusive clockwise range for the vehicle's direction of travel, measured in degrees from true north. Endpoints must be finite, distinct, and in [0, 360). A start greater than the end wraps through north. When absent, observations are not filtered by direction of travel.
/// </summary>
[Serializable]
public record WatchpointBearingRangeTypeResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// End bearing in degrees.
    /// </summary>
    [JsonPropertyName("endDegrees")]
    public required double EndDegrees { get; set; }

    /// <summary>
    /// Start bearing in degrees.
    /// </summary>
    [JsonPropertyName("startDegrees")]
    public required double StartDegrees { get; set; }

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
