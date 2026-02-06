using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<SafetyEventBehaviorLabelsResponseBodyType>))]
[Serializable]
public readonly record struct SafetyEventBehaviorLabelsResponseBodyType : IStringEnum
{
    public static readonly SafetyEventBehaviorLabelsResponseBodyType Acceleration = new(
        Values.Acceleration
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType Braking = new(Values.Braking);

    public static readonly SafetyEventBehaviorLabelsResponseBodyType Crash = new(Values.Crash);

    public static readonly SafetyEventBehaviorLabelsResponseBodyType DefensiveDriving = new(
        Values.DefensiveDriving
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType DidNotYield = new(
        Values.DidNotYield
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType Drinking = new(
        Values.Drinking
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType Drowsy = new(Values.Drowsy);

    public static readonly SafetyEventBehaviorLabelsResponseBodyType Eating = new(Values.Eating);

    public static readonly SafetyEventBehaviorLabelsResponseBodyType EatingDrinking = new(
        Values.EatingDrinking
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType EdgeDistractedDriving = new(
        Values.EdgeDistractedDriving
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType EdgeRailroadCrossingViolation =
        new(Values.EdgeRailroadCrossingViolation);

    public static readonly SafetyEventBehaviorLabelsResponseBodyType FollowingDistance = new(
        Values.FollowingDistance
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType FollowingDistanceModerate =
        new(Values.FollowingDistanceModerate);

    public static readonly SafetyEventBehaviorLabelsResponseBodyType FollowingDistanceSevere = new(
        Values.FollowingDistanceSevere
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType ForwardCollisionWarning = new(
        Values.ForwardCollisionWarning
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType GenericDistraction = new(
        Values.GenericDistraction
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType GenericTailgating = new(
        Values.GenericTailgating
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType HarshTurn = new(
        Values.HarshTurn
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType HighSpeedSuddenDisconnect =
        new(Values.HighSpeedSuddenDisconnect);

    public static readonly SafetyEventBehaviorLabelsResponseBodyType Invalid = new(Values.Invalid);

    public static readonly SafetyEventBehaviorLabelsResponseBodyType LaneDeparture = new(
        Values.LaneDeparture
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType LateResponse = new(
        Values.LateResponse
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType MobileUsage = new(
        Values.MobileUsage
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType NearCollison = new(
        Values.NearCollison
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType NoSeatbelt = new(
        Values.NoSeatbelt
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType ObstructedCamera = new(
        Values.ObstructedCamera
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType OperationalEvent = new(
        Values.OperationalEvent
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType Passenger = new(
        Values.Passenger
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType PolicyViolationMask = new(
        Values.PolicyViolationMask
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType ProtectiveEquipment = new(
        Values.ProtectiveEquipment
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType RanRedLight = new(
        Values.RanRedLight
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType RearCollisionWarning = new(
        Values.RearCollisionWarning
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType RollingStop = new(
        Values.RollingStop
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType RolloverProtection = new(
        Values.RolloverProtection
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType Smoking = new(Values.Smoking);

    public static readonly SafetyEventBehaviorLabelsResponseBodyType Speeding = new(
        Values.Speeding
    );

    public static readonly SafetyEventBehaviorLabelsResponseBodyType VehicleInBlindSpotWarning =
        new(Values.VehicleInBlindSpotWarning);

    public static readonly SafetyEventBehaviorLabelsResponseBodyType VulnerableRoadUserCollisionWarning =
        new(Values.VulnerableRoadUserCollisionWarning);

    public static readonly SafetyEventBehaviorLabelsResponseBodyType YawControl = new(
        Values.YawControl
    );

    public SafetyEventBehaviorLabelsResponseBodyType(string value)
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
    public static SafetyEventBehaviorLabelsResponseBodyType FromCustom(string value)
    {
        return new SafetyEventBehaviorLabelsResponseBodyType(value);
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
        SafetyEventBehaviorLabelsResponseBodyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SafetyEventBehaviorLabelsResponseBodyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SafetyEventBehaviorLabelsResponseBodyType value) =>
        value.Value;

    public static explicit operator SafetyEventBehaviorLabelsResponseBodyType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Acceleration = "Acceleration";

        public const string Braking = "Braking";

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

        public const string HighSpeedSuddenDisconnect = "HighSpeedSuddenDisconnect";

        public const string Invalid = "Invalid";

        public const string LaneDeparture = "LaneDeparture";

        public const string LateResponse = "LateResponse";

        public const string MobileUsage = "MobileUsage";

        public const string NearCollison = "NearCollison";

        public const string NoSeatbelt = "NoSeatbelt";

        public const string ObstructedCamera = "ObstructedCamera";

        public const string OperationalEvent = "OperationalEvent";

        public const string Passenger = "Passenger";

        public const string PolicyViolationMask = "PolicyViolationMask";

        public const string ProtectiveEquipment = "ProtectiveEquipment";

        public const string RanRedLight = "RanRedLight";

        public const string RearCollisionWarning = "RearCollisionWarning";

        public const string RollingStop = "RollingStop";

        public const string RolloverProtection = "RolloverProtection";

        public const string Smoking = "Smoking";

        public const string Speeding = "Speeding";

        public const string VehicleInBlindSpotWarning = "VehicleInBlindSpotWarning";

        public const string VulnerableRoadUserCollisionWarning =
            "VulnerableRoadUserCollisionWarning";

        public const string YawControl = "YawControl";
    }
}
