using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsObdOdometerMeters
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Number of meters the vehicle has traveled according to the on-board diagnostics.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
