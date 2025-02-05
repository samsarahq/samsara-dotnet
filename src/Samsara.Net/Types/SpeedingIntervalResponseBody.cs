using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record SpeedingIntervalResponseBody
{
    /// <summary>
    /// UTC time the interval ended in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("endTime")]
    public required string EndTime { get; set; }

    /// <summary>
    /// Whether the interval is dismissed.
    /// </summary>
    [JsonPropertyName("isDismissed")]
    public required bool IsDismissed { get; set; }

    [JsonPropertyName("location")]
    public required SpeedingIntervalLocationResponseResponseBody Location { get; set; }

    /// <summary>
    /// The max speed exceeded for the speeding interval.
    /// </summary>
    [JsonPropertyName("maxSpeedKilometersPerHour")]
    public required double MaxSpeedKilometersPerHour { get; set; }

    /// <summary>
    /// The posted speed limit associated with the speeding interval.
    /// </summary>
    [JsonPropertyName("postedSpeedLimitKilometersPerHour")]
    public required double PostedSpeedLimitKilometersPerHour { get; set; }

    /// <summary>
    /// Specifies the severity level of the speeding interval.  Valid values: `light`, `moderate`, `heavy`, `severe`
    /// </summary>
    [JsonPropertyName("severityLevel")]
    public required SpeedingIntervalResponseBodySeverityLevel SeverityLevel { get; set; }

    /// <summary>
    /// UTC time the interval started in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("startTime")]
    public required string StartTime { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
