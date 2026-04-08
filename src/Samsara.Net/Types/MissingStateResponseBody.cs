using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// An asset currently marked as missing, including notification recipients.
/// </summary>
[Serializable]
public record MissingStateResponseBody : IJsonOnDeserialized
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
    /// Timestamp when the asset was first marked as missing, in milliseconds since epoch. Unlike updated_at_ms, this value is preserved when the missing state is edited.
    /// </summary>
    [JsonPropertyName("initiated_at_ms")]
    public long? InitiatedAtMs { get; set; }

    /// <summary>
    /// The ID of the user who first marked this asset as missing. Unlike updated_by_user_id, this value is preserved when the missing state is edited.
    /// </summary>
    [JsonPropertyName("initiated_by_user_id")]
    public long? InitiatedByUserId { get; set; }

    /// <summary>
    /// The human-readable name of the asset.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// A note associated with the missing asset.
    /// </summary>
    [JsonPropertyName("note")]
    public string? Note { get; set; }

    /// <summary>
    /// Users subscribed to location update notifications for this asset.
    /// </summary>
    [JsonPropertyName("notification_recipients")]
    public IEnumerable<NotificationRecipientResponseResponseBody>? NotificationRecipients { get; set; }

    /// <summary>
    /// The source of the last update to this recovery state. Defaults to `dashboard` if not explicitly set.  Valid values: `dashboard`, `api`
    /// </summary>
    [JsonPropertyName("update_source")]
    public MissingStateResponseBodyUpdateSource? UpdateSource { get; set; }

    /// <summary>
    /// Timestamp when the asset was marked as missing, in milliseconds since epoch.
    /// </summary>
    [JsonPropertyName("updated_at_ms")]
    public required long UpdatedAtMs { get; set; }

    /// <summary>
    /// The ID of the user who marked the asset as missing.
    /// </summary>
    [JsonPropertyName("updated_by_user_id")]
    public long? UpdatedByUserId { get; set; }

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
