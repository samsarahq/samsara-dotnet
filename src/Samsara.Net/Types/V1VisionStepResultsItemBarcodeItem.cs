using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VisionStepResultsItemBarcodeItem
{
    [JsonPropertyName("contents")]
    public string? Contents { get; set; }

    [JsonPropertyName("matchString")]
    public string? MatchString { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
