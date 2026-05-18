using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record RidershipRouteSetupsCreateRidershipRouteSetupRequestBody
{
    /// <summary>
    /// List of passenger assignments for the route.
    /// </summary>
    [JsonPropertyName("passengers")]
    public IEnumerable<RidershipRouteSetupPassengerInputRequestBody> Passengers { get; set; } =
        new List<RidershipRouteSetupPassengerInputRequestBody>();

    /// <summary>
    /// The Samsara route ID returned by the Routing API, or an external ID in `key:value` format. For example, `extRoute:WB-12`.
    /// </summary>
    [JsonPropertyName("routeId")]
    public required string RouteId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
