using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverEldRuleset
{
    [JsonPropertyName("break")]
    public DriverEldRulesetRestBreak? Break { get; set; }

    [JsonPropertyName("cycle")]
    public DriverEldRulesetCycle? Cycle { get; set; }

    [JsonPropertyName("jurisdiction")]
    public string? Jurisdiction { get; set; }

    [JsonPropertyName("restart")]
    public DriverEldRulesetRestart? Restart { get; set; }

    [JsonPropertyName("shift")]
    public DriverEldRulesetShift? Shift { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
