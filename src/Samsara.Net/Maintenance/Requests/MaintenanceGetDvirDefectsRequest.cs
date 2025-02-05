using Samsara.Net.Core;

namespace Samsara.Net.Maintenance;

public record MaintenanceGetDvirDefectsRequest
{
    /// <summary>
    /// The limit for how many objects will be in the response. Default and max for this value is 512 objects.
    /// </summary>
    public long? Limit { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    public string? After { get; set; }

    /// <summary>
    /// A start time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00). *The maximum time period you can query for is 30 days.*
    /// </summary>
    public required string StartTime { get; set; }

    /// <summary>
    /// An end time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00). *The maximum time period you can query for is 30 days.*
    /// </summary>
    public required string EndTime { get; set; }

    /// <summary>
    /// A filter on the data based on resolution status. Example: `isResolved=true`
    /// </summary>
    public bool? IsResolved { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
