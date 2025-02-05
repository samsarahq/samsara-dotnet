using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
