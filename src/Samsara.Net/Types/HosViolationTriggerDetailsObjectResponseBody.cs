using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosViolationTriggerDetailsObjectResponseBody
{
    /// <summary>
    /// Alert if driver has this specified time until driving causes an HOS violation.
    /// </summary>
    [JsonPropertyName("maxUntilViolationMilliseconds")]
    public required long MaxUntilViolationMilliseconds { get; set; }

    /// <summary>
    /// The type of HOS violation.  Valid values: `CaliforniaMealbreakMissed`, `CycleHoursOn`, `DailyDrivingHours`, `DailyOnDutyHours`, `Invalid`, `RestbreakMissed`, `ShiftDrivingHours`, `ShiftHours`, `ShiftOnDutyHours`, `UnsubmittedLogs`
    /// </summary>
    [JsonPropertyName("violation")]
    public required HosViolationTriggerDetailsObjectResponseBodyViolation Violation { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
