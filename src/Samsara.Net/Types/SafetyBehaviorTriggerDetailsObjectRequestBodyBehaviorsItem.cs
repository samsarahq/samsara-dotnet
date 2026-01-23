using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem>)
)]
[Serializable]
public readonly record struct SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem
    : IStringEnum
{
    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem Acceleration =
        new(Values.Acceleration);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem AggressiveDriving =
        new(Values.AggressiveDriving);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem BluetoothHeadset =
        new(Values.BluetoothHeadset);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem Braking = new(
        Values.Braking
    );

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem ContextConstructionOrWorkZone =
        new(Values.ContextConstructionOrWorkZone);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem ContextSnowyOrIcy =
        new(Values.ContextSnowyOrIcy);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem ContextVulnerableRoadUser =
        new(Values.ContextVulnerableRoadUser);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem ContextWet =
        new(Values.ContextWet);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem Crash = new(
        Values.Crash
    );

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem CustomerCustomEvent1 =
        new(Values.CustomerCustomEvent1);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem CustomerCustomEvent10 =
        new(Values.CustomerCustomEvent10);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem CustomerCustomEvent2 =
        new(Values.CustomerCustomEvent2);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem CustomerCustomEvent3 =
        new(Values.CustomerCustomEvent3);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem CustomerCustomEvent4 =
        new(Values.CustomerCustomEvent4);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem CustomerCustomEvent5 =
        new(Values.CustomerCustomEvent5);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem CustomerCustomEvent6 =
        new(Values.CustomerCustomEvent6);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem CustomerCustomEvent7 =
        new(Values.CustomerCustomEvent7);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem CustomerCustomEvent8 =
        new(Values.CustomerCustomEvent8);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem CustomerCustomEvent9 =
        new(Values.CustomerCustomEvent9);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem DefensiveDriving =
        new(Values.DefensiveDriving);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem DidNotYield =
        new(Values.DidNotYield);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem Drinking =
        new(Values.Drinking);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem Drowsy = new(
        Values.Drowsy
    );

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem Eating = new(
        Values.Eating
    );

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem EatingDrinking =
        new(Values.EatingDrinking);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem EdgeDistractedDriving =
        new(Values.EdgeDistractedDriving);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem EdgeRailroadCrossingViolation =
        new(Values.EdgeRailroadCrossingViolation);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem FollowingDistance =
        new(Values.FollowingDistance);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem FollowingDistanceModerate =
        new(Values.FollowingDistanceModerate);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem FollowingDistanceSevere =
        new(Values.FollowingDistanceSevere);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem ForwardCollisionWarning =
        new(Values.ForwardCollisionWarning);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem GenericDistraction =
        new(Values.GenericDistraction);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem GenericTailgating =
        new(Values.GenericTailgating);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem HarshTurn =
        new(Values.HarshTurn);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem HeavySpeeding =
        new(Values.HeavySpeeding);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem HighSpeedSuddenDisconnect =
        new(Values.HighSpeedSuddenDisconnect);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem HosViolation =
        new(Values.HosViolation);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem Idling = new(
        Values.Idling
    );

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem Invalid = new(
        Values.Invalid
    );

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem LaneDeparture =
        new(Values.LaneDeparture);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem LateResponse =
        new(Values.LateResponse);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem LeftTurn =
        new(Values.LeftTurn);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem LightSpeeding =
        new(Values.LightSpeeding);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem MaxSpeed =
        new(Values.MaxSpeed);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem MobileUsage =
        new(Values.MobileUsage);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem ModerateSpeeding =
        new(Values.ModerateSpeeding);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem NearCollison =
        new(Values.NearCollison);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem NearPedestrianCollision =
        new(Values.NearPedestrianCollision);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem NoSeatbelt =
        new(Values.NoSeatbelt);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem ObstructedCamera =
        new(Values.ObstructedCamera);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem OtherViolation =
        new(Values.OtherViolation);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem Passenger =
        new(Values.Passenger);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem PolicyViolationMask =
        new(Values.PolicyViolationMask);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem ProtectiveEquipment =
        new(Values.ProtectiveEquipment);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem RanRedLight =
        new(Values.RanRedLight);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem Reversing =
        new(Values.Reversing);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem RollingStop =
        new(Values.RollingStop);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem RolloverProtection =
        new(Values.RolloverProtection);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem SamsaraCustomEvent1 =
        new(Values.SamsaraCustomEvent1);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem SamsaraCustomEvent10 =
        new(Values.SamsaraCustomEvent10);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem SamsaraCustomEvent2 =
        new(Values.SamsaraCustomEvent2);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem SamsaraCustomEvent3 =
        new(Values.SamsaraCustomEvent3);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem SamsaraCustomEvent4 =
        new(Values.SamsaraCustomEvent4);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem SamsaraCustomEvent5 =
        new(Values.SamsaraCustomEvent5);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem SamsaraCustomEvent6 =
        new(Values.SamsaraCustomEvent6);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem SamsaraCustomEvent7 =
        new(Values.SamsaraCustomEvent7);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem SamsaraCustomEvent8 =
        new(Values.SamsaraCustomEvent8);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem SamsaraCustomEvent9 =
        new(Values.SamsaraCustomEvent9);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem SevereSpeeding =
        new(Values.SevereSpeeding);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem Smoking = new(
        Values.Smoking
    );

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem Speeding =
        new(Values.Speeding);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem UTurn = new(
        Values.UTurn
    );

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem UnsafeManeuver =
        new(Values.UnsafeManeuver);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem UnsafeParking =
        new(Values.UnsafeParking);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem VehicleInBlindSpotWarning =
        new(Values.VehicleInBlindSpotWarning);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem VulnerableRoadUserCollisionWarning =
        new(Values.VulnerableRoadUserCollisionWarning);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem YawControl =
        new(Values.YawControl);

    public SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem(string value)
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
    public static SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem FromCustom(
        string value
    )
    {
        return new SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem(value);
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
        SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem value
    ) => value.Value;

    public static explicit operator SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem(
        string value
    ) => new(value);

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

        public const string CustomerCustomEvent1 = "CustomerCustomEvent1";

        public const string CustomerCustomEvent10 = "CustomerCustomEvent10";

        public const string CustomerCustomEvent2 = "CustomerCustomEvent2";

        public const string CustomerCustomEvent3 = "CustomerCustomEvent3";

        public const string CustomerCustomEvent4 = "CustomerCustomEvent4";

        public const string CustomerCustomEvent5 = "CustomerCustomEvent5";

        public const string CustomerCustomEvent6 = "CustomerCustomEvent6";

        public const string CustomerCustomEvent7 = "CustomerCustomEvent7";

        public const string CustomerCustomEvent8 = "CustomerCustomEvent8";

        public const string CustomerCustomEvent9 = "CustomerCustomEvent9";

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

        public const string Reversing = "Reversing";

        public const string RollingStop = "RollingStop";

        public const string RolloverProtection = "RolloverProtection";

        public const string SamsaraCustomEvent1 = "SamsaraCustomEvent1";

        public const string SamsaraCustomEvent10 = "SamsaraCustomEvent10";

        public const string SamsaraCustomEvent2 = "SamsaraCustomEvent2";

        public const string SamsaraCustomEvent3 = "SamsaraCustomEvent3";

        public const string SamsaraCustomEvent4 = "SamsaraCustomEvent4";

        public const string SamsaraCustomEvent5 = "SamsaraCustomEvent5";

        public const string SamsaraCustomEvent6 = "SamsaraCustomEvent6";

        public const string SamsaraCustomEvent7 = "SamsaraCustomEvent7";

        public const string SamsaraCustomEvent8 = "SamsaraCustomEvent8";

        public const string SamsaraCustomEvent9 = "SamsaraCustomEvent9";

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
