using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Recipient of an Action. One of userId contactId or roleId needs to be set.
/// </summary>
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
