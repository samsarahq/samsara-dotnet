using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<SafetyEventBehaviorLabelsResponseBodyType>))]
public enum SafetyEventBehaviorLabelsResponseBodyType
{
    [EnumMember(Value = "Acceleration")]
    Acceleration,

    [EnumMember(Value = "Braking")]
    Braking,

    [EnumMember(Value = "Crash")]
    Crash,

    [EnumMember(Value = "DefensiveDriving")]
    DefensiveDriving,

    [EnumMember(Value = "DidNotYield")]
    DidNotYield,

    [EnumMember(Value = "Drinking")]
    Drinking,

    [EnumMember(Value = "Drowsy")]
    Drowsy,

    [EnumMember(Value = "Eating")]
    Eating,

    [EnumMember(Value = "EatingDrinking")]
    EatingDrinking,

    [EnumMember(Value = "EdgeDistractedDriving")]
    EdgeDistractedDriving,

    [EnumMember(Value = "EdgeRailroadCrossingViolation")]
    EdgeRailroadCrossingViolation,

    [EnumMember(Value = "FollowingDistance")]
    FollowingDistance,

    [EnumMember(Value = "FollowingDistanceModerate")]
    FollowingDistanceModerate,

    [EnumMember(Value = "FollowingDistanceSevere")]
    FollowingDistanceSevere,

    [EnumMember(Value = "ForwardCollisionWarning")]
    ForwardCollisionWarning,

    [EnumMember(Value = "GenericDistraction")]
    GenericDistraction,

    [EnumMember(Value = "GenericTailgating")]
    GenericTailgating,

    [EnumMember(Value = "HarshTurn")]
    HarshTurn,

    [EnumMember(Value = "Invalid")]
    Invalid,

    [EnumMember(Value = "LaneDeparture")]
    LaneDeparture,

    [EnumMember(Value = "LateResponse")]
    LateResponse,

    [EnumMember(Value = "MobileUsage")]
    MobileUsage,

    [EnumMember(Value = "NearCollison")]
    NearCollison,

    [EnumMember(Value = "NoSeatbelt")]
    NoSeatbelt,

    [EnumMember(Value = "ObstructedCamera")]
    ObstructedCamera,

    [EnumMember(Value = "Passenger")]
    Passenger,

    [EnumMember(Value = "PolicyViolationMask")]
    PolicyViolationMask,

    [EnumMember(Value = "RanRedLight")]
    RanRedLight,

    [EnumMember(Value = "RollingStop")]
    RollingStop,

    [EnumMember(Value = "RolloverProtection")]
    RolloverProtection,

    [EnumMember(Value = "Smoking")]
    Smoking,

    [EnumMember(Value = "Speeding")]
    Speeding,

    [EnumMember(Value = "VulnerableRoadUserCollisionWarning")]
    VulnerableRoadUserCollisionWarning,

    [EnumMember(Value = "YawControl")]
    YawControl,
}
