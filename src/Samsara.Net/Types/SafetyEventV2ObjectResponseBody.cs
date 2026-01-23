using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Full Safety Event object
/// </summary>
[Serializable]
public record SafetyEventV2ObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("asset")]
    public required SafetyEventV2AssetObjectResponseBody Asset { get; set; }

    /// <summary>
    /// Unique user ID for the assigned coach.
    /// </summary>
    [JsonPropertyName("assignedCoach")]
    public string? AssignedCoach { get; set; }

    /// <summary>
    /// The most up-to-date behavior labels associated with the safety event. These labels can be updated by Safety Admins.
    /// </summary>
    [JsonPropertyName("behaviorLabels")]
    public IEnumerable<SafetyEventV2BehaviorLabelsResponseBody> BehaviorLabels { get; set; } =
        new List<SafetyEventV2BehaviorLabelsResponseBody>();

    /// <summary>
    /// The most up-to-date context labels associated with the safety event. AI generated labels can be updated by Safety Admins.
    /// </summary>
    [JsonPropertyName("contextLabels")]
    public IEnumerable<SafetyEventV2ContextLabelsResponseBody> ContextLabels { get; set; } =
        new List<SafetyEventV2ContextLabelsResponseBody>();

    /// <summary>
    /// UTC time the Safety Event was created in Samsara in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required string CreatedAtTime { get; set; }

    /// <summary>
    /// Camera streams that detected the safety event.
    /// </summary>
    [JsonPropertyName("detectedStreams")]
    public IEnumerable<SafetyEventV2MediaResponseBody>? DetectedStreams { get; set; }

    [JsonPropertyName("dismissalReason")]
    public SafetyEventDismissalReasonResponseBody? DismissalReason { get; set; }

    [JsonPropertyName("driver")]
    public required SafetyEventV2DriverObjectResponseBody Driver { get; set; }

    /// <summary>
    /// UTC time the Safety Event ended in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("endMs")]
    public required string EndMs { get; set; }

    /// <summary>
    /// The current state of the Safety Event.  Valid values: `unknown`, `needsReview`, `reviewed`, `needsCoaching`, `coached`, `dismissed`, `needsRecognition`, `recognized`
    /// </summary>
    [JsonPropertyName("eventState")]
    public required SafetyEventV2ObjectResponseBodyEventState EventState { get; set; }

    /// <summary>
    /// The unique Samsara ID (uuid) of the safety event.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// A link to the Safety Event review page for the associated event.
    /// </summary>
    [JsonPropertyName("inboxEventUrl")]
    public required string InboxEventUrl { get; set; }

    /// <summary>
    /// If a harsh event, returns the URL of the associated incident report page. If a speeding event, returns the URL of the associated speeding report page.
    /// </summary>
    [JsonPropertyName("incidentReportUrl")]
    public required string IncidentReportUrl { get; set; }

    [JsonPropertyName("location")]
    public required LocationResponseResponseBody Location { get; set; }

    /// <summary>
    /// The maximum acceleration value as a multiplier on the force of gravity (g).
    /// </summary>
    [JsonPropertyName("maxAccelerationGForce")]
    public required double MaxAccelerationGForce { get; set; }

    /// <summary>
    /// Media assets available for the safety event.
    /// </summary>
    [JsonPropertyName("media")]
    public IEnumerable<SafetyEventV2MediaResponseBody>? Media { get; set; }

    [JsonPropertyName("speedingMetadata")]
    public SafetyEventSpeedingMetadataResponseBody? SpeedingMetadata { get; set; }

    /// <summary>
    /// UTC time the Safety Event started in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("startMs")]
    public required string StartMs { get; set; }

    /// <summary>
    /// UTC time the trip ended in RFC 3339 format. Null when Safety Event occurs off-trip or the trip is ongoing.
    /// </summary>
    [JsonPropertyName("tripEndTime")]
    public string? TripEndTime { get; set; }

    /// <summary>
    /// UTC time the trip started in RFC 3339 format. Null when Safety Event occurs off-trip.
    /// </summary>
    [JsonPropertyName("tripStartTime")]
    public string? TripStartTime { get; set; }

    /// <summary>
    /// UTC time the Safety Event was updated in Samsara in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required string UpdatedAtTime { get; set; }

    /// <summary>
    /// The user ID associated with the user who made the event state change. Only returned if the event state changes.
    /// </summary>
    [JsonPropertyName("updatedByUserId")]
    public string? UpdatedByUserId { get; set; }

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
