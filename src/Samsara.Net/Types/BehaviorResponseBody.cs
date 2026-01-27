using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Object reference for the behavior within the session.
/// </summary>
[Serializable]
public record BehaviorResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Coachable behavior type for the behavior in the coaching session.  Valid values: `acceleration`, `braking`, `cameraObstruction`, `crash`, `defensiveDriving`, `didNotYield`, `drinkPolicy`, `drowsy`, `eatingDrinking`, `event`, `falsePositive`, `foodPolicy`, `forwardCollisionWarning`, `genericDistraction`, `harshTurn`, `hosViolation`, `idling`, `laneDeparture`, `lateResponse`, `maskPolicy`, `maxSpeed`, `mobileUsage`, `nearCollison`, `noSeatbelt`, `obstructedCamera`, `outwardObstruction`, `passengerPolicy`, `ranRedLight`, `rollingRailroadCrossing`, `rollingStop`, `rollingStop`, `rollover`, `rolloverProtection`, `rolloverProtectionBrakeControlActivated`, `rolloverProtectionEngineControlActivated`, `severeSpeeding`, `smoking`, `speeding`, `tailgating`, `unknown`, `yawControl`, `yawControlBrakeControlActivated`, `yawControlEngineControlActivated`
    /// </summary>
    [JsonPropertyName("coachableBehaviorType")]
    public required BehaviorResponseBodyCoachableBehaviorType CoachableBehaviorType { get; set; }

    /// <summary>
    /// Object references for the coachableEvents within the behavior. Returned when includeCoachableEvents is 'true'. Capped at 100 coachable events per Coaching session. For sessions where coachable events exceed 100, please visit the Samsara dashboard to address this coaching session. Corresponds to the following unique identifiers: Non-Speeding Safety events - unique Samsara ID of the safety event as 'vehicleId - eventMS'. Speeding events - unique UUID of the event. Day of HOS Violations - unique Samsara ID of the day of violations as '{driverId},{date}'. Idling events - unique UUID of the event.
    /// </summary>
    [JsonPropertyName("coachableEvents")]
    public IEnumerable<CoachableEventResponseBody>? CoachableEvents { get; set; }

    /// <summary>
    /// Unique ID for the coaching behavior.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Time of last coached date for the same behavior label.
    /// </summary>
    [JsonPropertyName("lastCoachedTime")]
    public required DateTime LastCoachedTime { get; set; }

    /// <summary>
    /// Associated note for the coaching behavior. Returned when present.
    /// </summary>
    [JsonPropertyName("note")]
    public string? Note { get; set; }

    /// <summary>
    /// Time of coaching behavior update in UTC.
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
