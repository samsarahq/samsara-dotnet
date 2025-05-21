using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The response includes 4 additional fields that are now deprecated
/// </summary>
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
