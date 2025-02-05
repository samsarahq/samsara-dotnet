using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record PolicyViolationsDetectionAlertSettingsObjectResponseBody
{
    /// <summary>
    /// List of selectable beta policy violation events to be tested.
    /// </summary>
    [JsonPropertyName("eventsAvailableForTesting")]
    public IEnumerable<PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsAvailableForTestingItem>? EventsAvailableForTesting { get; set; }

    /// <summary>
    /// List of selectable policy violation events to enable coaching for.
    /// </summary>
    [JsonPropertyName("eventsToCoach")]
    public IEnumerable<PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsToCoachItem>? EventsToCoach { get; set; }

    /// <summary>
    /// Indicates whether in-cab audio alerts for rolling stops are turned on.
    /// </summary>
    [JsonPropertyName("hasInCabAudioAlertsEnabled")]
    public bool? HasInCabAudioAlertsEnabled { get; set; }

    /// <summary>
    /// Indicates whether AI event detection for rolling stops is turned on.
    /// </summary>
    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }

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
