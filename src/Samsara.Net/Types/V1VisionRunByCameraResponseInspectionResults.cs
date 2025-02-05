using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VisionRunByCameraResponseInspectionResults
{
    [JsonPropertyName("captureAtMs")]
    public float? CaptureAtMs { get; set; }

    [JsonPropertyName("result")]
    public string? Result { get; set; }

    [JsonPropertyName("stepResults")]
    public IEnumerable<V1VisionStepResultsItem>? StepResults { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
