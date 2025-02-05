using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VisionStepResultsItemBooleanLogic
{
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("steps")]
    public IEnumerable<V1VisionStepResultsItemBooleanLogicStepsItem>? Steps { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
