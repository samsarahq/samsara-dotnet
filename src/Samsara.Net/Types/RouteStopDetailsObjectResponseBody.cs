using System.Text.Json;
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
    public string Type { get; set; } = "route tracking";

    [JsonPropertyName("vehicle")]
    public VehicleWithGatewayTinyResponseResponseBody? Vehicle { get; set; }

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
