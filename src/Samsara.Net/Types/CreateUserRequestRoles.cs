using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A role that applies to a user. If the role has a `tagId`, then the role applies for that tag. If there is no `tagId`, then the role applies at the organizational level. A user may have many tag-specific roles, but may only have one organizational role. If the organizational level role has higher privileges than a tag-specific role, then the organizational role privileges will take precedence.
/// </summary>
public record CreateUserRequestRoles
{
    /// <summary>
    /// The unique ID for the role.
    /// </summary>
    [JsonPropertyName("roleId")]
    public required string RoleId { get; set; }

    /// <summary>
    /// ID of the tag this role applies to.
    /// </summary>
    [JsonPropertyName("tagId")]
    public string? TagId { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
