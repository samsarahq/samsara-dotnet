using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

public record BetaApIsGetSpeedingIntervalsRequest
{
    /// <summary>
    /// Comma-separated list of asset IDs. Include up to 50 asset IDs.
    /// </summary>
    public IEnumerable<string> AssetIds { get; set; } = new List<string>();

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
    public BetaApIsGetSpeedingIntervalsRequestQueryBy? QueryBy { get; set; }

    /// <summary>
    /// Indicates whether or not to return expanded “asset” data
    /// </summary>
    public bool? IncludeAsset { get; set; }

    /// <summary>
    /// Indicates whether or not to return trip's driver id
    /// </summary>
    public bool? IncludeDriverId { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    public string? After { get; set; }

    /// <summary>
    /// Optional string of comma-separated severity levels to filter speeding intervals by. Valid values:  “light”, ”moderate”, ”heavy”, “severe”.
    /// </summary>
    public IEnumerable<string> SeverityLevels { get; set; } = new List<string>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
