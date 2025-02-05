using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DispatchRouteWithoutEta
{
    /// <summary>
    /// The dispatch jobs associated with this route.
    /// </summary>
    [JsonPropertyName("dispatch_jobs")]
    public IEnumerable<V1DispatchJobWithoutEta>? DispatchJobs { get; set; }

    /// <summary>
    /// ID of the Samsara dispatch route.
    /// </summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>
    /// The time in Unix epoch milliseconds that the route actually ended.
    /// </summary>
    [JsonPropertyName("actual_end_ms")]
    public long? ActualEndMs { get; set; }

    /// <summary>
    /// The time in Unix epoch milliseconds that the route actually started.
    /// </summary>
    [JsonPropertyName("actual_start_ms")]
    public long? ActualStartMs { get; set; }

    /// <summary>
    /// When set to true (default), this causes the Route to complete on arrival at the final stop. When set to false, the last stop will capture arrival and departure separately as with other stops.
    /// </summary>
    [JsonPropertyName("complete_last_stop_on_arrival")]
    public bool? CompleteLastStopOnArrival { get; set; }

    /// <summary>
    /// ID of the driver assigned to the dispatch route. Note that driver_id and vehicle_id are mutually exclusive. If neither is specified, then the route is unassigned.
    /// </summary>
    [JsonPropertyName("driver_id")]
    public long? DriverId { get; set; }

    [JsonPropertyName("externalIds")]
    public object? ExternalIds { get; set; }

    /// <summary>
    /// Deprecated.
    /// </summary>
    [JsonPropertyName("group_id")]
    public long? GroupId { get; set; }

    /// <summary>
    /// Descriptive name of this route.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Notes regarding the details of this route; maximum of 2000 characters; newline characters ('\n')can be used for formatting.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// Odometer reading at the end of the route. Will not be returned if Route is not completed or if Odometer information is not available for the relevant vehicle.
    /// </summary>
    [JsonPropertyName("odometer_end_meters")]
    public long? OdometerEndMeters { get; set; }

    /// <summary>
    /// Odometer reading at the start of the route. Will not be returned if Route has not started or if Odometer information is not available for the relevant vehicle.
    /// </summary>
    [JsonPropertyName("odometer_start_meters")]
    public long? OdometerStartMeters { get; set; }

    /// <summary>
    /// The time in Unix epoch milliseconds that the last job in the route is scheduled to end.
    /// </summary>
    [JsonPropertyName("scheduled_end_ms")]
    public long? ScheduledEndMs { get; set; }

    /// <summary>
    /// The distance expected to be traveled for this route in meters.
    /// </summary>
    [JsonPropertyName("scheduled_meters")]
    public long? ScheduledMeters { get; set; }

    /// <summary>
    /// The time in Unix epoch milliseconds that the route is scheduled to start.
    /// </summary>
    [JsonPropertyName("scheduled_start_ms")]
    public long? ScheduledStartMs { get; set; }

    /// <summary>
    /// The address of the route's starting location, as it would be recognized if provided to maps.google.com. Optional if a valid start location address ID is provided.
    /// </summary>
    [JsonPropertyName("start_location_address")]
    public string? StartLocationAddress { get; set; }

    /// <summary>
    /// ID of the start location associated with an address book entry. Optional if valid values are provided for start location address and latitude/longitude. If a valid start location address ID is provided, address/latitude/longitude will be used from the address book entry. Name of the address book entry will only be used if the start location name is not provided.
    /// </summary>
    [JsonPropertyName("start_location_address_id")]
    public long? StartLocationAddressId { get; set; }

    /// <summary>
    /// Latitude of the start location in decimal degrees. Optional if a valid start location address ID is provided.
    /// </summary>
    [JsonPropertyName("start_location_lat")]
    public double? StartLocationLat { get; set; }

    /// <summary>
    /// Longitude of the start location in decimal degrees. Optional if a valid start location address ID is provided.
    /// </summary>
    [JsonPropertyName("start_location_lng")]
    public double? StartLocationLng { get; set; }

    /// <summary>
    /// The name of the route's starting location. If provided, it will take precedence over the name of the address book entry.
    /// </summary>
    [JsonPropertyName("start_location_name")]
    public string? StartLocationName { get; set; }

    /// <summary>
    /// ID of the trailer assigned to the dispatch route. Note that trailers can only be assigned to routes that have a Vehicle or Driver assigned to them.
    /// </summary>
    [JsonPropertyName("trailer_id")]
    public long? TrailerId { get; set; }

    /// <summary>
    /// ID of the vehicle assigned to the dispatch route. Note that vehicle_id and driver_id are mutually exclusive. If neither is specified, then the route is unassigned.
    /// </summary>
    [JsonPropertyName("vehicle_id")]
    public long? VehicleId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
