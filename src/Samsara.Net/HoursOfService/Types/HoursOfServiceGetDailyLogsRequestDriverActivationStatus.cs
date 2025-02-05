using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.HoursOfService;

[JsonConverter(typeof(EnumSerializer<HoursOfServiceGetDailyLogsRequestDriverActivationStatus>))]
public enum HoursOfServiceGetDailyLogsRequestDriverActivationStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "deactivated")]
    Deactivated,
}
