using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VisionRunsByCameraAndProgramResponse
{
    [JsonPropertyName("deviceId")]
    public long? DeviceId { get; set; }

    [JsonPropertyName("endedAtMs")]
    public long? EndedAtMs { get; set; }

    [JsonPropertyName("programId")]
    public long? ProgramId { get; set; }

    [JsonPropertyName("reportMetadata")]
    public V1VisionRunByCameraResponseRunSummary? ReportMetadata { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<V1VisionRunByCameraResponseInspectionResults>? Results { get; set; }

    [JsonPropertyName("startedAtMs")]
    public long? StartedAtMs { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
