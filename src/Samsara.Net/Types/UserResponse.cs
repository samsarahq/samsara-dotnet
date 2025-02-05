using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record UserResponse
{
    [JsonPropertyName("data")]
    public User? Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
