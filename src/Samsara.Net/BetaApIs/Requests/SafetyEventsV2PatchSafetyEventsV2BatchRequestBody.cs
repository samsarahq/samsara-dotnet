using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record SafetyEventsV2PatchSafetyEventsV2BatchRequestBody
{
    /// <summary>
    /// Behavior labels to add to the Safety Events.
    /// </summary>
    [JsonPropertyName("behaviorLabelsToAdd")]
    public IEnumerable<SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem>? BehaviorLabelsToAdd { get; set; }

    /// <summary>
    /// Behavior labels to remove from the Safety Events.
    /// </summary>
    [JsonPropertyName("behaviorLabelsToRemove")]
    public IEnumerable<SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToRemoveItem>? BehaviorLabelsToRemove { get; set; }

    /// <summary>
    /// Context labels to add to the Safety Events.
    /// </summary>
    [JsonPropertyName("contextLabelsToAdd")]
    public IEnumerable<SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem>? ContextLabelsToAdd { get; set; }

    /// <summary>
    /// Context labels to remove from the Safety Events.
    /// </summary>
    [JsonPropertyName("contextLabelsToRemove")]
    public IEnumerable<SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToRemoveItem>? ContextLabelsToRemove { get; set; }

    [JsonPropertyName("dismissalReason")]
    public PatchSafetyEventsDismissalReasonBodyRequestBody? DismissalReason { get; set; }

    /// <summary>
    /// The new state to apply to all specified Safety Events.  Valid values: `needsReview`, `reviewed`, `needsCoaching`, `coached`, `dismissed`, `needsRecognition`, `recognized`
    /// </summary>
    [JsonPropertyName("eventState")]
    public SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyEventState? EventState { get; set; }

    /// <summary>
    /// IDs of the Safety Events to update. Maximum 200.
    /// </summary>
    [JsonPropertyName("safetyEventIds")]
    public IEnumerable<string> SafetyEventIds { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
