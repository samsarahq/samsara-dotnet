using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosEldEventLocationObjectResponseBody
{
    /// <summary>
    /// The best effort city for the latitude and longitude.
    /// </summary>
    [JsonPropertyName("city")]
    public string? City { get; set; }

    /// <summary>
    /// Relative location to the city, village, or town with population of 5,000 or greater.
    /// </summary>
    [JsonPropertyName("eldLocation")]
    public string? EldLocation { get; set; }

    /// <summary>
    /// The latitude of the location.
    /// </summary>
    [JsonPropertyName("latitude")]
    public double? Latitude { get; set; }

    /// <summary>
    /// The longitude of the location.
    /// </summary>
    [JsonPropertyName("longitude")]
    public double? Longitude { get; set; }

    /// <summary>
    /// The best effort state for the latitude and longitude.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
