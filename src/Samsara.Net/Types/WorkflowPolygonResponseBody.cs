using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record WorkflowPolygonResponseBody
{
    /// <summary>
    /// The vertices of the polygon geofence. These geofence vertices describe the perimeter of the polygon, and must consist of at least 3 vertices and less than 40.
    /// </summary>
    [JsonPropertyName("vertices")]
    public IEnumerable<VertexResponseBody>? Vertices { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
