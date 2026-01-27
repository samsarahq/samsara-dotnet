using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A depreciation or adjustment transaction
/// </summary>
[Serializable]
public record DepreciationTransactionObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("amount")]
    public required DepreciationTransactionMoneyObjectResponseBody Amount { get; set; }

    /// <summary>
    /// Samsara asset ID. Can be used with /fleet/assets/{id} to retrieve asset details.
    /// </summary>
    [JsonPropertyName("assetId")]
    public required string AssetId { get; set; }

    /// <summary>
    /// The UUID of the cost center assigned to the asset. To retrieve cost center names: (1) Call GET /attributes?entityType=asset to find the "Asset Cost Center" attribute and its UUID, (2) Call GET /attributes/{that-uuid}?entityType=asset to get the list of cost center values with their UUIDs and names. Match the costCenterId from this response to the uuid field in the attributeValues array to get the cost center name.
    /// </summary>
    [JsonPropertyName("costCenterId")]
    public string? CostCenterId { get; set; }

    /// <summary>
    /// When the transaction record was created in the system. RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// When the depreciation or adjustment occurred from a financial/accounting perspective (e.g., end of depreciation period, or date of revaluation). This may differ from createdAt if the transaction is recorded after the fact. RFC 3339 format.
    /// </summary>
    [JsonPropertyName("eventTime")]
    public required DateTime EventTime { get; set; }

    /// <summary>
    /// The unique UUID of the transaction.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Optional description.
    /// </summary>
    [JsonPropertyName("note")]
    public string? Note { get; set; }

    /// <summary>
    /// Transaction type: depreciation, adjustment, or unknown. Unknown transaction types should be handled gracefully for forward compatibility.  Valid values: `depreciation`, `adjustment`, `unknown`
    /// </summary>
    [JsonPropertyName("transactionType")]
    public required DepreciationTransactionObjectResponseBodyTransactionType TransactionType { get; set; }

    /// <summary>
    /// When the transaction record was last modified in the system (use for incremental sync). RFC 3339 format.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

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
