using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EldSettingsObjectResponseBody
{
    /// <summary>
    /// The driver's ELD rulesets and overrides.
    /// </summary>
    [JsonPropertyName("rulesets")]
    public IEnumerable<DriverRulesetObjectResponseBody>? Rulesets { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
