using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsResponseSeatbeltDriver
{
    /// <summary>
    /// UTC timestamp in RFC 3339 format. Example: `2020-01-27T07:06:25Z`.
    /// </summary>
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Seatbelt Driver Status as read from the vehicle. `Buckled` or `Unbuckled`.
    /// </summary>
    [JsonPropertyName("value")]
    public required VehicleStatsResponseSeatbeltDriverValue Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
