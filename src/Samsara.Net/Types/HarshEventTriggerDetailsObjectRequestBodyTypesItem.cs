using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<HarshEventTriggerDetailsObjectRequestBodyTypesItem>))]
public enum HarshEventTriggerDetailsObjectRequestBodyTypesItem
{
    [EnumMember(Value = "haAccel")]
    HaAccel,

    [EnumMember(Value = "haBraking")]
    HaBraking,

    [EnumMember(Value = "haCameraMisaligned")]
    HaCameraMisaligned,

    [EnumMember(Value = "haCrash")]
    HaCrash,

    [EnumMember(Value = "haDistractedDriving")]
    HaDistractedDriving,

    [EnumMember(Value = "haDistractedDrivingCalibration")]
    HaDistractedDrivingCalibration,

    [EnumMember(Value = "haDrinkPolicy")]
    HaDrinkPolicy,

    [EnumMember(Value = "haDriverObstructionPolicy")]
    HaDriverObstructionPolicy,

    [EnumMember(Value = "haDrowsinessDetection")]
    HaDrowsinessDetection,

    [EnumMember(Value = "haEvent")]
    HaEvent,

    [EnumMember(Value = "haFalsePositive")]
    HaFalsePositive,

    [EnumMember(Value = "haFoodPolicy")]
    HaFoodPolicy,

    [EnumMember(Value = "haInvalid")]
    HaInvalid,

    [EnumMember(Value = "haLaneDeparture")]
    HaLaneDeparture,

    [EnumMember(Value = "haMaskPolicy")]
    HaMaskPolicy,

    [EnumMember(Value = "haNearCollision")]
    HaNearCollision,

    [EnumMember(Value = "haOutwardObstructionPolicy")]
    HaOutwardObstructionPolicy,

    [EnumMember(Value = "haPassengerPolicy")]
    HaPassengerPolicy,

    [EnumMember(Value = "haPhonePolicy")]
    HaPhonePolicy,

    [EnumMember(Value = "haPolicyDetector")]
    HaPolicyDetector,

    [EnumMember(Value = "haRearCollisionWarning")]
    HaRearCollisionWarning,

    [EnumMember(Value = "haRolledStopSign")]
    HaRolledStopSign,

    [EnumMember(Value = "haRollover")]
    HaRollover,

    [EnumMember(Value = "haRolloverProtectionBrakeControlActivated")]
    HaRolloverProtectionBrakeControlActivated,

    [EnumMember(Value = "haRolloverProtectionEngineControlActivated")]
    HaRolloverProtectionEngineControlActivated,

    [EnumMember(Value = "haSeatbeltPolicy")]
    HaSeatbeltPolicy,

    [EnumMember(Value = "haSharpTurn")]
    HaSharpTurn,

    [EnumMember(Value = "haSignDetection")]
    HaSignDetection,

    [EnumMember(Value = "haSmokingPolicy")]
    HaSmokingPolicy,

    [EnumMember(Value = "haSpeeding")]
    HaSpeeding,

    [EnumMember(Value = "haTailgating")]
    HaTailgating,

    [EnumMember(Value = "haTileRollingRailroadCrossing")]
    HaTileRollingRailroadCrossing,

    [EnumMember(Value = "haTileRollingStopSign")]
    HaTileRollingStopSign,

    [EnumMember(Value = "haUnsafeParking")]
    HaUnsafeParking,

    [EnumMember(Value = "haVulnerableRoadUserCollisionWarning")]
    HaVulnerableRoadUserCollisionWarning,

    [EnumMember(Value = "haYawControlBrakeControlActivated")]
    HaYawControlBrakeControlActivated,

    [EnumMember(Value = "haYawControlEngineControlActivated")]
    HaYawControlEngineControlActivated,
}
