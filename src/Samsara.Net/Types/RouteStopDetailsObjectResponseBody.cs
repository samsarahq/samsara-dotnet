using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record RouteStopDetailsObjectResponseBody
{
    [JsonPropertyName("driver")]
    public GoaDriverTinyResponseResponseBody? Driver { get; set; }

    /// <summary>
    /// The operation that was performed as part of this route update.  Valid values: `stop arrived`, `stop departed`
    /// </summary>
    [JsonPropertyName("operation")]
    public RouteStopDetailsObjectResponseBodyOperation? Operation { get; set; }

    [JsonPropertyName("route")]
    public required WebhookRouteResponseObjectResponseBody Route { get; set; }

    [JsonPropertyName("routeStopDetails")]
    public required MinimalRouteStopResponseBody RouteStopDetails { get; set; }

    /// <summary>
    /// The timestamp of the route in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("time")]
    public required DateTime Time { get; set; }

    /// <summary>
    /// The type of route update. The route tracking updates occur as a route is completed and stops transition from one state to another. Currently only Route Tracking updates are supported, but this will change in the future when additional types are added.  Valid values: `route tracking`
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    [JsonPropertyName("vehicle")]
    public VehicleWithGatewayTinyResponseResponseBody? Vehicle { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
