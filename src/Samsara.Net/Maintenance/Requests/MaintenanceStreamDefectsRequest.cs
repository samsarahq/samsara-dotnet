using Samsara.Net.Core;

namespace Samsara.Net.Maintenance;

public record MaintenanceStreamDefectsRequest
{
    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    public string? After { get; set; }

    /// <summary>
    /// The limit for how many objects will be in the response. Default and max for this value is 200 objects.
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// Required RFC 3339 timestamp to begin the feed or history by `updatedAtTime` at `startTime`.
    /// </summary>
    public required string StartTime { get; set; }

    /// <summary>
    /// Optional RFC 3339 timestamp. If not provided then the endpoint behaves as an unending feed of changes.
    /// </summary>
    public string? EndTime { get; set; }

    /// <summary>
    /// Optional boolean indicating whether to return external IDs on supported entities
    /// </summary>
    public bool? IncludeExternalIds { get; set; }

    /// <summary>
    /// Boolean value for whether filter defects by resolved status.
    /// </summary>
    public bool? IsResolved { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
