using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record ScheduledMaintenanceOdometerTriggerDetailsObjectResponseBody
{
    /// <summary>
    /// Alert when vehicle odometer has this many meters left until maintenance is due.
    /// </summary>
    [JsonPropertyName("dueInMeters")]
    public required long DueInMeters { get; set; }

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
