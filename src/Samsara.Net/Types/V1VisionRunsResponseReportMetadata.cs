using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VisionRunsResponseReportMetadata
{
    /// <summary>
    /// Returns average scanned items per minute. Should be used instead of scanRate.
    /// </summary>
    [JsonPropertyName("itemsPerMinute")]
    public float? ItemsPerMinute { get; set; }

    /// <summary>
    /// Returns no read count for the run. Should be used instead of noReadScansCount
    /// </summary>
    [JsonPropertyName("noReadCount")]
    public long? NoReadCount { get; set; }

    /// <summary>
    /// Returns reject count for the run. Should be used instead of failedScansCount
    /// </summary>
    [JsonPropertyName("rejectCount")]
    public long? RejectCount { get; set; }

    /// <summary>
    /// Returns success count for the run. Should be used instead of successfulScansCount
    /// </summary>
    [JsonPropertyName("successCount")]
    public long? SuccessCount { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
