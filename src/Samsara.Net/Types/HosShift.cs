using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosShift
{
    /// <summary>
    /// Remaining on duty or driving time the driver in the current shift in milliseconds. For property-carrying drivers, this is the amount of time the driver can be on duty or driving before hitting the 14-hour limit.
    /// </summary>
    [JsonPropertyName("shiftRemainingDurationMs")]
    public double? ShiftRemainingDurationMs { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
