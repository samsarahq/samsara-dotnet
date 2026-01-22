using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// An ELD ruleset for a driver.
/// </summary>
[Serializable]
public record DriverEldRuleset : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
