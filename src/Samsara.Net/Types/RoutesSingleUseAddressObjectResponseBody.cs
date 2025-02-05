using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record RoutesSingleUseAddressObjectResponseBody
{
    /// <summary>
    /// Address of the stop.
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// The latitude of the location
    /// </summary>
    [JsonPropertyName("latitude")]
    public required double Latitude { get; set; }

    /// <summary>
    /// The longitude of the location
    /// </summary>
    [JsonPropertyName("longitude")]
    public required double Longitude { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
