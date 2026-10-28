using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetDepreciationTransactionsRequest
{
    /// <summary>
    /// RFC 3339 timestamp. Inclusive start of the range, compared against queryByTimeField. Required when querying by eventTime; optional when querying by updatedAtTime. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonIgnore]
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// RFC 3339 timestamp. Exclusive end of the range, compared against queryByTimeField. If omitted, the range is open-ended. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonIgnore]
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// Time field compared with startTime and endTime. Defaults to eventTime for organizations enabled for event-time queries; otherwise updatedAtTime.  Valid values: `eventTime`, `updatedAtTime`
    /// </summary>
    [JsonIgnore]
    public GetDepreciationTransactionsRequestQueryByTimeField? QueryByTimeField { get; set; }

    /// <summary>
    /// Filter by asset IDs. Up to 50 ids.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> AssetIds { get; set; } = new List<string>();

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
