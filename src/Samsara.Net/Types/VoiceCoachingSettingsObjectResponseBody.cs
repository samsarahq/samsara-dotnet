using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Enabling voice coaching will play messages for harsh events, speeding, and unbuckled seat belts.
/// </summary>
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
