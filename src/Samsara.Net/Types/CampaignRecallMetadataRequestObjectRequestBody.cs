using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Recall provenance for a recall-sourced campaign.
/// </summary>
[Serializable]
public record CampaignRecallMetadataRequestObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// NHTSA recall number.
    /// </summary>
    [JsonPropertyName("nhtsaRecallNumber")]
    public string? NhtsaRecallNumber { get; set; }

    /// <summary>
    /// Time the OEM issued the notification, in RFC 3339 format. Only the date component is meaningful; the time component is stored as provided.
    /// </summary>
    [JsonPropertyName("oemNotificationTime")]
    public DateTime? OemNotificationTime { get; set; }

    /// <summary>
    /// OEM recall number.
    /// </summary>
    [JsonPropertyName("oemRecallNumber")]
    public string? OemRecallNumber { get; set; }

    /// <summary>
    /// Time owners were notified, in RFC 3339 format. Only the date component is meaningful; the time component is stored as provided.
    /// </summary>
    [JsonPropertyName("ownerNotificationTime")]
    public DateTime? OwnerNotificationTime { get; set; }

    /// <summary>
    /// Time parts became available, in RFC 3339 format. Only the date component is meaningful; the time component is stored as provided.
    /// </summary>
    [JsonPropertyName("partsAvailableTime")]
    public DateTime? PartsAvailableTime { get; set; }

    /// <summary>
    /// Where the recall notice came from.  Valid values: `recallMasters`, `nhtsa`, `oem`, `manual`, `api`
    /// </summary>
    [JsonPropertyName("recallSource")]
    public required CampaignRecallMetadataRequestObjectRequestBodyRecallSource RecallSource { get; set; }

    /// <summary>
    /// Time a remedy became available, in RFC 3339 format. Only the date component is meaningful; the time component is stored as provided.
    /// </summary>
    [JsonPropertyName("remedyAvailableTime")]
    public DateTime? RemedyAvailableTime { get; set; }

    /// <summary>
    /// Recall number that supersedes this recall.
    /// </summary>
    [JsonPropertyName("supersededByRecallNumber")]
    public string? SupersededByRecallNumber { get; set; }

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
