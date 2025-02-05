using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsIntakeManifoldTempMilliC
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// The intake manifold temperature reading in millidegree Celsius.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
