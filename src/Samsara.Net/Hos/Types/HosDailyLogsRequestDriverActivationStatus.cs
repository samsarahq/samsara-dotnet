using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Hos;

[JsonConverter(typeof(EnumSerializer<HosDailyLogsRequestDriverActivationStatus>))]
public enum HosDailyLogsRequestDriverActivationStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "deactivated")]
    Deactivated,
}
