using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.HoursOfService;

[JsonConverter(typeof(EnumSerializer<HoursOfServiceGetHosDailyLogsRequestDriverActivationStatus>))]
public enum HoursOfServiceGetHosDailyLogsRequestDriverActivationStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "deactivated")]
    Deactivated,
}
