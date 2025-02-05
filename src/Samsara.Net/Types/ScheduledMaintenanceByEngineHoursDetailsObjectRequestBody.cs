using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record ScheduledMaintenanceByEngineHoursDetailsObjectRequestBody
{
    /// <summary>
    /// Alert when maintenance is due in the specified number of hours.
    /// </summary>
    [JsonPropertyName("dueInHours")]
    public required long DueInHours { get; set; }

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
