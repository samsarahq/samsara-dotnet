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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
