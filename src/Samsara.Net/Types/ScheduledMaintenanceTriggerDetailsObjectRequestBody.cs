using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record ScheduledMaintenanceTriggerDetailsObjectRequestBody
{
    /// <summary>
    /// Alert when maintenance is due in the specified number of days.
    /// </summary>
    [JsonPropertyName("dueInDays")]
    public required long DueInDays { get; set; }

    /// <summary>
    /// The id of the maintenance schedule.
    /// </summary>
    [JsonPropertyName("scheduleId")]
    public required string ScheduleId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
