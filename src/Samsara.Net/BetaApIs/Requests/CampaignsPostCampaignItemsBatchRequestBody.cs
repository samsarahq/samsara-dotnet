using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record CampaignsPostCampaignItemsBatchRequestBody
{
    /// <summary>
    /// Unique ID of the campaign.
    /// </summary>
    [JsonIgnore]
    public required string CampaignId { get; set; }

    /// <summary>
    /// Entries to add to the campaign.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<CampaignItemIngestEntryObjectRequestBody> Data { get; set; } =
        new List<CampaignItemIngestEntryObjectRequestBody>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
