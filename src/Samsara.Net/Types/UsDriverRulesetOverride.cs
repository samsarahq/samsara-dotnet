using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// US Driver Ruleset override for a given driver. If the driver is operating under a ruleset different from the organization default, the override is used. Updating this value only updates the override setting for this driver. Explicitly setting this field to `null` will delete driver's ruleset override. If the driver does not have an override ruleset set, the response will not include any usDriverRulesetOverride information.
/// </summary>
[Serializable]
public record UsDriverRulesetOverride : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The driver's working cycle. Valid values: `USA Property (8/70)`, `USA Property (7/60)`, `USA Passenger (8/70)`, `USA Passenger (7/60)`, `Alaska Property (8/80)`, `Alaska Property (7/70)`, `Alaska Passenger (8/80)`, `Alaska Passenger (7/70)`, `California School/FLV (8/80)`, `California Farm (8/112)`, `California Property (8/80)`, `California Flammable Liquid (8/80)`, `California Passenger (8/80)`, `California Motion Picture (8/80)`, `Florida (8/80)`, `Florida (7/70)`, `Nebraska (8/80)`, `Nebraska (7/70)`, `North Carolina (8/80)`, `North Carolina (7/70)`, `Oklahoma (8/70)`, `Oklahoma (7/60)`, `Oregon (8/80)`, `Oregon (7/70)`, `South Carolina (8/80)`, `South Carolina (7/70)`, `Texas (7/70)`, `Wisconsin (8/80)`, `Wisconsin (7/70)`
    /// </summary>
    [JsonPropertyName("cycle")]
    public required UsDriverRulesetOverrideCycle Cycle { get; set; }

    /// <summary>
    /// Amount of time necessary for the driver to be resting in order to restart their cycle. Valid values: `34-hour Restart`, `24-hour Restart`, `36-hour Restart`, `72-hour Restart`, `None`.
    /// </summary>
    [JsonPropertyName("restart")]
    public required UsDriverRulesetOverrideRestart Restart { get; set; }

    /// <summary>
    /// The restbreak required for this driver. Valid values: `Property (off-duty/sleeper)`, `California Mealbreak (off-duty/sleeper)`, `None`.
    /// </summary>
    [JsonPropertyName("restbreak")]
    public required UsDriverRulesetOverrideRestbreak Restbreak { get; set; }

    /// <summary>
    /// The jurisdiction of the ruleset applied to this driver. These are specified by either the ISO 3166-2 postal code for the supported US states, or empty string '' for US Federal Ruleset jurisdiction. Valid values: ``, `AK`, `CA`, `FL`, `NE`, `NC`, `OK`, `OR`, `SC`, `TX`, `WI`.
    /// </summary>
    [JsonPropertyName("usStateToOverride")]
    public required UsDriverRulesetOverrideUsStateToOverride UsStateToOverride { get; set; }

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
