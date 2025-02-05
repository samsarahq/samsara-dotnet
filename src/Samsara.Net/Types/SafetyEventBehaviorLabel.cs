using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record SafetyEventBehaviorLabel
{
    [JsonPropertyName("label")]
    public required SafetyEventBehaviorLabelType Label { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("source")]
    public required SafetyEventBehaviorLabelSource Source { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
