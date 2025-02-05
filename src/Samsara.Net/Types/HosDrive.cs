using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosDrive
{
    /// <summary>
    /// Remaining driving time the driver has in the current shift in milliseconds. For property-carrying drivers, this is the amount of time the driver can drive before hitting the 11-hour limit.
    /// </summary>
    [JsonPropertyName("driveRemainingDurationMs")]
    public double? DriveRemainingDurationMs { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
