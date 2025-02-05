using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Users;

public record CreateUserRequest
{
    /// <summary>
    /// The authentication type the user uses to authenticate. To use SAML this organization must have a configured SAML integration. Valid values: `default`, `saml`.
    /// </summary>
    [JsonPropertyName("authType")]
    public required CreateUserRequestAuthType AuthType { get; set; }

    /// <summary>
    /// The email address of this user.
    /// </summary>
    [JsonPropertyName("email")]
    public required string Email { get; set; }

    /// <summary>
    /// For users with temporary access, this is the expiration datetime in RFC3339 format
    /// </summary>
    [JsonPropertyName("expireAt")]
    public string? ExpireAt { get; set; }

    /// <summary>
    /// The first and last name of the user.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The list of roles that applies to this user. A user may have "organizational" roles, which apply to the user at the organizational level, and "tag-specific" roles, which apply to the user for a given tag.
    /// </summary>
    [JsonPropertyName("roles")]
    public IEnumerable<CreateUserRequestRoles> Roles { get; set; } =
        new List<CreateUserRequestRoles>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
