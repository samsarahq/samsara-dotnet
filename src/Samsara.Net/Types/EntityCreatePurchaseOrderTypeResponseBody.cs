using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// PurchaseOrder object
/// </summary>
[Serializable]
public record EntityCreatePurchaseOrderTypeResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// RFC3339 time when the purchase order was created.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public string? CreatedAtTime { get; set; }

    /// <summary>
    /// Source that created the purchase order.  Valid values: `Unknown`, `User`, `ScanPackingList`
    /// </summary>
    [JsonPropertyName("creationSource")]
    public EntityCreatePurchaseOrderTypeResponseBodyCreationSource? CreationSource { get; set; }

    /// <summary>
    /// RFC3339 expected delivery time.
    /// </summary>
    [JsonPropertyName("deliveryAtTime")]
    public string? DeliveryAtTime { get; set; }

    /// <summary>
    /// RFC3339 time when the first item was received.
    /// </summary>
    [JsonPropertyName("firstReceivedAtTime")]
    public string? FirstReceivedAtTime { get; set; }

    /// <summary>
    /// RFC3339 time when all items were received.
    /// </summary>
    [JsonPropertyName("fullyReceivedAtTime")]
    public string? FullyReceivedAtTime { get; set; }

    /// <summary>
    /// General ledger code associated with this purchase order.
    /// </summary>
    [JsonPropertyName("glCode")]
    public string? GlCode { get; set; }

    /// <summary>
    /// Stable Samsara ID for the purchase order.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Vendor invoice number associated with this purchase order.
    /// </summary>
    [JsonPropertyName("invoiceNumber")]
    public string? InvoiceNumber { get; set; }

    /// <summary>
    /// IDs of media items attached to the purchase order.
    /// </summary>
    [JsonPropertyName("mediaItemIds")]
    public IEnumerable<string>? MediaItemIds { get; set; }

    /// <summary>
    /// Free-text notes for the purchase order.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// Current customer-visible status of the purchase order.  Valid values: `Unknown`, `Draft`, `Open`, `InReview`, `Approved`, `Rejected`, `SentToVendor`, `PartiallyReceived`, `FullyReceived`, `Returned`, `Cancelled`, `Closed`
    /// </summary>
    [JsonPropertyName("orderStatus")]
    public EntityCreatePurchaseOrderTypeResponseBodyOrderStatus? OrderStatus { get; set; }

    [JsonPropertyName("otherCost")]
    public CreatePurchaseOrderEntityPurchaseOrderMoneyPublicVariant8749B9E1F4AfTypeResponseBody? OtherCost { get; set; }

    /// <summary>
    /// Parts ordered on the purchase order.
    /// </summary>
    [JsonPropertyName("parts")]
    public IEnumerable<CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBody>? Parts { get; set; }

    /// <summary>
    /// Customer-visible purchase order number.
    /// </summary>
    [JsonPropertyName("poNumber")]
    public string? PoNumber { get; set; }

    /// <summary>
    /// Optional prefix included in the purchase order number.
    /// </summary>
    [JsonPropertyName("poNumberPrefix")]
    public string? PoNumberPrefix { get; set; }

    /// <summary>
    /// Optional suffix included in the purchase order number.
    /// </summary>
    [JsonPropertyName("poNumberSuffix")]
    public string? PoNumberSuffix { get; set; }

    /// <summary>
    /// RFC3339 time when the purchase order was sent to its vendor.
    /// </summary>
    [JsonPropertyName("sentAtTime")]
    public string? SentAtTime { get; set; }

    [JsonPropertyName("tax")]
    public CreatePurchaseOrderEntityPurchaseOrderTaxAdjustmentTypeResponseBody? Tax { get; set; }

    [JsonPropertyName("taxTotal")]
    public CreatePurchaseOrderEntityPurchaseOrderMoneyTypeResponseBody? TaxTotal { get; set; }

    /// <summary>
    /// Shipment tracking number for the purchase order.
    /// </summary>
    [JsonPropertyName("trackingNumber")]
    public string? TrackingNumber { get; set; }

    /// <summary>
    /// RFC3339 time when the purchase order was last updated.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public string? UpdatedAtTime { get; set; }

    [JsonPropertyName("vendor")]
    public EntityCreatePurchaseOrderVendorRefPublicVariant07Ae4B76C2BaTypeResponseBody? Vendor { get; set; }

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
