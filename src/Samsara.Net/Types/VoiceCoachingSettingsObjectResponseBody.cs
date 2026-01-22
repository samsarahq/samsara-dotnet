using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Enabling voice coaching will play messages for harsh events, speeding, and unbuckled seat belts.
/// </summary>
[Serializable]
public record VoiceCoachingSettingsObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Selected driving events will be enabled for voice coaching. Harsh driving events include harsh acceleration and harsh brake.
    /// </summary>
    [JsonPropertyName("eventsToCoach")]
    public IEnumerable<VoiceCoachingSettingsObjectResponseBodyEventsToCoachItem>? EventsToCoach { get; set; }

    /// <summary>
    /// Indicates whether voice coaching is turned on.
    /// </summary>
    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }

    /// <summary>
    /// The coaching language. The default language is English.  Valid values: `english`, `spanish`, `dutch`, `englishUk`, `italian`, `french`, `german`
    /// </summary>
    [JsonPropertyName("language")]
    public VoiceCoachingSettingsObjectResponseBodyLanguage? Language { get; set; }

    /// <summary>
    /// Alert when speed is over this many miles per hour.
    /// </summary>
    [JsonPropertyName("speedingThresholdMph")]
    public double? SpeedingThresholdMph { get; set; }

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
