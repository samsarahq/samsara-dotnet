using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VisionStepResultsItemLabelMatch
{
    [JsonPropertyName("score")]
    public long? Score { get; set; }

    [JsonPropertyName("threshold")]
    public long? Threshold { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
