using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record User
{
    [JsonPropertyName("authType")]
    public required UserAuthType AuthType { get; set; }

    [JsonPropertyName("email")]
    public required string Email { get; set; }

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("roles")]
    public IEnumerable<UserRoleAssignment> Roles { get; set; } = new List<UserRoleAssignment>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
