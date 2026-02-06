using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The most up-to-date behavior labels associated with the safety event. These labels can be updated by Safety Admins.
/// </summary>
[Serializable]
public record SafetyEventV2BehaviorLabelsResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The label associated with the safety event. Labels can be updated by Safety Admins, if a label is removed from a safety event it will be removed from this list.  Valid values: `Acceleration`, `AggressiveDriving`, `BluetoothHeadset`, `Braking`, `ContextConstructionOrWorkZone`, `ContextSnowyOrIcy`, `ContextVulnerableRoadUser`, `ContextWet`, `Crash`, `DefensiveDriving`, `DidNotYield`, `Drinking`, `Drowsy`, `Eating`, `EatingDrinking`, `EdgeDistractedDriving`, `EdgeRailroadCrossingViolation`, `FollowingDistance`, `FollowingDistanceModerate`, `FollowingDistanceSevere`, `ForwardCollisionWarning`, `GenericDistraction`, `GenericTailgating`, `HarshTurn`, `HeavySpeeding`, `HighSpeedSuddenDisconnect`, `HosViolation`, `Idling`, `Invalid`, `LaneDeparture`, `LateResponse`, `LeftTurn`, `LightSpeeding`, `MaxSpeed`, `MobileUsage`, `ModerateSpeeding`, `NearCollison`, `NearPedestrianCollision`, `NoSeatbelt`, `ObstructedCamera`, `OperationalEvent`, `OtherViolation`, `Passenger`, `PolicyViolationMask`, `ProtectiveEquipment`, `RanRedLight`, `RearCollisionWarning`, `Reversing`, `RollingStop`, `RolloverProtection`, `SevereSpeeding`, `Smoking`, `Speeding`, `UTurn`, `UnsafeManeuver`, `UnsafeParking`, `VehicleInBlindSpotWarning`, `VulnerableRoadUserCollisionWarning`, `YawControl`
    /// </summary>
    [JsonPropertyName("label")]
    public SafetyEventV2BehaviorLabelsResponseBodyLabel? Label { get; set; }

    /// <summary>
    /// The source of the label associated with the safety event.  Valid values: `automated`, `userGenerated`
    /// </summary>
    [JsonPropertyName("source")]
    public SafetyEventV2BehaviorLabelsResponseBodySource? Source { get; set; }

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
