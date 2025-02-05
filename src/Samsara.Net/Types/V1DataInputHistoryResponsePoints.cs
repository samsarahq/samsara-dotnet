using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DataInputHistoryResponsePoints
{
    [JsonPropertyName("timeMs")]
    public long? TimeMs { get; set; }

    [JsonPropertyName("value")]
    public double? Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
