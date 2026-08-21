using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record EntityPurchaseOrdersServiceCreatePurchaseOrderRequestBody
{
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
    public required EntityPurchaseOrdersServiceCreatePurchaseOrderRequestBodyOrderStatus OrderStatus { get; set; }

    [JsonPropertyName("otherCost")]
    public CreatePurchaseOrderEntityPurchaseOrderMoneyInputPublicVarianta2E1675A5A65TypeRequestBody? OtherCost { get; set; }

    /// <summary>
    /// Parts ordered on the purchase order.
    /// </summary>
    [JsonPropertyName("parts")]
    public IEnumerable<CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBody>? Parts { get; set; }

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

    [JsonPropertyName("tax")]
    public CreatePurchaseOrderEntityPurchaseOrderTaxAdjustmentInputTypeRequestBody? Tax { get; set; }

    /// <summary>
    /// Shipment tracking number for the purchase order.
    /// </summary>
    [JsonPropertyName("trackingNumber")]
    public string? TrackingNumber { get; set; }

    /// <summary>
    /// ID of the vendor supplying this purchase order.
    /// </summary>
    [JsonPropertyName("vendorId")]
    public required string VendorId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
