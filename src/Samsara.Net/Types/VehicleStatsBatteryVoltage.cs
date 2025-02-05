using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsBatteryVoltage
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// The battery voltage in millivolts.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
