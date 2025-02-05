using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DispatchJobWithoutEta
{
    /// <summary>
    /// The time at which the driver arrived at the job destination.
    /// </summary>
    [JsonPropertyName("arrived_at_ms")]
    public long? ArrivedAtMs { get; set; }

    /// <summary>
    /// The time at which the job was marked complete (e.g. started driving to the next destination).
    /// </summary>
    [JsonPropertyName("completed_at_ms")]
    public long? CompletedAtMs { get; set; }

    /// <summary>
    /// ID of the route that this job belongs to.
    /// </summary>
    [JsonPropertyName("dispatch_route_id")]
    public required long DispatchRouteId { get; set; }

    /// <summary>
    /// Document submissions associated with this job.
    /// </summary>
    [JsonPropertyName("documents")]
    public IEnumerable<V1DispatchJobDocumentInfo>? Documents { get; set; }

    /// <summary>
    /// ID of the driver assigned to the dispatch job.
    /// </summary>
    [JsonPropertyName("driver_id")]
    public long? DriverId { get; set; }

    /// <summary>
    /// The time at which the assigned driver started fulfilling the job (e.g. started driving to the destination).
    /// </summary>
    [JsonPropertyName("en_route_at_ms")]
    public long? EnRouteAtMs { get; set; }

    /// <summary>
    /// Fleet viewer url of the dispatch job.
    /// </summary>
    [JsonPropertyName("fleet_viewer_url")]
    public string? FleetViewerUrl { get; set; }

    /// <summary>
    /// Deprecated.
    /// </summary>
    [JsonPropertyName("group_id")]
    public long? GroupId { get; set; }

    /// <summary>
    /// ID of the Samsara dispatch job.
    /// </summary>
    [JsonPropertyName("id")]
    public required long Id { get; set; }

    [JsonPropertyName("job_state")]
    public required V1JobStatus JobState { get; set; }

    /// <summary>
    /// The time at which the job was marked skipped.
    /// </summary>
    [JsonPropertyName("skipped_at_ms")]
    public long? SkippedAtMs { get; set; }

    /// <summary>
    /// ID of the vehicle used for the dispatch job.
    /// </summary>
    [JsonPropertyName("vehicle_id")]
    public long? VehicleId { get; set; }

    /// <summary>
    /// The address of the job destination, as it would be recognized if provided to maps.google.com. Optional if a valid destination address ID is provided.
    /// </summary>
    [JsonPropertyName("destination_address")]
    public string? DestinationAddress { get; set; }

    /// <summary>
    /// ID of the job destination associated with an address book entry. Optional if valid values are provided for destination address and latitude/longitude. If a valid destination address ID is provided, address/latitude/longitude will be used from the address book entry. Name of the address book entry will only be used if the destination name is not provided.
    /// </summary>
    [JsonPropertyName("destination_address_id")]
    public long? DestinationAddressId { get; set; }

    /// <summary>
    /// Latitude of the destination in decimal degrees. Optional if a valid destination address ID is provided.
    /// </summary>
    [JsonPropertyName("destination_lat")]
    public double? DestinationLat { get; set; }

    /// <summary>
    /// Longitude of the destination in decimal degrees. Optional if a valid destination address ID is provided.
    /// </summary>
    [JsonPropertyName("destination_lng")]
    public double? DestinationLng { get; set; }

    /// <summary>
    /// The name of the job destination. If provided, it will take precedence over the name of the address book entry.
    /// </summary>
    [JsonPropertyName("destination_name")]
    public string? DestinationName { get; set; }

    [JsonPropertyName("external_ids")]
    public object? ExternalIds { get; set; }

    /// <summary>
    /// Notes regarding the details of this job, maximum of 2000 characters; newline characters ('\n')can be used for formatting.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// The time at which the assigned driver is scheduled to arrive at the job destination.
    /// </summary>
    [JsonPropertyName("scheduled_arrival_time_ms")]
    public required long ScheduledArrivalTimeMs { get; set; }

    /// <summary>
    /// The time at which the assigned driver is scheduled to depart from the job destination.
    /// </summary>
    [JsonPropertyName("scheduled_departure_time_ms")]
    public long? ScheduledDepartureTimeMs { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
