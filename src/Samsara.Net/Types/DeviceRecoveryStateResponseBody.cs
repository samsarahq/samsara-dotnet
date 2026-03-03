using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The full recovery state for an asset, including notification recipients and recovery photos.
/// </summary>
[Serializable]
public record DeviceRecoveryStateResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Additional details provided during recovery.
    /// </summary>
    [JsonPropertyName("additional_details")]
    public string? AdditionalDetails { get; set; }

    /// <summary>
    /// The unique Samsara ID of the asset.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The reason the asset was originally marked as missing.
    /// </summary>
    [JsonPropertyName("missing_reason")]
    public string? MissingReason { get; set; }

    /// <summary>
    /// The human-readable name of the asset.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// A note associated with the recovery state.
    /// </summary>
    [JsonPropertyName("note")]
    public string? Note { get; set; }

    /// <summary>
    /// Users subscribed to location update notifications for this asset.
    /// </summary>
    [JsonPropertyName("notification_recipients")]
    public IEnumerable<NotificationRecipientResponseBody>? NotificationRecipients { get; set; }

    /// <summary>
    /// Photos associated with the recovery event. URLs are temporary and expire at url_expires_at_ms.
    /// </summary>
    [JsonPropertyName("recovery_photos")]
    public IEnumerable<RecoveryPhotoResponseBody>? RecoveryPhotos { get; set; }

    /// <summary>
    /// Whether the asset was physically recovered.
    /// </summary>
    [JsonPropertyName("recovery_status")]
    public string? RecoveryStatus { get; set; }

    /// <summary>
    /// The current recovery status of the asset.  Valid values: `UNKNOWN`, `MISSING`, `LOCATED`, `RECOVERED`
    /// </summary>
    [JsonPropertyName("status")]
    public required DeviceRecoveryStateResponseBodyStatus Status { get; set; }

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
