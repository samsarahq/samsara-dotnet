using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<TimeRangeObjectResponseBodyDaysOfWeekItem>))]
public enum TimeRangeObjectResponseBodyDaysOfWeekItem
{
    [EnumMember(Value = "FRIDAY")]
    Friday,

    [EnumMember(Value = "MONDAY")]
    Monday,

    [EnumMember(Value = "SATURDAY")]
    Saturday,

    [EnumMember(Value = "SUNDAY")]
    Sunday,

    [EnumMember(Value = "THURSDAY")]
    Thursday,

    [EnumMember(Value = "TUESDAY")]
    Tuesday,

    [EnumMember(Value = "WEDNESDAY")]
    Wednesday,
}
