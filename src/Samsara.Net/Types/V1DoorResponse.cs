using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Contains the current door status of a sensor.
/// </summary>
public record V1DoorResponse
{
    /// <summary>
    /// Deprecated.
    /// </summary>
    [JsonPropertyName("groupId")]
    public long? GroupId { get; set; }

    [JsonPropertyName("sensors")]
    public IEnumerable<V1DoorResponseSensors>? Sensors { get; set; }

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
