using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosViolationDayObjectResponseBody
{
    /// <summary>
    /// The end time of the day on which the violation occurred in RFC 3339 format. This is determined by the driver's ELD start hour (00:00 or 12:00)
    /// </summary>
    [JsonPropertyName("endTime")]
    public required string EndTime { get; set; }

    /// <summary>
    /// The start time of the day on which the violation occurred in RFC 3339 format. This is determined by the driver's ELD start hour (00:00 or 12:00)
    /// </summary>
    [JsonPropertyName("startTime")]
    public required string StartTime { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
