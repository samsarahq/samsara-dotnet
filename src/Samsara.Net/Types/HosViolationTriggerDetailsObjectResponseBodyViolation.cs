using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<HosViolationTriggerDetailsObjectResponseBodyViolation>))]
public enum HosViolationTriggerDetailsObjectResponseBodyViolation
{
    [EnumMember(Value = "CaliforniaMealbreakMissed")]
    CaliforniaMealbreakMissed,

    [EnumMember(Value = "CycleHoursOn")]
    CycleHoursOn,

    [EnumMember(Value = "DailyDrivingHours")]
    DailyDrivingHours,

    [EnumMember(Value = "DailyOnDutyHours")]
    DailyOnDutyHours,

    [EnumMember(Value = "Invalid")]
    Invalid,

    [EnumMember(Value = "RestbreakMissed")]
    RestbreakMissed,

    [EnumMember(Value = "ShiftDrivingHours")]
    ShiftDrivingHours,

    [EnumMember(Value = "ShiftHours")]
    ShiftHours,

    [EnumMember(Value = "ShiftOnDutyHours")]
    ShiftOnDutyHours,

    [EnumMember(Value = "UnsubmittedLogs")]
    UnsubmittedLogs,
}
