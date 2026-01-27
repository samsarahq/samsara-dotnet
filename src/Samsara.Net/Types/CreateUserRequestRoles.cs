using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A role that applies to a user. If the role has a `tagId`, then the role applies for that tag. If there is no `tagId`, then the role applies at the organizational level. A user may have many tag-specific roles, but may only have one organizational role. If the organizational level role has higher privileges than a tag-specific role, then the organizational role privileges will take precedence.
/// </summary>
[Serializable]
public record CreateUserRequestRoles : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
