using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A user subscribed to recovery state change notifications, including their name and email.
/// </summary>
[Serializable]
public record NotificationRecipientResponseResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The email address of the user.
    /// </summary>
    [JsonPropertyName("email")]
    public required string Email { get; set; }

    /// <summary>
    /// The display name of the user.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// How the user is notified.
    /// </summary>
    [JsonPropertyName("notification_types")]
    public IEnumerable<NotificationRecipientResponseResponseBodyNotificationTypesItem> NotificationTypes { get; set; } =
        new List<NotificationRecipientResponseResponseBodyNotificationTypesItem>();

    /// <summary>
    /// The ID of the user.
    /// </summary>
    [JsonPropertyName("user_id")]
    public required long UserId { get; set; }

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
