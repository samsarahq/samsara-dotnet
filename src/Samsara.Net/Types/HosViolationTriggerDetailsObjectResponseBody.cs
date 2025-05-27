using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to HOS Violation
/// </summary>
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
