using Samsara.Net.Core;

namespace Samsara.Net.Safety;

public record SafetyGetSafetyActivityEventFeedRequest
{
    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    public string? After { get; set; }

    /// <summary>
    /// A start time in RFC 3339 format. Defaults to now if not provided. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    public string? StartTime { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
