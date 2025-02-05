using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VisionRunsResponse
{
    [JsonPropertyName("visionRuns")]
    public IEnumerable<V1VisionRunsResponseVisionRuns>? VisionRuns { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
