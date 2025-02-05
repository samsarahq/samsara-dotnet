using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1MachineHistoryResponseVibrations
{
    [JsonPropertyName("X")]
    public double? X { get; set; }

    [JsonPropertyName("Y")]
    public double? Y { get; set; }

    [JsonPropertyName("Z")]
    public double? Z { get; set; }

    [JsonPropertyName("time")]
    public long? Time { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
