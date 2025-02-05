using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AttributeResponse
{
    [JsonPropertyName("data")]
    public Attribute? Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
