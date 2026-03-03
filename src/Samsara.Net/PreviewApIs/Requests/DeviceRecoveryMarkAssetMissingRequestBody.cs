using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.PreviewApIs;

[Serializable]
public record DeviceRecoveryMarkAssetMissingRequestBody
{
    /// <summary>
    /// The ID of the asset. This can be a Samsara internal ID or an external ID in the format `key:value`.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// Optional note when marking asset as missing.
    /// </summary>
    [JsonPropertyName("note")]
    public string? Note { get; set; }

    /// <summary>
    /// List of users to notify when asset is marked as missing.
    /// </summary>
    [JsonPropertyName("notification_recipients")]
    public IEnumerable<NotificationRecipientRequestBody>? NotificationRecipients { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
