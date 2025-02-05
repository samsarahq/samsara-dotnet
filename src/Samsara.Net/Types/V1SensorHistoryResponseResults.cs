using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1SensorHistoryResponseResults
{
    /// <summary>
    /// List of datapoints, one for each requested (sensor, field) pair.
    /// </summary>
    [JsonPropertyName("series")]
    public IEnumerable<long>? Series { get; set; }

    /// <summary>
    /// Timestamp in UNIX milliseconds.
    /// </summary>
    [JsonPropertyName("timeMs")]
    public int? TimeMs { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
