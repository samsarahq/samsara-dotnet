using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record InlineResponse2005
{
    [JsonPropertyName("data")]
    public IEnumerable<V1MessageResponse>? Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
