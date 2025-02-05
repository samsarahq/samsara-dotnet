using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(EnumSerializer<InattentiveDrivingDetectionAlertSettingsObjectResponseBodySeverity>)
)]
public enum InattentiveDrivingDetectionAlertSettingsObjectResponseBodySeverity
{
    [EnumMember(Value = "low")]
    Low,

    [EnumMember(Value = "medium")]
    Medium,

    [EnumMember(Value = "high")]
    High,
}
