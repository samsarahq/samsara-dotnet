using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A recovered asset with its recovery details, including recovery photos.
/// </summary>
[Serializable]
public record RecoveryStateResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The unique Samsara ID of the asset.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The human-readable name of the asset.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// A note associated with the recovery.
    /// </summary>
    [JsonPropertyName("note")]
    public string? Note { get; set; }

    /// <summary>
    /// Users subscribed to location update notifications for this asset.
    /// </summary>
    [JsonPropertyName("notification_recipients")]
    public IEnumerable<NotificationRecipientResponseResponseBody>? NotificationRecipients { get; set; }

    /// <summary>
    /// Photos associated with the recovery event. URLs are temporary and expire at url_expires_at_ms.
    /// </summary>
    [JsonPropertyName("recovery_photos")]
    public IEnumerable<RecoveryPhotoResponseBody>? RecoveryPhotos { get; set; }

    /// <summary>
    /// Timestamp when the recovery state was last updated, in milliseconds since epoch.
    /// </summary>
    [JsonPropertyName("updated_at_ms")]
    public required long UpdatedAtMs { get; set; }

    /// <summary>
    /// The ID of the user who last updated the recovery state.
    /// </summary>
    [JsonPropertyName("updated_by_user_id")]
    public long? UpdatedByUserId { get; set; }

    /// <summary>
    /// The unique UUID of this recovery state record.
    /// </summary>
    [JsonPropertyName("uuid")]
    public required string Uuid { get; set; }

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
