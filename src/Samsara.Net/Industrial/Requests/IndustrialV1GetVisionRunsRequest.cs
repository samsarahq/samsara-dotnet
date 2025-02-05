using Samsara.Net.Core;

namespace Samsara.Net.Industrial;

public record IndustrialV1GetVisionRunsRequest
{
    /// <summary>
    /// DurationMs is a required param. This works with the EndMs parameter. Indicates the duration in which the visionRuns will be fetched
    /// </summary>
    public required long DurationMs { get; set; }

    /// <summary>
    /// EndMs is an optional param. It will default to the current time.
    /// </summary>
    public long? EndMs { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
