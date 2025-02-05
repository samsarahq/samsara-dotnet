using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VehicleHarshEventResponseLocation
{
    /// <summary>
    /// Address of location where the harsh event occurred
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// Latitude of location where the harsh event occurred
    /// </summary>
    [JsonPropertyName("latitude")]
    public double? Latitude { get; set; }

    /// <summary>
    /// Longitude of location where the harsh event occurred
    /// </summary>
    [JsonPropertyName("longitude")]
    public double? Longitude { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
