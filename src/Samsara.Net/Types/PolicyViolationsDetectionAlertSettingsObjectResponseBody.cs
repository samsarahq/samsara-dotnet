using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Enables detection of policy violations, surfaces events in Safety Inbox, and enables configurable alerts. While the feature is in beta, in-cab alerts are recommended for testing use only.
/// </summary>
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
