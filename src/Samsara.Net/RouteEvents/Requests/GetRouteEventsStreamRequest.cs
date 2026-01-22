using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.RouteEvents;

[Serializable]
public record GetRouteEventsStreamRequest
{
    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// A start time in RFC 3339 format. Defaults to 24 hours ago if not provided. Millisecond precision and timezones are supported. (Examples: 2025-07-01T19:08:25Z, 2025-07-01T19:08:25.455Z, OR 2025-07-01T14:00:12-04:00). Cannot be more than 7 days in the past.
    /// </summary>
    [JsonIgnore]
    public string? StartTime { get; set; }

    /// <summary>
    /// The limit for how many events will be in the response. Default and max for this value is 200 events.
    /// </summary>
    [JsonIgnore]
    public long? Limit { get; set; }

    /// <summary>
    /// Optional boolean indicating whether to return external IDs on supported entities
    /// </summary>
    [JsonIgnore]
    public bool? IncludeExternalIds { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
