using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record WorkflowGeofenceResponseBody
{
    [JsonPropertyName("circle")]
    public WorkflowCircleResponseBody? Circle { get; set; }

    [JsonPropertyName("polygon")]
    public WorkflowPolygonResponseBody? Polygon { get; set; }

    [JsonPropertyName("settings")]
    public SettingsResponseBody? Settings { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
