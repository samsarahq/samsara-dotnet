using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record LocationDataPointGpsLocation
{
    /// <summary>
    /// Formatted address of the location
    /// </summary>
    [JsonPropertyName("formattedAddress")]
    public string? FormattedAddress { get; set; }

    /// <summary>
    /// Speed of GPS (meters per second)
    /// </summary>
    [JsonPropertyName("gpsMetersPerSecond")]
    public double? GpsMetersPerSecond { get; set; }

    /// <summary>
    /// Heading degrees
    /// </summary>
    [JsonPropertyName("headingDegrees")]
    public double? HeadingDegrees { get; set; }

    /// <summary>
    /// Latitude of the location
    /// </summary>
    [JsonPropertyName("latitude")]
    public double? Latitude { get; set; }

    /// <summary>
    /// Longitude of the location
    /// </summary>
    [JsonPropertyName("longitude")]
    public double? Longitude { get; set; }

    [JsonPropertyName("place")]
    public LocationDataPointGpsLocationPlace? Place { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
