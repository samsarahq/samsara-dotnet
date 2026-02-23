using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetTagSafetyScoresRequest
{
    /// <summary>
    /// End time in RFC 3339 format. Millisecond precision and timezones are supported. Includes trips that end before this timestamp.
    /// </summary>
    [JsonIgnore]
    public required string EndTime { get; set; }

    /// <summary>
    /// Start time in RFC 3339 format. Millisecond precision and timezones are supported. Includes trips that end after this timestamp. Can be up to 1 year before endTime.
    /// </summary>
    [JsonIgnore]
    public required string StartTime { get; set; }

    /// <summary>
    /// Whether to calculate tag score with either all drivers or all vehicles in the tag. Deactivated drivers and unassigned trips are not included when calculating scores for drivers.   Valid values: `driver`, `vehicle`
    /// </summary>
    [JsonIgnore]
    public required GetTagSafetyScoresRequestScoreType ScoreType { get; set; }

    /// <summary>
    /// Comma separated list of tag IDs to filter by. Include up to 100 IDs. Defaults to all tags.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> TagIds { get; set; } = new List<string>();

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
