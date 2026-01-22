using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Recipient of an Action. One of userId contactId or roleId needs to be set.
/// </summary>
[Serializable]
public record RecipientObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The ID of the contact.
    /// </summary>
    [JsonPropertyName("contactId")]
    public string? ContactId { get; set; }

    /// <summary>
    /// How the user/contact/role should be notified.
    /// </summary>
    [JsonPropertyName("notificationTypes")]
    public IEnumerable<RecipientObjectResponseBodyNotificationTypesItem>? NotificationTypes { get; set; }

    /// <summary>
    /// The ID of the role.
    /// </summary>
    [JsonPropertyName("roleId")]
    public string? RoleId { get; set; }

    /// <summary>
    /// The type of recipients  Valid values: `user`, `contact`, `role`
    /// </summary>
    [JsonPropertyName("type")]
    public required RecipientObjectResponseBodyType Type { get; set; }

    /// <summary>
    /// The ID of the user.
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

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
