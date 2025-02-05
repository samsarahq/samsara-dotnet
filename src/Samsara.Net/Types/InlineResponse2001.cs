using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record InlineResponse2001
{
    [JsonPropertyName("assets")]
    public IEnumerable<V1Asset>? Assets { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
