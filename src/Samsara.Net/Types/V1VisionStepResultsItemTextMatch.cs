using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VisionStepResultsItemTextMatch
{
    [JsonPropertyName("foundText")]
    public string? FoundText { get; set; }

    [JsonPropertyName("matchString")]
    public string? MatchString { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
