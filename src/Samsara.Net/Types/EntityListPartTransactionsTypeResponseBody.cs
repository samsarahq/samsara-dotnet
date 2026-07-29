using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// InventoryTransaction object
/// </summary>
[Serializable]
public record EntityListPartTransactionsTypeResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Batch or lot identifier, when the part is batch-tracked.
    /// </summary>
    [JsonPropertyName("batch")]
    public string? Batch { get; set; }

    /// <summary>
    /// Server ingestion timestamp. Not used for filtering or ordering.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public string? CreatedAtTime { get; set; }

    /// <summary>
    /// ID of the user who performed the transaction. Absent on work-order-backed and requisition-backed types.
    /// </summary>
    [JsonPropertyName("createdByUserId")]
    public string? CreatedByUserId { get; set; }

    /// <summary>
    /// Transfer only — source maintenance site (place ID).
    /// </summary>
    [JsonPropertyName("fromPlaceId")]
    public string? FromPlaceId { get; set; }

    /// <summary>
    /// User-supplied time the transaction occurred. The window filter and result ordering operate on this field.
    /// </summary>
    [JsonPropertyName("happenedAtTime")]
    public string? HappenedAtTime { get; set; }

    /// <summary>
    /// Stable unique identifier for the inventory transaction.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Free-text notes. Present on scrap and adjust transactions.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("part")]
    public EntityListPartTransactionsPartDefinitionRefTypeResponseBody? Part { get; set; }

    /// <summary>
    /// Maintenance site (linked Address/place ID) where this transaction occurred. For transfers, indicates which side of the transfer this record represents.
    /// </summary>
    [JsonPropertyName("placeId")]
    public string? PlaceId { get; set; }

    /// <summary>
    /// Purchase order reference. Present on receive transactions.
    /// </summary>
    [JsonPropertyName("purchaseOrder")]
    public string? PurchaseOrder { get; set; }

    /// <summary>
    /// Signed net effect on inventory in the part's unit of measure. Positive adds stock; negative removes it.
    /// </summary>
    [JsonPropertyName("quantity")]
    public double? Quantity { get; set; }

    /// <summary>
    /// Absolute on-hand quantity at the place after this transaction was applied.
    /// </summary>
    [JsonPropertyName("resultingQuantity")]
    public double? ResultingQuantity { get; set; }

    /// <summary>
    /// Transfer only — destination maintenance site (place ID).
    /// </summary>
    [JsonPropertyName("toPlaceId")]
    public string? ToPlaceId { get; set; }

    /// <summary>
    /// The kind of inventory movement this record represents.
    /// </summary>
    [JsonPropertyName("transactionType")]
    public string? TransactionType { get; set; }

    /// <summary>
    /// Per-unit cost recorded with the transaction. Present on receive transactions.
    /// </summary>
    [JsonPropertyName("unitCost")]
    public double? UnitCost { get; set; }

    /// <summary>
    /// Vendor the part was received from. Present on receive transactions. Resolvable via GET /fleet/maintenance/vendors.
    /// </summary>
    [JsonPropertyName("vendorId")]
    public string? VendorId { get; set; }

    [JsonPropertyName("workOrder")]
    public EntityListPartTransactionsWorkOrderRefTypeResponseBody? WorkOrder { get; set; }

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
