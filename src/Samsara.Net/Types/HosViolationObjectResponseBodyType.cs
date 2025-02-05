using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<HosViolationObjectResponseBodyType>))]
public enum HosViolationObjectResponseBodyType
{
    [EnumMember(Value = "NONE")]
    None,

    [EnumMember(Value = "californiaMealbreakMissed")]
    CaliforniaMealbreakMissed,

    [EnumMember(Value = "cycleHoursOn")]
    CycleHoursOn,

    [EnumMember(Value = "cycleOffHoursAfterOnDutyHours")]
    CycleOffHoursAfterOnDutyHours,

    [EnumMember(Value = "dailyDrivingHours")]
    DailyDrivingHours,

    [EnumMember(Value = "dailyOffDutyDeferralAddToDay2Consecutive")]
    DailyOffDutyDeferralAddToDay2Consecutive,

    [EnumMember(Value = "dailyOffDutyDeferralNotPartMandatory")]
    DailyOffDutyDeferralNotPartMandatory,

    [EnumMember(Value = "dailyOffDutyDeferralTwoDayDrivingLimit")]
    DailyOffDutyDeferralTwoDayDrivingLimit,

    [EnumMember(Value = "dailyOffDutyDeferralTwoDayOffDuty")]
    DailyOffDutyDeferralTwoDayOffDuty,

    [EnumMember(Value = "dailyOffDutyNonResetHours")]
    DailyOffDutyNonResetHours,

    [EnumMember(Value = "dailyOffDutyTotalHours")]
    DailyOffDutyTotalHours,

    [EnumMember(Value = "dailyOnDutyHours")]
    DailyOnDutyHours,

    [EnumMember(Value = "mandatory24HoursOffDuty")]
    Mandatory24HoursOffDuty,

    [EnumMember(Value = "restbreakMissed")]
    RestbreakMissed,

    [EnumMember(Value = "shiftDrivingHours")]
    ShiftDrivingHours,

    [EnumMember(Value = "shiftHours")]
    ShiftHours,

    [EnumMember(Value = "shiftOnDutyHours")]
    ShiftOnDutyHours,

    [EnumMember(Value = "unsubmittedLogs")]
    UnsubmittedLogs,
}
