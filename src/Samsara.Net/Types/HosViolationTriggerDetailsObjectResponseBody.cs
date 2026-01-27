using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to HOS Violation
/// </summary>
[Serializable]
public record HosViolationTriggerDetailsObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
