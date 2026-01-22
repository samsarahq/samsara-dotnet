using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<SafetyEventV2BehaviorLabelsResponseBodyLabel>))]
[Serializable]
public readonly record struct SafetyEventV2BehaviorLabelsResponseBodyLabel : IStringEnum
{
    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel Acceleration = new(
        Values.Acceleration
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel AggressiveDriving = new(
        Values.AggressiveDriving
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel BluetoothHeadset = new(
        Values.BluetoothHeadset
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel Braking = new(
        Values.Braking
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel ContextConstructionOrWorkZone =
        new(Values.ContextConstructionOrWorkZone);

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel ContextSnowyOrIcy = new(
        Values.ContextSnowyOrIcy
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel ContextVulnerableRoadUser =
        new(Values.ContextVulnerableRoadUser);

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel ContextWet = new(
        Values.ContextWet
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel Crash = new(Values.Crash);

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel DefensiveDriving = new(
        Values.DefensiveDriving
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel DidNotYield = new(
        Values.DidNotYield
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel Drinking = new(
        Values.Drinking
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel Drowsy = new(Values.Drowsy);

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel Eating = new(Values.Eating);

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel EatingDrinking = new(
        Values.EatingDrinking
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel EdgeDistractedDriving = new(
        Values.EdgeDistractedDriving
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel EdgeRailroadCrossingViolation =
        new(Values.EdgeRailroadCrossingViolation);

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel FollowingDistance = new(
        Values.FollowingDistance
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel FollowingDistanceModerate =
        new(Values.FollowingDistanceModerate);

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel FollowingDistanceSevere =
        new(Values.FollowingDistanceSevere);

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel ForwardCollisionWarning =
        new(Values.ForwardCollisionWarning);

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel GenericDistraction = new(
        Values.GenericDistraction
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel GenericTailgating = new(
        Values.GenericTailgating
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel HarshTurn = new(
        Values.HarshTurn
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel HeavySpeeding = new(
        Values.HeavySpeeding
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel HighSpeedSuddenDisconnect =
        new(Values.HighSpeedSuddenDisconnect);

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel HosViolation = new(
        Values.HosViolation
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel Idling = new(Values.Idling);

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel Invalid = new(
        Values.Invalid
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel LaneDeparture = new(
        Values.LaneDeparture
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel LateResponse = new(
        Values.LateResponse
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel LeftTurn = new(
        Values.LeftTurn
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel LightSpeeding = new(
        Values.LightSpeeding
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel MaxSpeed = new(
        Values.MaxSpeed
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel MobileUsage = new(
        Values.MobileUsage
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel ModerateSpeeding = new(
        Values.ModerateSpeeding
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel NearCollison = new(
        Values.NearCollison
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel NearPedestrianCollision =
        new(Values.NearPedestrianCollision);

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel NoSeatbelt = new(
        Values.NoSeatbelt
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel ObstructedCamera = new(
        Values.ObstructedCamera
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel OtherViolation = new(
        Values.OtherViolation
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel Passenger = new(
        Values.Passenger
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel PolicyViolationMask = new(
        Values.PolicyViolationMask
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel ProtectiveEquipment = new(
        Values.ProtectiveEquipment
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel RanRedLight = new(
        Values.RanRedLight
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel RearCollisionWarning = new(
        Values.RearCollisionWarning
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel Reversing = new(
        Values.Reversing
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel RollingStop = new(
        Values.RollingStop
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel RolloverProtection = new(
        Values.RolloverProtection
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel SevereSpeeding = new(
        Values.SevereSpeeding
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel Smoking = new(
        Values.Smoking
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel Speeding = new(
        Values.Speeding
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel UTurn = new(Values.UTurn);

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel UnsafeManeuver = new(
        Values.UnsafeManeuver
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel UnsafeParking = new(
        Values.UnsafeParking
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel VehicleInBlindSpotWarning =
        new(Values.VehicleInBlindSpotWarning);

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel VulnerableRoadUserCollisionWarning =
        new(Values.VulnerableRoadUserCollisionWarning);

    public static readonly SafetyEventV2BehaviorLabelsResponseBodyLabel YawControl = new(
        Values.YawControl
    );

    public SafetyEventV2BehaviorLabelsResponseBodyLabel(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static SafetyEventV2BehaviorLabelsResponseBodyLabel FromCustom(string value)
    {
        return new SafetyEventV2BehaviorLabelsResponseBodyLabel(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(
        SafetyEventV2BehaviorLabelsResponseBodyLabel value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SafetyEventV2BehaviorLabelsResponseBodyLabel value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SafetyEventV2BehaviorLabelsResponseBodyLabel value) =>
        value.Value;

    public static explicit operator SafetyEventV2BehaviorLabelsResponseBodyLabel(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Acceleration = "Acceleration";

        public const string AggressiveDriving = "AggressiveDriving";

        public const string BluetoothHeadset = "BluetoothHeadset";

        public const string Braking = "Braking";

        public const string ContextConstructionOrWorkZone = "ContextConstructionOrWorkZone";

        public const string ContextSnowyOrIcy = "ContextSnowyOrIcy";

        public const string ContextVulnerableRoadUser = "ContextVulnerableRoadUser";

        public const string ContextWet = "ContextWet";

        public const string Crash = "Crash";

        public const string DefensiveDriving = "DefensiveDriving";

        public const string DidNotYield = "DidNotYield";

        public const string Drinking = "Drinking";

        public const string Drowsy = "Drowsy";

        public const string Eating = "Eating";

        public const string EatingDrinking = "EatingDrinking";

        public const string EdgeDistractedDriving = "EdgeDistractedDriving";

        public const string EdgeRailroadCrossingViolation = "EdgeRailroadCrossingViolation";

        public const string FollowingDistance = "FollowingDistance";

        public const string FollowingDistanceModerate = "FollowingDistanceModerate";

        public const string FollowingDistanceSevere = "FollowingDistanceSevere";

        public const string ForwardCollisionWarning = "ForwardCollisionWarning";

        public const string GenericDistraction = "GenericDistraction";

        public const string GenericTailgating = "GenericTailgating";

        public const string HarshTurn = "HarshTurn";

        public const string HeavySpeeding = "HeavySpeeding";

        public const string HighSpeedSuddenDisconnect = "HighSpeedSuddenDisconnect";

        public const string HosViolation = "HosViolation";

        public const string Idling = "Idling";

        public const string Invalid = "Invalid";

        public const string LaneDeparture = "LaneDeparture";

        public const string LateResponse = "LateResponse";

        public const string LeftTurn = "LeftTurn";

        public const string LightSpeeding = "LightSpeeding";

        public const string MaxSpeed = "MaxSpeed";

        public const string MobileUsage = "MobileUsage";

        public const string ModerateSpeeding = "ModerateSpeeding";

        public const string NearCollison = "NearCollison";

        public const string NearPedestrianCollision = "NearPedestrianCollision";

        public const string NoSeatbelt = "NoSeatbelt";

        public const string ObstructedCamera = "ObstructedCamera";

        public const string OtherViolation = "OtherViolation";

        public const string Passenger = "Passenger";

        public const string PolicyViolationMask = "PolicyViolationMask";

        public const string ProtectiveEquipment = "ProtectiveEquipment";

        public const string RanRedLight = "RanRedLight";

        public const string RearCollisionWarning = "RearCollisionWarning";

        public const string Reversing = "Reversing";

        public const string RollingStop = "RollingStop";

        public const string RolloverProtection = "RolloverProtection";

        public const string SevereSpeeding = "SevereSpeeding";

        public const string Smoking = "Smoking";

        public const string Speeding = "Speeding";

        public const string UTurn = "UTurn";

        public const string UnsafeManeuver = "UnsafeManeuver";

        public const string UnsafeParking = "UnsafeParking";

        public const string VehicleInBlindSpotWarning = "VehicleInBlindSpotWarning";

        public const string VulnerableRoadUserCollisionWarning =
            "VulnerableRoadUserCollisionWarning";

        public const string YawControl = "YawControl";
    }
}
