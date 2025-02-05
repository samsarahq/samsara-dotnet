using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record ContactResponse
{
    [JsonPropertyName("data")]
    public Contact? Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
