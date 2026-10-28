using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A recall or campaign: a one-time batch of work applied across a targeted group of assets.
/// </summary>
[Serializable]
public record CampaignResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Customer or OEM-aligned campaign number.
    /// </summary>
    [JsonPropertyName("campaignNumber")]
    public string? CampaignNumber { get; set; }

    /// <summary>
    /// Type of the campaign. Defaults to `unknown` when the type is not recognized.  Valid values: `safetyRecall`, `mandatoryCampaign`, `voluntary`, `internal`, `unknown`
    /// </summary>
    [JsonPropertyName("campaignType")]
    public required CampaignResponseObjectResponseBodyCampaignType CampaignType { get; set; }

    /// <summary>
    /// Time the campaign was created, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required DateTime CreatedAtTime { get; set; }

    /// <summary>
    /// Where the campaign was created from. Campaigns created through this API are `api`. Defaults to `unknown` when the source is not recorded.  Valid values: `dashboard`, `api`, `assistant`, `unknown`
    /// </summary>
    [JsonPropertyName("createdSource")]
    public required CampaignResponseObjectResponseBodyCreatedSource CreatedSource { get; set; }

    /// <summary>
    /// Free-form description of the campaign.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// End of the campaign in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("endTime")]
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// Unique ID of the campaign.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Whether campaign work is expected to be claimable as warranty or recall work. Defaults to false.
    /// </summary>
    [JsonPropertyName("isWarranty")]
    public required bool IsWarranty { get; set; }

    /// <summary>
    /// Display name of the campaign.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("recallMetadata")]
    public CampaignRecallMetadataResponseObjectResponseBody? RecallMetadata { get; set; }

    /// <summary>
    /// Start of the campaign in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("startTime")]
    public DateTime? StartTime { get; set; }

    [JsonPropertyName("status")]
    public required CampaignStatusResponseObjectResponseBody Status { get; set; }

    /// <summary>
    /// Time the campaign was last updated, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required DateTime UpdatedAtTime { get; set; }

    /// <summary>
    /// Priority applied to work orders generated from the campaign. Uses the same values as the `priority` field of the Work Orders API.  Valid values: `High`, `Low`, `Medium`, `Urgent`
    /// </summary>
    [JsonPropertyName("workOrderPriority")]
    public CampaignResponseObjectResponseBodyWorkOrderPriority? WorkOrderPriority { get; set; }

    /// <summary>
    /// ID of the work order template that pre-populates work orders generated from the campaign.
    /// </summary>
    [JsonPropertyName("workOrderTemplateId")]
    public string? WorkOrderTemplateId { get; set; }

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
