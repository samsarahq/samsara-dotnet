using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VisionStepResultsItemExpirationDate
{
    [JsonPropertyName("dateOffset")]
    public long? DateOffset { get; set; }

    [JsonPropertyName("foundDate")]
    public string? FoundDate { get; set; }

    [JsonPropertyName("matchDate")]
    public string? MatchDate { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
