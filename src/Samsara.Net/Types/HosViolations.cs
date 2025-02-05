using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosViolations
{
    /// <summary>
    /// Time since the driver has surpassed the driving cycle duration limit in milliseconds. For property-carrying drivers, this is the amount of time the driver has been on duty or driving past the 60/70-hour limit in 7/8 days.
    /// </summary>
    [JsonPropertyName("cycleViolationDurationMs")]
    public double? CycleViolationDurationMs { get; set; }

    /// <summary>
    /// Time since the driver has surpassed the driving shift duration limit in milliseconds. For property-carrying drivers, this is the amount of time the driver has been driving past the 11-hour limit.
    /// </summary>
    [JsonPropertyName("shiftDrivingViolationDurationMs")]
    public double? ShiftDrivingViolationDurationMs { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
