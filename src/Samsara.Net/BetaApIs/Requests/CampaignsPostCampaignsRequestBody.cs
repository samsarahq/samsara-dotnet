using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record CampaignsPostCampaignsRequestBody
{
    /// <summary>
    /// Customer or OEM-aligned campaign number.
    /// </summary>
    [JsonPropertyName("campaignNumber")]
    public string? CampaignNumber { get; set; }

    /// <summary>
    /// Type of the campaign.  Valid values: `safetyRecall`, `mandatoryCampaign`, `voluntary`, `internal`
    /// </summary>
    [JsonPropertyName("campaignType")]
    public required CampaignsPostCampaignsRequestBodyCampaignType CampaignType { get; set; }

    /// <summary>
    /// Free-form description of the campaign.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// End of the campaign in RFC 3339 format. Must not be before `startTime`.
    /// </summary>
    [JsonPropertyName("endTime")]
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// Whether campaign work is expected to be claimable as warranty or recall work. Defaults to false.
    /// </summary>
    [JsonPropertyName("isWarranty")]
    public bool? IsWarranty { get; set; }

    /// <summary>
    /// Display name of the campaign.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("recallMetadata")]
    public CampaignRecallMetadataRequestObjectRequestBody? RecallMetadata { get; set; }

    /// <summary>
    /// Start of the campaign in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("startTime")]
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// Priority applied to work orders generated from the campaign. Uses the same values as the `priority` field of the Work Orders API. Defaults to no priority.  Valid values: `High`, `Low`, `Medium`, `Urgent`
    /// </summary>
    [JsonPropertyName("workOrderPriority")]
    public CampaignsPostCampaignsRequestBodyWorkOrderPriority? WorkOrderPriority { get; set; }

    /// <summary>
    /// ID of a work order template, as returned by GET /maintenance/work-order-templates, that pre-populates work orders generated from the campaign.
    /// </summary>
    [JsonPropertyName("workOrderTemplateId")]
    public string? WorkOrderTemplateId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
