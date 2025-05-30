using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The geofence that defines this address and its bounds. This can either be a circle or a polygon, but not both.
/// </summary>
public record WorkflowGeofenceResponseBody
{
    [JsonPropertyName("circle")]
    public WorkflowCircleResponseBody? Circle { get; set; }

    [JsonPropertyName("polygon")]
    public WorkflowPolygonResponseBody? Polygon { get; set; }

    [JsonPropertyName("settings")]
    public SettingsResponseBody? Settings { get; set; }

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
