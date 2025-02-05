using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VisionStepResultsItemFindEdgeSharpnessRange
{
    [JsonPropertyName("high")]
    public long? High { get; set; }

    [JsonPropertyName("low")]
    public long? Low { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
