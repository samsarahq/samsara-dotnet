using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VisionStepResultsItemBooleanLogicStepsItem
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("result")]
    public string? Result { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
