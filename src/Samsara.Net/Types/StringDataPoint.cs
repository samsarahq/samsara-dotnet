using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record StringDataPoint
{
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>
    /// String value of the data point.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
