using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<BehaviorResponseBodyCoachableBehaviorType>))]
public enum BehaviorResponseBodyCoachableBehaviorType
{
    [EnumMember(Value = "acceleration")]
    Acceleration,

    [EnumMember(Value = "braking")]
    Braking,

    [EnumMember(Value = "cameraObstruction")]
    CameraObstruction,

    [EnumMember(Value = "crash")]
    Crash,

    [EnumMember(Value = "defensiveDriving")]
    DefensiveDriving,

    [EnumMember(Value = "didNotYield")]
    DidNotYield,

    [EnumMember(Value = "drinkPolicy")]
    DrinkPolicy,

    [EnumMember(Value = "drowsy")]
    Drowsy,

    [EnumMember(Value = "eatingDrinking")]
    EatingDrinking,

    [EnumMember(Value = "event")]
    Event,

    [EnumMember(Value = "falsePositive")]
    FalsePositive,

    [EnumMember(Value = "foodPolicy")]
    FoodPolicy,

    [EnumMember(Value = "forwardCollisionWarning")]
    ForwardCollisionWarning,

    [EnumMember(Value = "genericDistraction")]
    GenericDistraction,

    [EnumMember(Value = "harshTurn")]
    HarshTurn,

    [EnumMember(Value = "hosViolation")]
    HosViolation,

    [EnumMember(Value = "idling")]
    Idling,

    [EnumMember(Value = "laneDeparture")]
    LaneDeparture,

    [EnumMember(Value = "lateResponse")]
    LateResponse,

    [EnumMember(Value = "maskPolicy")]
    MaskPolicy,

    [EnumMember(Value = "maxSpeed")]
    MaxSpeed,

    [EnumMember(Value = "mobileUsage")]
    MobileUsage,

    [EnumMember(Value = "nearCollison")]
    NearCollison,

    [EnumMember(Value = "noSeatbelt")]
    NoSeatbelt,

    [EnumMember(Value = "obstructedCamera")]
    ObstructedCamera,

    [EnumMember(Value = "outwardObstruction")]
    OutwardObstruction,

    [EnumMember(Value = "passengerPolicy")]
    PassengerPolicy,

    [EnumMember(Value = "ranRedLight")]
    RanRedLight,

    [EnumMember(Value = "rollingRailroadCrossing")]
    RollingRailroadCrossing,

    [EnumMember(Value = "rollingStop")]
    RollingStop,

    [EnumMember(Value = "rollover")]
    Rollover,

    [EnumMember(Value = "rolloverProtection")]
    RolloverProtection,

    [EnumMember(Value = "rolloverProtectionBrakeControlActivated")]
    RolloverProtectionBrakeControlActivated,

    [EnumMember(Value = "rolloverProtectionEngineControlActivated")]
    RolloverProtectionEngineControlActivated,

    [EnumMember(Value = "severeSpeeding")]
    SevereSpeeding,

    [EnumMember(Value = "smoking")]
    Smoking,

    [EnumMember(Value = "speeding")]
    Speeding,

    [EnumMember(Value = "tailgating")]
    Tailgating,

    [EnumMember(Value = "unknown")]
    Unknown,

    [EnumMember(Value = "yawControl")]
    YawControl,

    [EnumMember(Value = "yawControlBrakeControlActivated")]
    YawControlBrakeControlActivated,

    [EnumMember(Value = "yawControlEngineControlActivated")]
    YawControlEngineControlActivated,
}
