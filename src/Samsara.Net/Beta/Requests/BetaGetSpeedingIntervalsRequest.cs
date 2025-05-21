using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Beta;

public record BetaGetSpeedingIntervalsRequest
{
    /// <summary>
    /// Comma-separated list of asset IDs. Include up to 50 asset IDs.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> AssetIds { get; set; } = new List<string>();

    /// <summary>
    /// RFC 3339 timestamp that indicates when to begin receiving data. Value is compared against `updatedAtTime` or `tripStartTime` depending on the queryBy parameter.
    /// </summary>
    [JsonIgnore]
    public required string StartTime { get; set; }

    /// <summary>
    /// RFC 3339 timestamp which is compared against `updatedAtTime` or `tripStartTime` depending on the queryBy parameter. If not provided then the endpoint behaves as an unending feed of changes.
    /// </summary>
    [JsonIgnore]
    public string? EndTime { get; set; }

    /// <summary>
    /// Decide which timestamp the `startTime` and `endTime` are compared to.  Valid values: `updatedAtTime`, `tripStartTime`
    /// </summary>
    [JsonIgnore]
    public BetaGetSpeedingIntervalsRequestQueryBy? QueryBy { get; set; }

    /// <summary>
    /// Indicates whether or not to return expanded “asset” data
    /// </summary>
    [JsonIgnore]
    public bool? IncludeAsset { get; set; }

    /// <summary>
    /// Indicates whether or not to return trip's driver id
    /// </summary>
    [JsonIgnore]
    public bool? IncludeDriverId { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// Optional string of comma-separated severity levels to filter speeding intervals by. Valid values:  “light”, ”moderate”, ”heavy”, “severe”.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> SeverityLevels { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
