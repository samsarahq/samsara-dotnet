using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// List of coaching sessions objects.
/// </summary>
[Serializable]
public record CoachingSessionsResponseResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Unique user ID for a coaching session. Returned when a coaching session status is “incomplete”.
    /// </summary>
    [JsonPropertyName("assignedCoachId")]
    public string? AssignedCoachId { get; set; }

    /// <summary>
    /// Object references for the behaviors within the session.
    /// </summary>
    [JsonPropertyName("behaviors")]
    public IEnumerable<BehaviorResponseBody> Behaviors { get; set; } =
        new List<BehaviorResponseBody>();

    /// <summary>
    /// Coaching type for the coaching session.  Valid values: `fullySharedWithManager`, `selfCoaching`, `unknown`, `unshared`, `withManager`
    /// </summary>
    [JsonPropertyName("coachingType")]
    public required CoachingSessionsResponseResponseBodyCoachingType CoachingType { get; set; }

    /// <summary>
    /// Time coaching session is completed in UTC. Returned when a coaching session status is “completed”.
    /// </summary>
    [JsonPropertyName("completedAtTime")]
    public DateTime? CompletedAtTime { get; set; }

    /// <summary>
    /// Unique user ID for a completed coaching session. Returned when a coaching session status is “completed”.
    /// </summary>
    [JsonPropertyName("completedCoachId")]
    public string? CompletedCoachId { get; set; }

    [JsonPropertyName("driver")]
    public required DriverWithExternalIdObjectResponseBody Driver { get; set; }

    /// <summary>
    /// Time coaching session is due in UTC.
    /// </summary>
    [JsonPropertyName("dueAtTime")]
    public required DateTime DueAtTime { get; set; }

    /// <summary>
    /// Unique ID for the coaching session.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Associated note for the coaching session. Returned when present.
    /// </summary>
    [JsonPropertyName("sessionNote")]
    public string? SessionNote { get; set; }

    /// <summary>
    /// Status for the coaching session.  Valid values: `unknown`, `upcoming`, `completed`, `deleted`
    /// </summary>
    [JsonPropertyName("sessionStatus")]
    public required CoachingSessionsResponseResponseBodySessionStatus SessionStatus { get; set; }

    /// <summary>
    /// Time coaching session was updated in UTC.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required DateTime UpdatedAtTime { get; set; }

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
