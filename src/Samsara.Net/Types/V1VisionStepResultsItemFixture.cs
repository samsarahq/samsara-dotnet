using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VisionStepResultsItemFixture
{
    [JsonPropertyName("coordinates")]
    public V1VisionStepResultsItemFixtureCoordinates? Coordinates { get; set; }

    [JsonPropertyName("found")]
    public bool? Found { get; set; }

    [JsonPropertyName("rotationDegrees")]
    public long? RotationDegrees { get; set; }

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
