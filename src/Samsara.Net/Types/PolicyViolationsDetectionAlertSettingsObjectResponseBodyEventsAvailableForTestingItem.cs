using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(EnumSerializer<PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsAvailableForTestingItem>)
)]
public enum PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsAvailableForTestingItem
{
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
