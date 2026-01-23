using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<SafetyScoreBehaviorObjectResponseBodyBehaviorType>))]
[Serializable]
public readonly record struct SafetyScoreBehaviorObjectResponseBodyBehaviorType : IStringEnum
{
    public static readonly SafetyScoreBehaviorObjectResponseBodyBehaviorType Acceleration = new(
        Values.Acceleration
    );

    public static readonly SafetyScoreBehaviorObjectResponseBodyBehaviorType Braking = new(
        Values.Braking
    );

    public static readonly SafetyScoreBehaviorObjectResponseBodyBehaviorType Crash = new(
        Values.Crash
    );

    public static readonly SafetyScoreBehaviorObjectResponseBodyBehaviorType DefensiveDriving = new(
        Values.DefensiveDriving
    );

    public static readonly SafetyScoreBehaviorObjectResponseBodyBehaviorType DidNotYield = new(
        Values.DidNotYield
    );

    public static readonly SafetyScoreBehaviorObjectResponseBodyBehaviorType DistractedDrivingAutomatic =
        new(Values.DistractedDrivingAutomatic);

    public static readonly SafetyScoreBehaviorObjectResponseBodyBehaviorType DistractedDrivingManual =
        new(Values.DistractedDrivingManual);

    public static readonly SafetyScoreBehaviorObjectResponseBodyBehaviorType Drowsy = new(
        Values.Drowsy
    );

    public static readonly SafetyScoreBehaviorObjectResponseBodyBehaviorType EatingDrinking = new(
        Values.EatingDrinking
    );

    public static readonly SafetyScoreBehaviorObjectResponseBodyBehaviorType FollowingDistance =
        new(Values.FollowingDistance);

    public static readonly SafetyScoreBehaviorObjectResponseBodyBehaviorType FollowingDistanceModerate =
        new(Values.FollowingDistanceModerate);

    public static readonly SafetyScoreBehaviorObjectResponseBodyBehaviorType FollowingDistanceSevere =
        new(Values.FollowingDistanceSevere);

    public static readonly SafetyScoreBehaviorObjectResponseBodyBehaviorType ForwardCollisionWarning =
        new(Values.ForwardCollisionWarning);

    public static readonly SafetyScoreBehaviorObjectResponseBodyBehaviorType HarshTurn = new(
        Values.HarshTurn
    );

    public static readonly SafetyScoreBehaviorObjectResponseBodyBehaviorType LaneDeparture = new(
        Values.LaneDeparture
    );

    public static readonly SafetyScoreBehaviorObjectResponseBodyBehaviorType LateResponse = new(
        Values.LateResponse
    );

    public static readonly SafetyScoreBehaviorObjectResponseBodyBehaviorType MobileUsage = new(
        Values.MobileUsage
    );

    public static readonly SafetyScoreBehaviorObjectResponseBodyBehaviorType NearCollision = new(
        Values.NearCollision
    );

    public static readonly SafetyScoreBehaviorObjectResponseBodyBehaviorType NoSeatbelt = new(
        Values.NoSeatbelt
    );

    public static readonly SafetyScoreBehaviorObjectResponseBodyBehaviorType ObstructedCamera = new(
        Values.ObstructedCamera
    );

    public static readonly SafetyScoreBehaviorObjectResponseBodyBehaviorType RanRedLight = new(
        Values.RanRedLight
    );

    public static readonly SafetyScoreBehaviorObjectResponseBodyBehaviorType RollingStop = new(
        Values.RollingStop
    );

    public static readonly SafetyScoreBehaviorObjectResponseBodyBehaviorType Smoking = new(
        Values.Smoking
    );

    public static readonly SafetyScoreBehaviorObjectResponseBodyBehaviorType SpeedingManual = new(
        Values.SpeedingManual
    );

    public static readonly SafetyScoreBehaviorObjectResponseBodyBehaviorType Unknown = new(
        Values.Unknown
    );

    public SafetyScoreBehaviorObjectResponseBodyBehaviorType(string value)
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
    public static SafetyScoreBehaviorObjectResponseBodyBehaviorType FromCustom(string value)
    {
        return new SafetyScoreBehaviorObjectResponseBodyBehaviorType(value);
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
        SafetyScoreBehaviorObjectResponseBodyBehaviorType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SafetyScoreBehaviorObjectResponseBodyBehaviorType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SafetyScoreBehaviorObjectResponseBodyBehaviorType value
    ) => value.Value;

    public static explicit operator SafetyScoreBehaviorObjectResponseBodyBehaviorType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Acceleration = "acceleration";

        public const string Braking = "braking";

        public const string Crash = "crash";

        public const string DefensiveDriving = "defensiveDriving";

        public const string DidNotYield = "didNotYield";

        public const string DistractedDrivingAutomatic = "distractedDrivingAutomatic";

        public const string DistractedDrivingManual = "distractedDrivingManual";

        public const string Drowsy = "drowsy";

        public const string EatingDrinking = "eatingDrinking";

        public const string FollowingDistance = "followingDistance";

        public const string FollowingDistanceModerate = "followingDistanceModerate";

        public const string FollowingDistanceSevere = "followingDistanceSevere";

        public const string ForwardCollisionWarning = "forwardCollisionWarning";

        public const string HarshTurn = "harshTurn";

        public const string LaneDeparture = "laneDeparture";

        public const string LateResponse = "lateResponse";

        public const string MobileUsage = "mobileUsage";

        public const string NearCollision = "nearCollision";

        public const string NoSeatbelt = "noSeatbelt";

        public const string ObstructedCamera = "obstructedCamera";

        public const string RanRedLight = "ranRedLight";

        public const string RollingStop = "rollingStop";

        public const string Smoking = "smoking";

        public const string SpeedingManual = "speedingManual";

        public const string Unknown = "unknown";
    }
}
