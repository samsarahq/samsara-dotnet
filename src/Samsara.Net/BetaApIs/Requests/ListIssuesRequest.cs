using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record ListIssuesRequest
{
    /// <summary>
    /// A filter on the data based on this comma-separated list of ID values.
    /// </summary>
    [JsonIgnore]
    public string? Ids { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of Type values.
    /// </summary>
    [JsonIgnore]
    public string? Types { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of Status values.
    /// </summary>
    [JsonIgnore]
    public string? Statuses { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of Severity values.
    /// </summary>
    [JsonIgnore]
    public string? Severities { get; set; }

    /// <summary>
    /// An end time in RFC 3339 format. Millisecond precision and timezones are supported.
    /// </summary>
    [JsonIgnore]
    public string? EndTime { get; set; }

    /// <summary>
    /// Time field to filter with startTime and endTime. Defaults to updatedAtTime.
    /// </summary>
    [JsonIgnore]
    public string? QueryByTimeField { get; set; }

    /// <summary>
    /// A start time in RFC 3339 format. Millisecond precision and timezones are supported.
    /// </summary>
    [JsonIgnore]
    public string? StartTime { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// The limit for how many objects will be in the response. Default and max for this value is 200 objects.
    /// </summary>
    [JsonIgnore]
    public long? Limit { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
