using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverEldSettings
{
    [JsonPropertyName("rulesets")]
    public IEnumerable<DriverEldRuleset>? Rulesets { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
