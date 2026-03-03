using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A user to notify about recovery state changes.
/// </summary>
[Serializable]
public record NotificationRecipientResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// How the user should be notified.
    /// </summary>
    [JsonPropertyName("notification_types")]
    public IEnumerable<NotificationRecipientResponseBodyNotificationTypesItem> NotificationTypes { get; set; } =
        new List<NotificationRecipientResponseBodyNotificationTypesItem>();

    /// <summary>
    /// The ID of the user to notify. Users can be retrieved via the getUser API endpoint.
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
