using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record RidershipRouteSetupsUpdateRidershipRouteSetupRequestBody
{
    /// <summary>
    /// The Samsara route ID returned by the Routing API, or an external ID in `key:value` format. For example, `extRoute:WB-12`.
    /// </summary>
    [JsonIgnore]
    public required string RouteId { get; set; }

    /// <summary>
    /// Passenger assignments for the route, with each passenger listed once.
    /// </summary>
    [JsonPropertyName("passengers")]
    public IEnumerable<RidershipRouteSetupPassengerInputRequestBody> Passengers { get; set; } =
        new List<RidershipRouteSetupPassengerInputRequestBody>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
