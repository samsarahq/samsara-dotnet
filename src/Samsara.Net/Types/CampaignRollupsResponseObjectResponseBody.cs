using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Progress rollups for a campaign's items.
/// </summary>
[Serializable]
public record CampaignRollupsResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Number of items that have been in a non-terminal state (`pending`, `hold`, `ready`, `workOrderCreated`) for more than 30 days.
    /// </summary>
    [JsonPropertyName("agingItemCount")]
    public required long AgingItemCount { get; set; }

    /// <summary>
    /// Unique ID of the campaign.
    /// </summary>
    [JsonPropertyName("campaignId")]
    public required string CampaignId { get; set; }

    /// <summary>
    /// Item counts grouped by state. Every state reported by the service is present, including states with a count of 0.
    /// </summary>
    [JsonPropertyName("itemCountsByState")]
    public IEnumerable<CampaignItemStateCountResponseObjectResponseBody> ItemCountsByState { get; set; } =
        new List<CampaignItemStateCountResponseObjectResponseBody>();

    /// <summary>
    /// Total number of items on the campaign.
    /// </summary>
    [JsonPropertyName("totalItemCount")]
    public required long TotalItemCount { get; set; }

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
