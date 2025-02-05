using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VisionRunsByCameraResponseItemReportMetadata
{
    [JsonPropertyName("itemsPerMinute")]
    public float? ItemsPerMinute { get; set; }

    [JsonPropertyName("noReadCount")]
    public long? NoReadCount { get; set; }

    [JsonPropertyName("rejectCount")]
    public long? RejectCount { get; set; }

    [JsonPropertyName("successCount")]
    public long? SuccessCount { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
