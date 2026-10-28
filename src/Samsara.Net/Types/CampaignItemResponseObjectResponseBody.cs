using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// One asset's membership in a campaign.
/// </summary>
[Serializable]
public record CampaignItemResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// ID of the asset affected by the campaign.
    /// </summary>
    [JsonPropertyName("assetId")]
    public required string AssetId { get; set; }

    /// <summary>
    /// Unique ID of the campaign the item belongs to.
    /// </summary>
    [JsonPropertyName("campaignId")]
    public required string CampaignId { get; set; }

    /// <summary>
    /// Time the item was completed, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("completedAtTime")]
    public DateTime? CompletedAtTime { get; set; }

    /// <summary>
    /// Time the item was created, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required DateTime CreatedAtTime { get; set; }

    /// <summary>
    /// Reason the item was dismissed, when `state` is `dismissed`.
    /// </summary>
    [JsonPropertyName("dismissedReason")]
    public string? DismissedReason { get; set; }

    /// <summary>
    /// The state the item behaves as. Equal to `state`, except `suspended` for an open item (`pending`, `hold`, `ready`) on a campaign that is in `draft` or `onHold`, where the item is kept off work orders until the campaign is active.  Valid values: `pending`, `hold`, `ready`, `workOrderCreated`, `complete`, `dismissed`, `cancelled`, `suspended`, `unknown`
    /// </summary>
    [JsonPropertyName("effectiveState")]
    public required CampaignItemResponseObjectResponseBodyEffectiveState EffectiveState { get; set; }

    /// <summary>
    /// Unique ID of the campaign item.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// ID of the work order that materialized from this item, if any. Uses the same ID as the Work Orders API.
    /// </summary>
    [JsonPropertyName("linkedWorkOrderId")]
    public string? LinkedWorkOrderId { get; set; }

    /// <summary>
    /// How the asset joined the campaign. Items added through this API are `api`.  Valid values: `api`, `targeting`, `manual`, `csv`, `assistant`, `unknown`
    /// </summary>
    [JsonPropertyName("sourceBasis")]
    public required CampaignItemResponseObjectResponseBodySourceBasis SourceBasis { get; set; }

    /// <summary>
    /// Opaque reference to the source feed row, supplied when the item was ingested, for external reconciliation.
    /// </summary>
    [JsonPropertyName("sourceRef")]
    public string? SourceRef { get; set; }

    /// <summary>
    /// Stored lifecycle state of the item. Defaults to `unknown` when the state is not recognized.  Valid values: `pending`, `hold`, `ready`, `workOrderCreated`, `complete`, `dismissed`, `cancelled`, `unknown`
    /// </summary>
    [JsonPropertyName("state")]
    public required CampaignItemResponseObjectResponseBodyState State { get; set; }

    /// <summary>
    /// Time the item entered its current state, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("stateSinceTime")]
    public required DateTime StateSinceTime { get; set; }

    /// <summary>
    /// VIN as provided by the source of the item, if any.
    /// </summary>
    [JsonPropertyName("vin")]
    public string? Vin { get; set; }

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
