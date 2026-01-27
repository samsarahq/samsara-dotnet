using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.WorkOrders;

[Serializable]
public record WorkOrdersPostInvoiceScanRequestBody
{
    /// <summary>
    /// Asset ID to create a new work order for the invoice. Provide either workOrderId OR assetId, but not both. If assetId is provided, a new work order will be created for that asset. If workOrderId is provided instead, the invoice will be attached to the existing work order.
    /// </summary>
    [JsonPropertyName("assetId")]
    public string? AssetId { get; set; }

    [JsonPropertyName("file")]
    public required InvoiceScanFileRequestBody File { get; set; }

    /// <summary>
    /// Work order ID to attach the invoice to an existing work order. Provide either workOrderId OR assetId, but not both. If workOrderId is provided, the invoice will be attached to the existing work order. If assetId is provided instead, a new work order will be created for that asset.
    /// </summary>
    [JsonPropertyName("workOrderId")]
    public string? WorkOrderId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
