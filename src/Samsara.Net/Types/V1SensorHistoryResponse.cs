using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1SensorHistoryResponse
{
    [JsonPropertyName("results")]
    public IEnumerable<V1SensorHistoryResponseResults>? Results { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
