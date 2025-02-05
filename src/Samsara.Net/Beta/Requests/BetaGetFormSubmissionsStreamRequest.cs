using Samsara.Net.Core;

namespace Samsara.Net.Beta;

public record BetaGetFormSubmissionsStreamRequest
{
    /// <summary>
    /// A start time in RFC 3339 format. Defaults to now if not provided. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    public required string StartTime { get; set; }

    /// <summary>
    /// An end time in RFC 3339 format. Defaults to now if not provided. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    public string? EndTime { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    public string? After { get; set; }

    /// <summary>
    /// A comma-separated list containing up to 50 template IDs to filter data to.
    /// </summary>
    public IEnumerable<string> FormTemplateIds { get; set; } = new List<string>();

    /// <summary>
    /// A comma-separated list containing up to 50 user IDs to filter data to.
    /// </summary>
    public IEnumerable<string> UserIds { get; set; } = new List<string>();

    /// <summary>
    /// A comma-separated list containing up to 50 user IDs to filter data to.
    /// </summary>
    public IEnumerable<string> DriverIds { get; set; } = new List<string>();

    /// <summary>
    /// A comma-separated list of strings indicating whether to return additional information. Valid values: `externalIds`, `fieldLabels`
    /// </summary>
    public IEnumerable<string> Include { get; set; } = new List<string>();

    /// <summary>
    /// A comma-separated list containing up to 50 route stop IDs to filter data to.
    /// </summary>
    public IEnumerable<string> AssignedToRouteStopIds { get; set; } = new List<string>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
