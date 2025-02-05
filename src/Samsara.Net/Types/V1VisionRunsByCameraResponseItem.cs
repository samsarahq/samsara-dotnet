using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VisionRunsByCameraResponseItem
{
    [JsonPropertyName("deviceId")]
    public long? DeviceId { get; set; }

    [JsonPropertyName("endedAtMs")]
    public long? EndedAtMs { get; set; }

    [JsonPropertyName("program")]
    public V1VisionRunsByCameraResponseItemProgram? Program { get; set; }

    [JsonPropertyName("reportMetadata")]
    public V1VisionRunsByCameraResponseItemReportMetadata? ReportMetadata { get; set; }

    [JsonPropertyName("startedAtMs")]
    public long? StartedAtMs { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
