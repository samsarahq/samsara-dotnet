using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record DriverRulesetObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The rest break required setting of the ELD ruleset applied to this driver.  Valid values: `Property (off-duty/sleeper)`, `Explosives/HazMat (on-duty)`
    /// </summary>
    [JsonPropertyName("break")]
    public DriverRulesetObjectResponseBodyBreak? Break { get; set; }

    /// <summary>
    /// The cycle of the ELD ruleset applied to this driver.  Valid values: `USA 60 hour / 7 day`, `USA 70 hour / 8 day`, `AK 80 hour / 8 day`, `AK 70 hour / 7 day`, `CA 80 hour / 8 day`, `CA 112 hour / 8 day`, `FL 80 hour / 8 day`, `FL 70 hour / 7 day`, `NE 80 hour / 8 day`, `NE 70 hour / 7 day`, `NC 80 hour / 8 day`, `NC 70 hour / 7 day`, `OK 70 hour / 8 day`, `OK 60 hour / 7 day`, `OR 80 hour / 8 day`, `OR 70 hour / 7 day`, `SC 80 hour / 8 day`, `SC 70 hour / 7 day`, `TX 70 hour / 7 day`, `WI 80 hour / 8 day`, `WI 70 hour / 7 day`, `Canada South Cycle 1 (70 hour / 7 day)`, `Canada South Cycle 2 (120 hour / 14 day)`, `Canada North Cycle 1 (80 hour / 7 day)`, `Canada North Cycle 2 (120 hour / 14 day)`
    /// </summary>
    [JsonPropertyName("cycle")]
    public DriverRulesetObjectResponseBodyCycle? Cycle { get; set; }

    /// <summary>
    /// The jurisdiction of the ELD ruleset applied to this driver. These are specified by either `CS` or `CN` for Canada South and Canada North, respectively, or the ISO 3166-2 postal code for the supported state or territory.
    /// </summary>
    [JsonPropertyName("jurisdiction")]
    public string? Jurisdiction { get; set; }

    /// <summary>
    /// The restart of the ELD ruleset applied to this driver.  Valid values: `34-hour Restart`, `24-hour Restart`, `36-hour Restart`, `72-hour Restart`
    /// </summary>
    [JsonPropertyName("restart")]
    public DriverRulesetObjectResponseBodyRestart? Restart { get; set; }

    /// <summary>
    /// The shift of the ELD ruleset applied to this driver.  Valid values: `US Interstate Property`, `US Interstate Passenger`
    /// </summary>
    [JsonPropertyName("shift")]
    public DriverRulesetObjectResponseBodyShift? Shift { get; set; }

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
