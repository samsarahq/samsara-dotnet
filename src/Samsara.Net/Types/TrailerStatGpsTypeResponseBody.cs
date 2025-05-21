using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// GPS location data for the trailer.
/// </summary>
public record TrailerStatGpsTypeResponseBody
{
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
