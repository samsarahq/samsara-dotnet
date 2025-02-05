using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record RecipientObjectResponseBody
{
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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
