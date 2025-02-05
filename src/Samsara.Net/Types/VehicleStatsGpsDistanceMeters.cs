using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsGpsDistanceMeters
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Number of meters the vehicle has traveled since the gateway was installed, based on GPS calculations.
    /// </summary>
    [JsonPropertyName("value")]
    public required double Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
