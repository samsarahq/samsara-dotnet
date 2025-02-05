using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsSeatbeltDriver
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Seatbelt Driver Status as read from the vehicle. `Buckled` or `Unbuckled`.
    /// </summary>
    [JsonPropertyName("value")]
    public required VehicleStatsSeatbeltDriverValue Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
