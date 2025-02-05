using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DispatchJobAllOf
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
    /// The time at which the assigned driver is estimated to arrive at the job destination. Only valid for en-route jobs.
    /// </summary>
    [JsonPropertyName("estimated_arrival_ms")]
    public long? EstimatedArrivalMs { get; set; }

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
