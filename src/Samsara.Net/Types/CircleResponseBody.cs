using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record CircleResponseBody
{
    /// <summary>
    /// Latitude of the address. Will be geocoded from formattedAddress if not provided.
    /// </summary>
    [JsonPropertyName("latitude")]
    public double? Latitude { get; set; }

    /// <summary>
    /// Longitude of the address. Will be geocoded from formattedAddress if not provided.
    /// </summary>
    [JsonPropertyName("longitude")]
    public double? Longitude { get; set; }

    /// <summary>
    /// The name of the cirlce.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The radius of the circular geofence in meters.
    /// </summary>
    [JsonPropertyName("radiusMeters")]
    public required long RadiusMeters { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
