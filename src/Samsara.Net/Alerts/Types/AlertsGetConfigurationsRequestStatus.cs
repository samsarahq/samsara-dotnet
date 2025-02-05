using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Alerts;

[JsonConverter(typeof(EnumSerializer<AlertsGetConfigurationsRequestStatus>))]
public enum AlertsGetConfigurationsRequestStatus
{
    [EnumMember(Value = "all")]
    All,

    [EnumMember(Value = "enabled")]
    Enabled,

    [EnumMember(Value = "disabled")]
    Disabled,
}
