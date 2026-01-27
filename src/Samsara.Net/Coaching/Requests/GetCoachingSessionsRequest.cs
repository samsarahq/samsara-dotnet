using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Coaching;

[Serializable]
public record GetCoachingSessionsRequest
{
    /// <summary>
    /// Optional string of comma separated driver IDs. If driver ID is present, sessions for the specified driver(s) will be returned.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> DriverIds { get; set; } = new List<string>();

    /// <summary>
    /// Optional string of comma separated user IDs. If coach ID is present, sessions for the specified coach(s) will be returned for either assignedCoach or completedCoach. If both driverId(s) and coachId(s) are present, sessions with specified driver(s) and coach(es) will be returned.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> CoachIds { get; set; } = new List<string>();

    /// <summary>
    /// Optional string of comma separated statuses. Valid values:  “upcoming”, “completed”, “deleted”.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> SessionStatuses { get; set; } = new List<string>();

    /// <summary>
    /// Optional boolean to control whether behaviors will include coachableEvents in the response. Defaults to false.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeCoachableEvents { get; set; }

    /// <summary>
    /// Required RFC 3339 timestamp that indicates when to begin receiving data. Value is compared against `updatedAtTime`
    /// </summary>
    [JsonIgnore]
    public required DateTime StartTime { get; set; }

    /// <summary>
    /// Optional RFC 3339 timestamp. If not provided then the endpoint behaves as an unending feed of changes. If endTime is set the same as startTime, the most recent data point before that time will be returned per asset. Value is compared against `updatedAtTime`
    /// </summary>
    [JsonIgnore]
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

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
