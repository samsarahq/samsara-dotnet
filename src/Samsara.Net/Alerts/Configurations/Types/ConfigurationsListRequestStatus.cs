using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Alerts.Configurations;

[JsonConverter(typeof(EnumSerializer<ConfigurationsListRequestStatus>))]
public enum ConfigurationsListRequestStatus
{
    [EnumMember(Value = "all")]
    All,

    [EnumMember(Value = "enabled")]
    Enabled,

    [EnumMember(Value = "disabled")]
    Disabled,
}
