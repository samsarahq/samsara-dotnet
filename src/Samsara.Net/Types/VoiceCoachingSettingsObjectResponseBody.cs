using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VoiceCoachingSettingsObjectResponseBody
{
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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
