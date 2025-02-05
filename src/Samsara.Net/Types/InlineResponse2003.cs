using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record InlineResponse2003
{
    [JsonPropertyName("data")]
    public IEnumerable<V1AssetsReefer>? Data { get; set; }

    [JsonPropertyName("pagination")]
    public V1Pagination? Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
