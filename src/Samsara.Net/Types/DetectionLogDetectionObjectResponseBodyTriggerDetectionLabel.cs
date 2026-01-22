using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel>)
)]
[Serializable]
public readonly record struct DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel
    : IStringEnum
{
    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel Acceleration =
        new(Values.Acceleration);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel Braking =
        new(Values.Braking);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel Crash = new(
        Values.Crash
    );

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel Drowsy =
        new(Values.Drowsy);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel EatingDrinking =
        new(Values.EatingDrinking);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel EdgeRailroadCrossingViolation =
        new(Values.EdgeRailroadCrossingViolation);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel FollowingDistance =
        new(Values.FollowingDistance);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel ForwardCollisionWarning =
        new(Values.ForwardCollisionWarning);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel GenericDistraction =
        new(Values.GenericDistraction);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel HarshTurn =
        new(Values.HarshTurn);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel HeavySpeeding =
        new(Values.HeavySpeeding);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel LaneDeparture =
        new(Values.LaneDeparture);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel LightSpeeding =
        new(Values.LightSpeeding);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel MaxSpeed =
        new(Values.MaxSpeed);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel MobileUsage =
        new(Values.MobileUsage);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel ModerateSpeeding =
        new(Values.ModerateSpeeding);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel NoSeatbelt =
        new(Values.NoSeatbelt);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel ObstructedCamera =
        new(Values.ObstructedCamera);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel Passenger =
        new(Values.Passenger);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel PolicyViolationMask =
        new(Values.PolicyViolationMask);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel RanRedLight =
        new(Values.RanRedLight);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel RearCollisionWarning =
        new(Values.RearCollisionWarning);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel RollingStop =
        new(Values.RollingStop);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel RolloverProtection =
        new(Values.RolloverProtection);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel SevereSpeeding =
        new(Values.SevereSpeeding);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel Smoking =
        new(Values.Smoking);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel UnsafeParking =
        new(Values.UnsafeParking);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel VehicleInBlindSpotWarning =
        new(Values.VehicleInBlindSpotWarning);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel VulnerableRoadUserCollisionWarning =
        new(Values.VulnerableRoadUserCollisionWarning);

    public static readonly DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel YawControl =
        new(Values.YawControl);

    public DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel(string value)
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
    public static DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel FromCustom(
        string value
    )
    {
        return new DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel(value);
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
        DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel value
    ) => value.Value;

    public static explicit operator DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel(
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

        public const string Drowsy = "drowsy";

        public const string EatingDrinking = "eatingDrinking";

        public const string EdgeRailroadCrossingViolation = "edgeRailroadCrossingViolation";

        public const string FollowingDistance = "followingDistance";

        public const string ForwardCollisionWarning = "forwardCollisionWarning";

        public const string GenericDistraction = "genericDistraction";

        public const string HarshTurn = "harshTurn";

        public const string HeavySpeeding = "heavySpeeding";

        public const string LaneDeparture = "laneDeparture";

        public const string LightSpeeding = "lightSpeeding";

        public const string MaxSpeed = "maxSpeed";

        public const string MobileUsage = "mobileUsage";

        public const string ModerateSpeeding = "moderateSpeeding";

        public const string NoSeatbelt = "noSeatbelt";

        public const string ObstructedCamera = "obstructedCamera";

        public const string Passenger = "passenger";

        public const string PolicyViolationMask = "policyViolationMask";

        public const string RanRedLight = "ranRedLight";

        public const string RearCollisionWarning = "rearCollisionWarning";

        public const string RollingStop = "rollingStop";

        public const string RolloverProtection = "rolloverProtection";

        public const string SevereSpeeding = "severeSpeeding";

        public const string Smoking = "smoking";

        public const string UnsafeParking = "unsafeParking";

        public const string VehicleInBlindSpotWarning = "vehicleInBlindSpotWarning";

        public const string VulnerableRoadUserCollisionWarning =
            "vulnerableRoadUserCollisionWarning";

        public const string YawControl = "yawControl";
    }
}
