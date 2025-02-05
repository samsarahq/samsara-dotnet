using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<SafetyEventBehaviorLabelType>))]
public enum SafetyEventBehaviorLabelType
{
    [EnumMember(Value = "genericTailgating")]
    GenericTailgating,

    [EnumMember(Value = "genericDistraction")]
    GenericDistraction,

    [EnumMember(Value = "defensiveDriving")]
    DefensiveDriving,

    [EnumMember(Value = "rollingStop")]
    RollingStop,

    [EnumMember(Value = "nearCollison")]
    NearCollison,

    [EnumMember(Value = "speeding")]
    Speeding,

    [EnumMember(Value = "obstructedCamera")]
    ObstructedCamera,

    [EnumMember(Value = "didNotYield")]
    DidNotYield,

    [EnumMember(Value = "noSeatbelt")]
    NoSeatbelt,

    [EnumMember(Value = "mobileUsage")]
    MobileUsage,

    [EnumMember(Value = "drowsy")]
    Drowsy,

    [EnumMember(Value = "laneDeparture")]
    LaneDeparture,

    [EnumMember(Value = "followingDistanceSevere")]
    FollowingDistanceSevere,

    [EnumMember(Value = "followingDistanceModerate")]
    FollowingDistanceModerate,

    [EnumMember(Value = "lateResponse")]
    LateResponse,

    [EnumMember(Value = "acceleration")]
    Acceleration,

    [EnumMember(Value = "braking")]
    Braking,

    [EnumMember(Value = "harshTurn")]
    HarshTurn,

    [EnumMember(Value = "crash")]
    Crash,

    [EnumMember(Value = "rolloverProtection")]
    RolloverProtection,

    [EnumMember(Value = "yawControl")]
    YawControl,

    [EnumMember(Value = "ranRedLight")]
    RanRedLight,

    [EnumMember(Value = "forwardCollisionWarning")]
    ForwardCollisionWarning,

    [EnumMember(Value = "eatingDrinking")]
    EatingDrinking,

    [EnumMember(Value = "smoking")]
    Smoking,

    [EnumMember(Value = "followingDistance")]
    FollowingDistance,

    [EnumMember(Value = "edgeDistractedDriving")]
    EdgeDistractedDriving,
}
