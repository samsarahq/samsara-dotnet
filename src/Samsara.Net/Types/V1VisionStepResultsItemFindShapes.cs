using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VisionStepResultsItemFindShapes
{
    [JsonPropertyName("foundCount")]
    public int? FoundCount { get; set; }

    [JsonPropertyName("maxCount")]
    public int? MaxCount { get; set; }

    [JsonPropertyName("minCount")]
    public int? MinCount { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
