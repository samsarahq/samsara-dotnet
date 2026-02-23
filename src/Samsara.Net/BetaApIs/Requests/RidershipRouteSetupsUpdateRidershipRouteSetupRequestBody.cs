using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record RidershipRouteSetupsUpdateRidershipRouteSetupRequestBody
{
    /// <summary>
    /// The route ID. This is the Samsara route ID returned by the Routing API.
    /// </summary>
    [JsonIgnore]
    public required string RouteId { get; set; }

    /// <summary>
    /// The Samsara UUID of the ridership account.
    /// </summary>
    [JsonPropertyName("accountId")]
    public required string AccountId { get; set; }

    /// <summary>
    /// List of passenger assignments for the route.
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
