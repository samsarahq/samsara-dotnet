using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosDailyLogsObjectResponseBody
{
    [JsonPropertyName("distanceTraveled")]
    public DistanceTraveledObjectResponseBody? DistanceTraveled { get; set; }

    [JsonPropertyName("driver")]
    public required DriverWithTimezoneEldSettingsObjectResponseBody Driver { get; set; }

    [JsonPropertyName("dutyStatusDurations")]
    public DutyStatusDurationObjectResponseBody? DutyStatusDurations { get; set; }

    /// <summary>
    /// The end time of the daily log in RFC 3339 format. This will be calculated using timezone of the driver.
    /// </summary>
    [JsonPropertyName("endTime")]
    public required string EndTime { get; set; }

    [JsonPropertyName("logMetaData")]
    public LogMetaDataObjectResponseBody? LogMetaData { get; set; }

    [JsonPropertyName("pendingDutyStatusDurations")]
    public PendingDutyStatusDurationsObjectResponseBody? PendingDutyStatusDurations { get; set; }

    /// <summary>
    /// The start time of the daily log in RFC 3339 format. This will be calculated using timezone of the driver.
    /// </summary>
    [JsonPropertyName("startTime")]
    public required string StartTime { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
