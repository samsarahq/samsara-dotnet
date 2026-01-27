using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<SafetyEventBehaviorLabelType>))]
[Serializable]
public readonly record struct SafetyEventBehaviorLabelType : IStringEnum
{
    public static readonly SafetyEventBehaviorLabelType GenericTailgating = new(
        Values.GenericTailgating
    );

    public static readonly SafetyEventBehaviorLabelType GenericDistraction = new(
        Values.GenericDistraction
    );

    public static readonly SafetyEventBehaviorLabelType DefensiveDriving = new(
        Values.DefensiveDriving
    );

    public static readonly SafetyEventBehaviorLabelType RollingStop = new(Values.RollingStop);

    public static readonly SafetyEventBehaviorLabelType NearCollison = new(Values.NearCollison);

    public static readonly SafetyEventBehaviorLabelType Speeding = new(Values.Speeding);

    public static readonly SafetyEventBehaviorLabelType ObstructedCamera = new(
        Values.ObstructedCamera
    );

    public static readonly SafetyEventBehaviorLabelType DidNotYield = new(Values.DidNotYield);

    public static readonly SafetyEventBehaviorLabelType NoSeatbelt = new(Values.NoSeatbelt);

    public static readonly SafetyEventBehaviorLabelType MobileUsage = new(Values.MobileUsage);

    public static readonly SafetyEventBehaviorLabelType Drowsy = new(Values.Drowsy);

    public static readonly SafetyEventBehaviorLabelType LaneDeparture = new(Values.LaneDeparture);

    public static readonly SafetyEventBehaviorLabelType FollowingDistanceSevere = new(
        Values.FollowingDistanceSevere
    );

    public static readonly SafetyEventBehaviorLabelType FollowingDistanceModerate = new(
        Values.FollowingDistanceModerate
    );

    public static readonly SafetyEventBehaviorLabelType LateResponse = new(Values.LateResponse);

    public static readonly SafetyEventBehaviorLabelType Acceleration = new(Values.Acceleration);

    public static readonly SafetyEventBehaviorLabelType Braking = new(Values.Braking);

    public static readonly SafetyEventBehaviorLabelType HarshTurn = new(Values.HarshTurn);

    public static readonly SafetyEventBehaviorLabelType Crash = new(Values.Crash);

    public static readonly SafetyEventBehaviorLabelType RolloverProtection = new(
        Values.RolloverProtection
    );

    public static readonly SafetyEventBehaviorLabelType YawControl = new(Values.YawControl);

    public static readonly SafetyEventBehaviorLabelType RanRedLight = new(Values.RanRedLight);

    public static readonly SafetyEventBehaviorLabelType ForwardCollisionWarning = new(
        Values.ForwardCollisionWarning
    );

    public static readonly SafetyEventBehaviorLabelType EatingDrinking = new(Values.EatingDrinking);

    public static readonly SafetyEventBehaviorLabelType Smoking = new(Values.Smoking);

    public static readonly SafetyEventBehaviorLabelType FollowingDistance = new(
        Values.FollowingDistance
    );

    public static readonly SafetyEventBehaviorLabelType EdgeDistractedDriving = new(
        Values.EdgeDistractedDriving
    );

    public SafetyEventBehaviorLabelType(string value)
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
    public static SafetyEventBehaviorLabelType FromCustom(string value)
    {
        return new SafetyEventBehaviorLabelType(value);
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

    public static bool operator ==(SafetyEventBehaviorLabelType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SafetyEventBehaviorLabelType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SafetyEventBehaviorLabelType value) => value.Value;

    public static explicit operator SafetyEventBehaviorLabelType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string GenericTailgating = "genericTailgating";

        public const string GenericDistraction = "genericDistraction";

        public const string DefensiveDriving = "defensiveDriving";

        public const string RollingStop = "rollingStop";

        public const string NearCollison = "nearCollison";

        public const string Speeding = "speeding";

        public const string ObstructedCamera = "obstructedCamera";

        public const string DidNotYield = "didNotYield";

        public const string NoSeatbelt = "noSeatbelt";

        public const string MobileUsage = "mobileUsage";

        public const string Drowsy = "drowsy";

        public const string LaneDeparture = "laneDeparture";

        public const string FollowingDistanceSevere = "followingDistanceSevere";

        public const string FollowingDistanceModerate = "followingDistanceModerate";

        public const string LateResponse = "lateResponse";

        public const string Acceleration = "acceleration";

        public const string Braking = "braking";

        public const string HarshTurn = "harshTurn";

        public const string Crash = "crash";

        public const string RolloverProtection = "rolloverProtection";

        public const string YawControl = "yawControl";

        public const string RanRedLight = "ranRedLight";

        public const string ForwardCollisionWarning = "forwardCollisionWarning";

        public const string EatingDrinking = "eatingDrinking";

        public const string Smoking = "smoking";

        public const string FollowingDistance = "followingDistance";

        public const string EdgeDistractedDriving = "edgeDistractedDriving";
    }
}
