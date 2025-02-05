using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AddressGeofencePolygon
{
    /// <summary>
    /// The vertices of the polygon geofence. These geofence vertices describe the perimeter of the polygon, and must consist of at least 3 vertices and less than 40.
    /// </summary>
    [JsonPropertyName("vertices")]
    public IEnumerable<AddressGeofencePolygonVertices> Vertices { get; set; } =
        new List<AddressGeofencePolygonVertices>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
