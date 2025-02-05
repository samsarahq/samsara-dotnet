using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record BehaviorResponseBody
{
    /// <summary>
    /// Coachable behavior type for the behavior in the coaching session.  Valid values: `acceleration`, `braking`, `cameraObstruction`, `crash`, `defensiveDriving`, `didNotYield`, `drinkPolicy`, `drowsy`, `eatingDrinking`, `event`, `falsePositive`, `foodPolicy`, `forwardCollisionWarning`, `genericDistraction`, `harshTurn`, `laneDeparture`, `lateResponse`, `maskPolicy`, `maxSpeed`, `mobileUsage`, `nearCollison`, `noSeatbelt`, `obstructedCamera`, `outwardObstruction`, `passengerPolicy`, `ranRedLight`, `rollingRailroadCrossing`, `rollingStop`, `rollingStop`, `rollover`, `rolloverProtection`, `rolloverProtectionBrakeControlActivated`, `rolloverProtectionEngineControlActivated`, `severeSpeeding`, `smoking`, `speeding`, `tailgating`, `unknown`, `yawControl`, `yawControlBrakeControlActivated`, `yawControlEngineControlActivated`
    /// </summary>
    [JsonPropertyName("coachableBehaviorType")]
    public required BehaviorResponseBodyCoachableBehaviorType CoachableBehaviorType { get; set; }

    /// <summary>
    /// Object references for the coachableEvents within the behavior. For non Speeding events, corresponds to the unique Samsara ID of the safety event as “vehicleId - eventMS”, for Speeding events corresponds to the unique UUID of the event. Returned when includeCoachableEvents is 'true'. Capped at 100 coachable events per Coaching session. For sessions where coachable events exceed 100, please visit the Samsara dashboard to address this coaching session.
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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
