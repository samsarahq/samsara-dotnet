using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VisionRunsResponseVisionRuns
{
    [JsonPropertyName("deviceId")]
    public long? DeviceId { get; set; }

    [JsonPropertyName("endedAtMs")]
    public long? EndedAtMs { get; set; }

    [JsonPropertyName("programId")]
    public long? ProgramId { get; set; }

    [JsonPropertyName("reportMetadata")]
    public V1VisionRunsResponseReportMetadata? ReportMetadata { get; set; }

    [JsonPropertyName("startedAtMs")]
    public long? StartedAtMs { get; set; }

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
