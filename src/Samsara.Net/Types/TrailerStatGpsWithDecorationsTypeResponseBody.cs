using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TrailerStatGpsWithDecorationsTypeResponseBody
{
    [JsonPropertyName("decorations")]
    public TrailerStatDecorationResponseBody? Decorations { get; set; }

    /// <summary>
    /// Heading of the trailer in degrees.
    /// </summary>
    [JsonPropertyName("headingDegrees")]
    public long? HeadingDegrees { get; set; }

    /// <summary>
    /// GPS latitude represented in degrees.
    /// </summary>
    [JsonPropertyName("latitude")]
    public required double Latitude { get; set; }

    /// <summary>
    /// GPS longitude represented in degrees.
    /// </summary>
    [JsonPropertyName("longitude")]
    public required double Longitude { get; set; }

    [JsonPropertyName("reverseGeo")]
    public ReverseGeoObjectResponseBody? ReverseGeo { get; set; }

    /// <summary>
    /// GPS speed of the trailer in miles per hour.
    /// </summary>
    [JsonPropertyName("speedMilesPerHour")]
    public long? SpeedMilesPerHour { get; set; }

    /// <summary>
    /// UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
