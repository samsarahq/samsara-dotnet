using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record J1939D1StatusDataPoint
{
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>
    /// List of active statuses.
    /// </summary>
    [JsonPropertyName("value")]
    public IEnumerable<J1939D1StatusDataPointValue>? Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
