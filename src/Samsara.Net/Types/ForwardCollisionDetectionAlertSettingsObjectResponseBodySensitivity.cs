using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(EnumSerializer<ForwardCollisionDetectionAlertSettingsObjectResponseBodySensitivity>)
)]
public enum ForwardCollisionDetectionAlertSettingsObjectResponseBodySensitivity
{
    [EnumMember(Value = "near")]
    Near,

    [EnumMember(Value = "medium")]
    Medium,

    [EnumMember(Value = "far")]
    Far,
}
