using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// An ELD ruleset for a driver.
/// </summary>
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
