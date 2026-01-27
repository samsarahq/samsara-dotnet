using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<BehaviorResponseBodyCoachableBehaviorType>))]
[Serializable]
public readonly record struct BehaviorResponseBodyCoachableBehaviorType : IStringEnum
{
    public static readonly BehaviorResponseBodyCoachableBehaviorType Acceleration = new(
        Values.Acceleration
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType Braking = new(Values.Braking);

    public static readonly BehaviorResponseBodyCoachableBehaviorType CameraObstruction = new(
        Values.CameraObstruction
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType Crash = new(Values.Crash);

    public static readonly BehaviorResponseBodyCoachableBehaviorType DefensiveDriving = new(
        Values.DefensiveDriving
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType DidNotYield = new(
        Values.DidNotYield
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType DrinkPolicy = new(
        Values.DrinkPolicy
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType Drowsy = new(Values.Drowsy);

    public static readonly BehaviorResponseBodyCoachableBehaviorType EatingDrinking = new(
        Values.EatingDrinking
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType Event = new(Values.Event);

    public static readonly BehaviorResponseBodyCoachableBehaviorType FalsePositive = new(
        Values.FalsePositive
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType FoodPolicy = new(
        Values.FoodPolicy
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType ForwardCollisionWarning = new(
        Values.ForwardCollisionWarning
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType GenericDistraction = new(
        Values.GenericDistraction
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType HarshTurn = new(
        Values.HarshTurn
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType HosViolation = new(
        Values.HosViolation
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType Idling = new(Values.Idling);

    public static readonly BehaviorResponseBodyCoachableBehaviorType LaneDeparture = new(
        Values.LaneDeparture
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType LateResponse = new(
        Values.LateResponse
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType MaskPolicy = new(
        Values.MaskPolicy
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType MaxSpeed = new(
        Values.MaxSpeed
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType MobileUsage = new(
        Values.MobileUsage
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType NearCollison = new(
        Values.NearCollison
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType NoSeatbelt = new(
        Values.NoSeatbelt
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType ObstructedCamera = new(
        Values.ObstructedCamera
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType OutwardObstruction = new(
        Values.OutwardObstruction
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType PassengerPolicy = new(
        Values.PassengerPolicy
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType RanRedLight = new(
        Values.RanRedLight
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType RollingRailroadCrossing = new(
        Values.RollingRailroadCrossing
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType RollingStop = new(
        Values.RollingStop
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType Rollover = new(
        Values.Rollover
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType RolloverProtection = new(
        Values.RolloverProtection
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType RolloverProtectionBrakeControlActivated =
        new(Values.RolloverProtectionBrakeControlActivated);

    public static readonly BehaviorResponseBodyCoachableBehaviorType RolloverProtectionEngineControlActivated =
        new(Values.RolloverProtectionEngineControlActivated);

    public static readonly BehaviorResponseBodyCoachableBehaviorType SevereSpeeding = new(
        Values.SevereSpeeding
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType Smoking = new(Values.Smoking);

    public static readonly BehaviorResponseBodyCoachableBehaviorType Speeding = new(
        Values.Speeding
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType Tailgating = new(
        Values.Tailgating
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType Unknown = new(Values.Unknown);

    public static readonly BehaviorResponseBodyCoachableBehaviorType YawControl = new(
        Values.YawControl
    );

    public static readonly BehaviorResponseBodyCoachableBehaviorType YawControlBrakeControlActivated =
        new(Values.YawControlBrakeControlActivated);

    public static readonly BehaviorResponseBodyCoachableBehaviorType YawControlEngineControlActivated =
        new(Values.YawControlEngineControlActivated);

    public BehaviorResponseBodyCoachableBehaviorType(string value)
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
    public static BehaviorResponseBodyCoachableBehaviorType FromCustom(string value)
    {
        return new BehaviorResponseBodyCoachableBehaviorType(value);
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
        BehaviorResponseBodyCoachableBehaviorType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        BehaviorResponseBodyCoachableBehaviorType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(BehaviorResponseBodyCoachableBehaviorType value) =>
        value.Value;

    public static explicit operator BehaviorResponseBodyCoachableBehaviorType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Acceleration = "acceleration";

        public const string Braking = "braking";

        public const string CameraObstruction = "cameraObstruction";

        public const string Crash = "crash";

        public const string DefensiveDriving = "defensiveDriving";

        public const string DidNotYield = "didNotYield";

        public const string DrinkPolicy = "drinkPolicy";

        public const string Drowsy = "drowsy";

        public const string EatingDrinking = "eatingDrinking";

        public const string Event = "event";

        public const string FalsePositive = "falsePositive";

        public const string FoodPolicy = "foodPolicy";

        public const string ForwardCollisionWarning = "forwardCollisionWarning";

        public const string GenericDistraction = "genericDistraction";

        public const string HarshTurn = "harshTurn";

        public const string HosViolation = "hosViolation";

        public const string Idling = "idling";

        public const string LaneDeparture = "laneDeparture";

        public const string LateResponse = "lateResponse";

        public const string MaskPolicy = "maskPolicy";

        public const string MaxSpeed = "maxSpeed";

        public const string MobileUsage = "mobileUsage";

        public const string NearCollison = "nearCollison";

        public const string NoSeatbelt = "noSeatbelt";

        public const string ObstructedCamera = "obstructedCamera";

        public const string OutwardObstruction = "outwardObstruction";

        public const string PassengerPolicy = "passengerPolicy";

        public const string RanRedLight = "ranRedLight";

        public const string RollingRailroadCrossing = "rollingRailroadCrossing";

        public const string RollingStop = "rollingStop";

        public const string Rollover = "rollover";

        public const string RolloverProtection = "rolloverProtection";

        public const string RolloverProtectionBrakeControlActivated =
            "rolloverProtectionBrakeControlActivated";

        public const string RolloverProtectionEngineControlActivated =
            "rolloverProtectionEngineControlActivated";

        public const string SevereSpeeding = "severeSpeeding";

        public const string Smoking = "smoking";

        public const string Speeding = "speeding";

        public const string Tailgating = "tailgating";

        public const string Unknown = "unknown";

        public const string YawControl = "yawControl";

        public const string YawControlBrakeControlActivated = "yawControlBrakeControlActivated";

        public const string YawControlEngineControlActivated = "yawControlEngineControlActivated";
    }
}
