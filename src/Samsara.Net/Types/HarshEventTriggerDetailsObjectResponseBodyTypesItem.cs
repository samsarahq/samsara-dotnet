using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<HarshEventTriggerDetailsObjectResponseBodyTypesItem>))]
[Serializable]
public readonly record struct HarshEventTriggerDetailsObjectResponseBodyTypesItem : IStringEnum
{
    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaAccel = new(
        Values.HaAccel
    );

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaBraking = new(
        Values.HaBraking
    );

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaCameraMisaligned =
        new(Values.HaCameraMisaligned);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaCrash = new(
        Values.HaCrash
    );

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaDistractedDriving =
        new(Values.HaDistractedDriving);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaDistractedDrivingCalibration =
        new(Values.HaDistractedDrivingCalibration);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaDrinkPolicy = new(
        Values.HaDrinkPolicy
    );

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaDriverObstructionPolicy =
        new(Values.HaDriverObstructionPolicy);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaDrowsinessDetection =
        new(Values.HaDrowsinessDetection);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaEvent = new(
        Values.HaEvent
    );

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaFalsePositive =
        new(Values.HaFalsePositive);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaFoodPolicy = new(
        Values.HaFoodPolicy
    );

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaHighSpeedSuddenDisconnect =
        new(Values.HaHighSpeedSuddenDisconnect);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaInvalid = new(
        Values.HaInvalid
    );

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaLaneDeparture =
        new(Values.HaLaneDeparture);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaMaskPolicy = new(
        Values.HaMaskPolicy
    );

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaNearCollision =
        new(Values.HaNearCollision);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaOutwardObstructionPolicy =
        new(Values.HaOutwardObstructionPolicy);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaPassengerPolicy =
        new(Values.HaPassengerPolicy);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaPersonalProtectiveEquipment =
        new(Values.HaPersonalProtectiveEquipment);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaPhonePolicy = new(
        Values.HaPhonePolicy
    );

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaPolicyDetector =
        new(Values.HaPolicyDetector);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaRearCollisionWarning =
        new(Values.HaRearCollisionWarning);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaRedLightViolation =
        new(Values.HaRedLightViolation);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaRolledStopSign =
        new(Values.HaRolledStopSign);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaRollover = new(
        Values.HaRollover
    );

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaRolloverProtectionBrakeControlActivated =
        new(Values.HaRolloverProtectionBrakeControlActivated);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaRolloverProtectionEngineControlActivated =
        new(Values.HaRolloverProtectionEngineControlActivated);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaSeatbeltPolicy =
        new(Values.HaSeatbeltPolicy);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaSharpTurn = new(
        Values.HaSharpTurn
    );

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaSignDetection =
        new(Values.HaSignDetection);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaSmokingPolicy =
        new(Values.HaSmokingPolicy);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaSpeeding = new(
        Values.HaSpeeding
    );

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaTailgating = new(
        Values.HaTailgating
    );

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaTileRollingRailroadCrossing =
        new(Values.HaTileRollingRailroadCrossing);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaTileRollingStopSign =
        new(Values.HaTileRollingStopSign);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaTrafficLightDetection =
        new(Values.HaTrafficLightDetection);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaUnsafeParking =
        new(Values.HaUnsafeParking);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaVehicleInBlindSpotWarning =
        new(Values.HaVehicleInBlindSpotWarning);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaVulnerableRoadUserCollisionWarning =
        new(Values.HaVulnerableRoadUserCollisionWarning);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaYawControlBrakeControlActivated =
        new(Values.HaYawControlBrakeControlActivated);

    public static readonly HarshEventTriggerDetailsObjectResponseBodyTypesItem HaYawControlEngineControlActivated =
        new(Values.HaYawControlEngineControlActivated);

    public HarshEventTriggerDetailsObjectResponseBodyTypesItem(string value)
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
    public static HarshEventTriggerDetailsObjectResponseBodyTypesItem FromCustom(string value)
    {
        return new HarshEventTriggerDetailsObjectResponseBodyTypesItem(value);
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
        HarshEventTriggerDetailsObjectResponseBodyTypesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        HarshEventTriggerDetailsObjectResponseBodyTypesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        HarshEventTriggerDetailsObjectResponseBodyTypesItem value
    ) => value.Value;

    public static explicit operator HarshEventTriggerDetailsObjectResponseBodyTypesItem(
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
