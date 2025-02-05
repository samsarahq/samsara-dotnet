using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TagResponse
{
    [JsonPropertyName("data")]
    public Tag? Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
