using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Routes;

public record RoutesCreateRouteRequestBody
{
    /// <summary>
    /// ID of the driver. Can be either a unique Samsara ID or an [external ID](https://developers.samsara.com/docs/external-ids) for the driver.
    /// </summary>
    [JsonPropertyName("driverId")]
    public string? DriverId { get; set; }

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// Name for the route
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Notes about the route.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("settings")]
    public RouteSettingsRequestBody? Settings { get; set; }

    /// <summary>
    /// List of stops along the route. For each stop, exactly one of `addressId` and `singleUseLocation` are required. Depending on the `settings` on your route, either a `scheduledArrivalTime` or `scheduledDepartureTime` must be specified for the first job.
    /// </summary>
    [JsonPropertyName("stops")]
    public IEnumerable<CreateRoutesStopRequestObjectRequestBody> Stops { get; set; } =
        new List<CreateRoutesStopRequestObjectRequestBody>();

    /// <summary>
    /// ID of the vehicle. Can be either a unique Samsara ID or an [external ID](https://developers.samsara.com/docs/external-ids) for the vehicle.
    /// </summary>
    [JsonPropertyName("vehicleId")]
    public string? VehicleId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
