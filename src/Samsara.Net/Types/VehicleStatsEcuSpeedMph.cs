using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsEcuSpeedMph
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// The speed of the vehicle in miles per hour.
    /// </summary>
    [JsonPropertyName("value")]
    public required double Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
