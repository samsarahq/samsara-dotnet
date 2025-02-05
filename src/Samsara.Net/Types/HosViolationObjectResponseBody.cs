using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosViolationObjectResponseBody
{
    [JsonPropertyName("day")]
    public required HosViolationDayObjectResponseBody Day { get; set; }

    /// <summary>
    /// Description containing violation type, region, and other metadata. This field can assume the following formats for the following types:
    /// californiaMealbreakMissed, restbreakMissed: "[description] ([max on duty hours] hours)"
    /// cycleHoursOn, dailyDrivingHours, dailyOffDutyNonResetHours, dailyOffDutyTotalHours, dailyOnDutyHours, shiftDrivingHours, shiftHours, shiftOnDutyHours: "[description] ([region]-[max hours in duty status] hours)"
    /// cycleOffHoursAfterOnDutyHours: "[description] ([region]): [minimum hours consecutive rest] hours off duty required after [max hours before consecutive rest] hours on-duty time"
    /// dailyOffDutyDeferralAddToDay2Consecutive, dailyOffDutyDeferralNotPartMandatory, dailyOffDutyDeferralTwoDayDrivingLimit, dailyOffDutyDeferralTwoDayOffDuty, mandatory24HoursOffDuty: "[description] ([region])"
    /// unsubmittedLogs: "Missing Driver Certification"
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; set; }

    [JsonPropertyName("driver")]
    public required GoaDriverTinyResponseResponseBody Driver { get; set; }

    /// <summary>
    /// Duration the driver was in violation in milliseconds. This is the time between the time the driver starts being in violation until the end of the time window for violations that have one (e.g. `shiftDrivingHours`) or until the end of the day. The duration of some violations may cover the whole day (e.g. `unsubmittedLogs`).
    /// </summary>
    [JsonPropertyName("durationMs")]
    public required long DurationMs { get; set; }

    /// <summary>
    /// The string value of the violation type.  Valid values: `NONE`, `californiaMealbreakMissed`, `cycleHoursOn`, `cycleOffHoursAfterOnDutyHours`, `dailyDrivingHours`, `dailyOffDutyDeferralAddToDay2Consecutive`, `dailyOffDutyDeferralNotPartMandatory`, `dailyOffDutyDeferralTwoDayDrivingLimit`, `dailyOffDutyDeferralTwoDayOffDuty`, `dailyOffDutyNonResetHours`, `dailyOffDutyTotalHours`, `dailyOnDutyHours`, `mandatory24HoursOffDuty`, `restbreakMissed`, `shiftDrivingHours`, `shiftHours`, `shiftOnDutyHours`, `unsubmittedLogs`
    /// </summary>
    [JsonPropertyName("type")]
    public required HosViolationObjectResponseBodyType Type { get; set; }

    /// <summary>
    /// The start time of the violation in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("violationStartTime")]
    public required string ViolationStartTime { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
