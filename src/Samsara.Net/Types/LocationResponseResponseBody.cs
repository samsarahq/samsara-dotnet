using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record LocationResponseResponseBody
{
    /// <summary>
    /// Radial accuracy of gps location in meters. This will only return if strong GPS is not available.
    /// </summary>
    [JsonPropertyName("accuracyMeters")]
    public double? AccuracyMeters { get; set; }

    [JsonPropertyName("address")]
    public AddressResponseResponseBody? Address { get; set; }

    [JsonPropertyName("geofence")]
    public GeofenceResponseResponseBody? Geofence { get; set; }

    /// <summary>
    /// Heading of the asset in degrees. May be 0 if the asset is not moving.
    /// </summary>
    [JsonPropertyName("headingDegrees")]
    public required long HeadingDegrees { get; set; }

    /// <summary>
    /// Latitude of the location of the asset.
    /// </summary>
    [JsonPropertyName("latitude")]
    public required double Latitude { get; set; }

    /// <summary>
    /// Longitude of the location of the asset.
    /// </summary>
    [JsonPropertyName("longitude")]
    public required double Longitude { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
