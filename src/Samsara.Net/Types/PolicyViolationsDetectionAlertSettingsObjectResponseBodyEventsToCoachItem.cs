using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(EnumSerializer<PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsToCoachItem>)
)]
public enum PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsToCoachItem
{
    [EnumMember(Value = "noSeatbelt")]
    NoSeatbelt,

    [EnumMember(Value = "noMask")]
    NoMask,

    [EnumMember(Value = "mobileUsage")]
    MobileUsage,

    [EnumMember(Value = "smoking")]
    Smoking,

    [EnumMember(Value = "eatingDrinking")]
    EatingDrinking,

    [EnumMember(Value = "inwardCameraObstruction")]
    InwardCameraObstruction,

    [EnumMember(Value = "outwardCameraObstruction")]
    OutwardCameraObstruction,
}
