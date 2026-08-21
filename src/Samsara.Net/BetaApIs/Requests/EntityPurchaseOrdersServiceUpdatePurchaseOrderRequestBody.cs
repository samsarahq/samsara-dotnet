using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record EntityPurchaseOrdersServiceUpdatePurchaseOrderRequestBody
{
    /// <summary>
    /// Unique identifier for the PurchaseOrder record.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// General ledger code associated with this purchase order.
    /// </summary>
    [JsonPropertyName("glCode")]
    public string? GlCode { get; set; }

    /// <summary>
    /// Vendor invoice number associated with this purchase order.
    /// </summary>
    [JsonPropertyName("invoiceNumber")]
    public string? InvoiceNumber { get; set; }

    /// <summary>
    /// Free-text notes for the purchase order.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// Current customer-visible status of the purchase order.  Valid values: `Unknown`, `Draft`, `Open`, `InReview`, `Approved`, `Rejected`, `SentToVendor`, `PartiallyReceived`, `FullyReceived`, `Returned`, `Cancelled`, `Closed`
    /// </summary>
    [JsonPropertyName("orderStatus")]
    public EntityPurchaseOrdersServiceUpdatePurchaseOrderRequestBodyOrderStatus? OrderStatus { get; set; }

    [JsonPropertyName("otherCost")]
    public UpdatePurchaseOrderEntityPurchaseOrderMoneyInputPublicVarianta34Bfd5A4152TypeRequestBody? OtherCost { get; set; }

    /// <summary>
    /// Parts ordered on the purchase order.
    /// </summary>
    [JsonPropertyName("parts")]
    public IEnumerable<UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBody>? Parts { get; set; }

    [JsonPropertyName("tax")]
    public UpdatePurchaseOrderEntityPurchaseOrderTaxAdjustmentInputTypeRequestBody? Tax { get; set; }

    /// <summary>
    /// Shipment tracking number for the purchase order.
    /// </summary>
    [JsonPropertyName("trackingNumber")]
    public string? TrackingNumber { get; set; }

    /// <summary>
    /// ID of the vendor supplying this purchase order.
    /// </summary>
    [JsonPropertyName("vendorId")]
    public string? VendorId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
