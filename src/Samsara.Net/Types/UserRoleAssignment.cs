using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record UserRoleAssignment
{
    [JsonPropertyName("expireAt")]
    public string? ExpireAt { get; set; }

    [JsonPropertyName("role")]
    public UserRole? Role { get; set; }

    [JsonPropertyName("tag")]
    public TagTinyResponse? Tag { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
