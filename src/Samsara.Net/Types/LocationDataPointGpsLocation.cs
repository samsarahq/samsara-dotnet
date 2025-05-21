using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// GPS location information of the data input's datapoint.
/// </summary>
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
