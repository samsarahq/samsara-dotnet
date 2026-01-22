using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Routes;

[Serializable]
public record RoutesPatchRouteRequestBody
{
    /// <summary>
    /// ID of the route. This can either be the Samsara-specified ID, or an external ID. External IDs are customer specified key-value pairs created in the POST or PATCH requests of this resource. To specify an external ID as part of a path parameter, use the following format: `key:value`. For example, `payrollId:ABFS18600`
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

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
    public string? Name { get; set; }

    /// <summary>
    /// Notes about the route.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// This optional boolean parameter controls whether route schedule arrival and departure times are recalculated. When set to true, the system will automatically recompute the scheduledArrivalTime and scheduledDepartureTime for each stop along the route during route creation. This process overrides any manually provided values, with the exception of the first stop, which retains its user-defined schedule.
    /// </summary>
    [JsonPropertyName("recomputeScheduledTimes")]
    public bool? RecomputeScheduledTimes { get; set; }

    [JsonPropertyName("settings")]
    public RouteSettingsRequestBody? Settings { get; set; }

    /// <summary>
    /// List of stops along the route. If a valid `id` of a stop is provided, that stop will be updated. If no `id` is provided for a passed in stop, that stop will be created. If `id` value are passed in for some stops and not for others, those with `id` value specified will be retained and updated in the original route, those without `id` value specified in the body will be created, and those without `id` value specified that already existed on the route will be deleted. For each new stop, exactly one of `addressId` and `singleUseLocation` are required. Depending on the `settings` on your route, either a `scheduledArrivalTime` or `scheduledDepartureTime` must be specified for the first job, if a new first job is being added.
    /// </summary>
    [JsonPropertyName("stops")]
    public IEnumerable<UpdateRoutesStopRequestObjectRequestBody>? Stops { get; set; }

    /// <summary>
    /// An array of IDs of tags to associate with this route.
    /// </summary>
    [JsonPropertyName("tagIds")]
    public IEnumerable<string>? TagIds { get; set; }

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
