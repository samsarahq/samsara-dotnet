using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VertexRequestBody
{
    /// <summary>
    /// The latitude of a geofence vertex in decimal degrees.
    /// </summary>
    [JsonPropertyName("latitude")]
    public required double Latitude { get; set; }

    /// <summary>
    /// The longitude of a geofence vertex in decimal degrees.
    /// </summary>
    [JsonPropertyName("longitude")]
    public required double Longitude { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
