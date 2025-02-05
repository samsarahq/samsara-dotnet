using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

public record BetaApIsGetTripsRequest
{
    /// <summary>
    /// Indicates whether or not to return expanded “asset” data
    /// </summary>
    public bool? IncludeAsset { get; set; }

    /// <summary>
    /// Filters trips based on a specific completion status  Valid values: `inProgress`, `completed`, `all`
    /// </summary>
    public BetaApIsGetTripsRequestCompletionStatus? CompletionStatus { get; set; }

    /// <summary>
    /// RFC 3339 timestamp that indicates when to begin receiving data. Value is compared against `updatedAtTime` or `tripStartTime` depending on the queryBy parameter.
    /// </summary>
    public required string StartTime { get; set; }

    /// <summary>
    /// RFC 3339 timestamp which is compared against `updatedAtTime` or `tripStartTime` depending on the queryBy parameter. If not provided then the endpoint behaves as an unending feed of changes.
    /// </summary>
    public string? EndTime { get; set; }

    /// <summary>
    /// Decide which timestamp the `startTime` and `endTime` are compared to.  Valid values: `updatedAtTime`, `tripStartTime`
    /// </summary>
    public BetaApIsGetTripsRequestQueryBy? QueryBy { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    public string? After { get; set; }

    /// <summary>
    /// Comma-separated list of asset IDs. Include up to 50 asset IDs.
    /// </summary>
    public IEnumerable<string> Ids { get; set; } = new List<string>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
