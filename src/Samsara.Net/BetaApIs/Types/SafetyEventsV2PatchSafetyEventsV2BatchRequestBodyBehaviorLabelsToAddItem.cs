using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(
    typeof(StringEnumSerializer<SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem>)
)]
[Serializable]
public readonly record struct SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem
    : IStringEnum
{
    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem Acceleration =
        new(Values.Acceleration);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem AggressiveDriving =
        new(Values.AggressiveDriving);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem BluetoothHeadset =
        new(Values.BluetoothHeadset);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem Braking =
        new(Values.Braking);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem ContextConstructionOrWorkZone =
        new(Values.ContextConstructionOrWorkZone);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem ContextSnowyOrIcy =
        new(Values.ContextSnowyOrIcy);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem ContextVulnerableRoadUser =
        new(Values.ContextVulnerableRoadUser);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem ContextWet =
        new(Values.ContextWet);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem Crash =
        new(Values.Crash);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem DefensiveDriving =
        new(Values.DefensiveDriving);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem DidNotYield =
        new(Values.DidNotYield);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem Drinking =
        new(Values.Drinking);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem Drowsy =
        new(Values.Drowsy);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem Eating =
        new(Values.Eating);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem EatingDrinking =
        new(Values.EatingDrinking);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem EdgeDistractedDriving =
        new(Values.EdgeDistractedDriving);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem EdgeRailroadCrossingViolation =
        new(Values.EdgeRailroadCrossingViolation);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem FollowingDistance =
        new(Values.FollowingDistance);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem FollowingDistanceModerate =
        new(Values.FollowingDistanceModerate);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem FollowingDistanceSevere =
        new(Values.FollowingDistanceSevere);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem ForwardCollisionWarning =
        new(Values.ForwardCollisionWarning);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem GenericDistraction =
        new(Values.GenericDistraction);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem GenericTailgating =
        new(Values.GenericTailgating);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem HarshImpact =
        new(Values.HarshImpact);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem HarshTurn =
        new(Values.HarshTurn);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem HeavySpeeding =
        new(Values.HeavySpeeding);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem HighSpeedSuddenDisconnect =
        new(Values.HighSpeedSuddenDisconnect);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem HosViolation =
        new(Values.HosViolation);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem Idling =
        new(Values.Idling);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem Invalid =
        new(Values.Invalid);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem LaneDeparture =
        new(Values.LaneDeparture);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem LateResponse =
        new(Values.LateResponse);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem LeftTurn =
        new(Values.LeftTurn);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem LightSpeeding =
        new(Values.LightSpeeding);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem MaxSpeed =
        new(Values.MaxSpeed);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem MobileUsage =
        new(Values.MobileUsage);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem ModerateSpeeding =
        new(Values.ModerateSpeeding);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem NearCollison =
        new(Values.NearCollison);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem NearPedestrianCollision =
        new(Values.NearPedestrianCollision);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem NoSeatbelt =
        new(Values.NoSeatbelt);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem ObstructedCamera =
        new(Values.ObstructedCamera);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem OperationalEvent =
        new(Values.OperationalEvent);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem OtherViolation =
        new(Values.OtherViolation);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem Passenger =
        new(Values.Passenger);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem PolicyViolationMask =
        new(Values.PolicyViolationMask);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem ProtectiveEquipment =
        new(Values.ProtectiveEquipment);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem ProximityWarning =
        new(Values.ProximityWarning);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem RanRedLight =
        new(Values.RanRedLight);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem RearCollisionWarning =
        new(Values.RearCollisionWarning);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem Reversing =
        new(Values.Reversing);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem RollingStop =
        new(Values.RollingStop);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem RolloverProtection =
        new(Values.RolloverProtection);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem SevereSpeeding =
        new(Values.SevereSpeeding);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem Smoking =
        new(Values.Smoking);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem Speeding =
        new(Values.Speeding);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem UTurn =
        new(Values.UTurn);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem UnsafeManeuver =
        new(Values.UnsafeManeuver);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem UnsafeParking =
        new(Values.UnsafeParking);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem VehicleInBlindSpotWarning =
        new(Values.VehicleInBlindSpotWarning);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem VulnerableRoadUserCollisionWarning =
        new(Values.VulnerableRoadUserCollisionWarning);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem YawControl =
        new(Values.YawControl);

    public SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem(string value)
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
    public static SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem FromCustom(
        string value
    )
    {
        return new SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem(value);
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
        SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem value
    ) => value.Value;

    public static explicit operator SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyBehaviorLabelsToAddItem(
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

        public const string HarshImpact = "HarshImpact";

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

        public const string OperationalEvent = "OperationalEvent";

        public const string OtherViolation = "OtherViolation";

        public const string Passenger = "Passenger";

        public const string PolicyViolationMask = "PolicyViolationMask";

        public const string ProtectiveEquipment = "ProtectiveEquipment";

        public const string ProximityWarning = "ProximityWarning";

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
