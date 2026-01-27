using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<HarshEventTriggerDetailsObjectRequestBodyTypesItem>))]
[Serializable]
public readonly record struct HarshEventTriggerDetailsObjectRequestBodyTypesItem : IStringEnum
{
    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaAccel = new(
        Values.HaAccel
    );

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaBraking = new(
        Values.HaBraking
    );

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaCameraMisaligned =
        new(Values.HaCameraMisaligned);

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaCrash = new(
        Values.HaCrash
    );

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaDistractedDriving =
        new(Values.HaDistractedDriving);

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaDistractedDrivingCalibration =
        new(Values.HaDistractedDrivingCalibration);

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaDrinkPolicy = new(
        Values.HaDrinkPolicy
    );

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaDriverObstructionPolicy =
        new(Values.HaDriverObstructionPolicy);

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaDrowsinessDetection =
        new(Values.HaDrowsinessDetection);

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaEvent = new(
        Values.HaEvent
    );

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaFalsePositive = new(
        Values.HaFalsePositive
    );

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaFoodPolicy = new(
        Values.HaFoodPolicy
    );

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaHighSpeedSuddenDisconnect =
        new(Values.HaHighSpeedSuddenDisconnect);

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaInvalid = new(
        Values.HaInvalid
    );

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaLaneDeparture = new(
        Values.HaLaneDeparture
    );

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaMaskPolicy = new(
        Values.HaMaskPolicy
    );

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaNearCollision = new(
        Values.HaNearCollision
    );

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaOutwardObstructionPolicy =
        new(Values.HaOutwardObstructionPolicy);

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaPassengerPolicy =
        new(Values.HaPassengerPolicy);

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaPersonalProtectiveEquipment =
        new(Values.HaPersonalProtectiveEquipment);

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaPhonePolicy = new(
        Values.HaPhonePolicy
    );

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaPolicyDetector =
        new(Values.HaPolicyDetector);

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaRearCollisionWarning =
        new(Values.HaRearCollisionWarning);

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaRedLightViolation =
        new(Values.HaRedLightViolation);

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaRolledStopSign =
        new(Values.HaRolledStopSign);

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaRollover = new(
        Values.HaRollover
    );

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaRolloverProtectionBrakeControlActivated =
        new(Values.HaRolloverProtectionBrakeControlActivated);

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaRolloverProtectionEngineControlActivated =
        new(Values.HaRolloverProtectionEngineControlActivated);

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaSeatbeltPolicy =
        new(Values.HaSeatbeltPolicy);

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaSharpTurn = new(
        Values.HaSharpTurn
    );

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaSignDetection = new(
        Values.HaSignDetection
    );

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaSmokingPolicy = new(
        Values.HaSmokingPolicy
    );

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaSpeeding = new(
        Values.HaSpeeding
    );

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaTailgating = new(
        Values.HaTailgating
    );

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaTileRollingRailroadCrossing =
        new(Values.HaTileRollingRailroadCrossing);

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaTileRollingStopSign =
        new(Values.HaTileRollingStopSign);

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaTrafficLightDetection =
        new(Values.HaTrafficLightDetection);

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaUnsafeParking = new(
        Values.HaUnsafeParking
    );

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaVehicleInBlindSpotWarning =
        new(Values.HaVehicleInBlindSpotWarning);

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaVulnerableRoadUserCollisionWarning =
        new(Values.HaVulnerableRoadUserCollisionWarning);

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaYawControlBrakeControlActivated =
        new(Values.HaYawControlBrakeControlActivated);

    public static readonly HarshEventTriggerDetailsObjectRequestBodyTypesItem HaYawControlEngineControlActivated =
        new(Values.HaYawControlEngineControlActivated);

    public HarshEventTriggerDetailsObjectRequestBodyTypesItem(string value)
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
    public static HarshEventTriggerDetailsObjectRequestBodyTypesItem FromCustom(string value)
    {
        return new HarshEventTriggerDetailsObjectRequestBodyTypesItem(value);
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
        HarshEventTriggerDetailsObjectRequestBodyTypesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        HarshEventTriggerDetailsObjectRequestBodyTypesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        HarshEventTriggerDetailsObjectRequestBodyTypesItem value
    ) => value.Value;

    public static explicit operator HarshEventTriggerDetailsObjectRequestBodyTypesItem(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string HaAccel = "haAccel";

        public const string HaBraking = "haBraking";

        public const string HaCameraMisaligned = "haCameraMisaligned";

        public const string HaCrash = "haCrash";

        public const string HaDistractedDriving = "haDistractedDriving";

        public const string HaDistractedDrivingCalibration = "haDistractedDrivingCalibration";

        public const string HaDrinkPolicy = "haDrinkPolicy";

        public const string HaDriverObstructionPolicy = "haDriverObstructionPolicy";

        public const string HaDrowsinessDetection = "haDrowsinessDetection";

        public const string HaEvent = "haEvent";

        public const string HaFalsePositive = "haFalsePositive";

        public const string HaFoodPolicy = "haFoodPolicy";

        public const string HaHighSpeedSuddenDisconnect = "haHighSpeedSuddenDisconnect";

        public const string HaInvalid = "haInvalid";

        public const string HaLaneDeparture = "haLaneDeparture";

        public const string HaMaskPolicy = "haMaskPolicy";

        public const string HaNearCollision = "haNearCollision";

        public const string HaOutwardObstructionPolicy = "haOutwardObstructionPolicy";

        public const string HaPassengerPolicy = "haPassengerPolicy";

        public const string HaPersonalProtectiveEquipment = "haPersonalProtectiveEquipment";

        public const string HaPhonePolicy = "haPhonePolicy";

        public const string HaPolicyDetector = "haPolicyDetector";

        public const string HaRearCollisionWarning = "haRearCollisionWarning";

        public const string HaRedLightViolation = "haRedLightViolation";

        public const string HaRolledStopSign = "haRolledStopSign";

        public const string HaRollover = "haRollover";

        public const string HaRolloverProtectionBrakeControlActivated =
            "haRolloverProtectionBrakeControlActivated";

        public const string HaRolloverProtectionEngineControlActivated =
            "haRolloverProtectionEngineControlActivated";

        public const string HaSeatbeltPolicy = "haSeatbeltPolicy";

        public const string HaSharpTurn = "haSharpTurn";

        public const string HaSignDetection = "haSignDetection";

        public const string HaSmokingPolicy = "haSmokingPolicy";

        public const string HaSpeeding = "haSpeeding";

        public const string HaTailgating = "haTailgating";

        public const string HaTileRollingRailroadCrossing = "haTileRollingRailroadCrossing";

        public const string HaTileRollingStopSign = "haTileRollingStopSign";

        public const string HaTrafficLightDetection = "haTrafficLightDetection";

        public const string HaUnsafeParking = "haUnsafeParking";

        public const string HaVehicleInBlindSpotWarning = "haVehicleInBlindSpotWarning";

        public const string HaVulnerableRoadUserCollisionWarning =
            "haVulnerableRoadUserCollisionWarning";

        public const string HaYawControlBrakeControlActivated = "haYawControlBrakeControlActivated";

        public const string HaYawControlEngineControlActivated =
            "haYawControlEngineControlActivated";
    }
}
