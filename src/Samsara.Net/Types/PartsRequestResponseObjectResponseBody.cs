using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// One line of a parts request: the demand for one part.
/// </summary>
[Serializable]
public record PartsRequestResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// How the line is fulfilled. `unknown` when no method is set yet.  Valid values: `stock`, `purchase`, `transfer`, `unknown`
    /// </summary>
    [JsonPropertyName("fulfillmentMethod")]
    public required PartsRequestResponseObjectResponseBodyFulfillmentMethod FulfillmentMethod { get; set; }

    /// <summary>
    /// Unique ID of the parts request line, in the format `{partsRequestId}-{lineId}`.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// ID of the line. Unique within its parts request.
    /// </summary>
    [JsonPropertyName("lineId")]
    public required string LineId { get; set; }

    /// <summary>
    /// Purchase order lines that order this line's part. Excludes deleted purchase orders and purchase orders you cannot read. All linked lines still count toward `status`. Quantities are per purchase order line.
    /// </summary>
    [JsonPropertyName("linkedPurchaseOrderLines")]
    public IEnumerable<PartsRequestLinkedPurchaseOrderLineResponseObjectResponseBody> LinkedPurchaseOrderLines { get; set; } =
        new List<PartsRequestLinkedPurchaseOrderLineResponseObjectResponseBody>();

    /// <summary>
    /// ID of the maintenance site that requested the part. Uses the same ID as GET /maintenance/sites.
    /// </summary>
    [JsonPropertyName("maintenanceSiteId")]
    public required string MaintenanceSiteId { get; set; }

    /// <summary>
    /// Time the part is needed by, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("needByTime")]
    public DateTime? NeedByTime { get; set; }

    /// <summary>
    /// Samsara ID of the requested part. Uses the same ID as the `partSamsaraId` of the Purchase Orders API.
    /// </summary>
    [JsonPropertyName("partSamsaraId")]
    public required string PartSamsaraId { get; set; }

    /// <summary>
    /// ID of the parts request that contains the line.
    /// </summary>
    [JsonPropertyName("partsRequestId")]
    public required string PartsRequestId { get; set; }

    /// <summary>
    /// Priority of the parts request. Defaults to `unknown` when the priority is not recognized.  Valid values: `low`, `medium`, `high`, `critical`, `unknown`
    /// </summary>
    [JsonPropertyName("priority")]
    public required PartsRequestResponseObjectResponseBodyPriority Priority { get; set; }

    /// <summary>
    /// Quantity of the part requested on the line.
    /// </summary>
    [JsonPropertyName("requestedQuantity")]
    public required double RequestedQuantity { get; set; }

    /// <summary>
    /// Quantity of inventory reserved for the line from stock, transfers and purchase order receipts. Separate from `requestedQuantity` and from the quantities of `linkedPurchaseOrderLines`.
    /// </summary>
    [JsonPropertyName("reservedQuantity")]
    public required double ReservedQuantity { get; set; }

    /// <summary>
    /// Status of the line. For lines fulfilled by purchase, the status is derived from the ordered and received quantities of all linked purchase order lines, including lines on deleted purchase orders, to match the dashboard. Returns `unknown` for an unrecognized or unsupported status.  Valid values: `draft`, `submitted`, `partiallyOrdered`, `ordered`, `partiallyReceived`, `received`, `closed`, `cancelled`, `unknown`
    /// </summary>
    [JsonPropertyName("status")]
    public required PartsRequestResponseObjectResponseBodyStatus Status { get; set; }

    /// <summary>
    /// Time the parts request was submitted, in RFC 3339 format. Omitted for drafts.
    /// </summary>
    [JsonPropertyName("submittedAtTime")]
    public DateTime? SubmittedAtTime { get; set; }

    /// <summary>
    /// ID of the linked work order. Uses the same ID as the Work Orders API. Omitted when the line has no work order or you cannot read the work order.
    /// </summary>
    [JsonPropertyName("workOrderId")]
    public string? WorkOrderId { get; set; }

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
