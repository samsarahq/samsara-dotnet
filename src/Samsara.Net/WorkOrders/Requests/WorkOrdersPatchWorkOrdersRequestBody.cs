using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.WorkOrders;

[Serializable]
public record WorkOrdersPatchWorkOrdersRequestBody
{
    /// <summary>
    /// The ID of the assigned mechanic.
    /// </summary>
    [JsonPropertyName("assignedUserId")]
    public string? AssignedUserId { get; set; }

    /// <summary>
    /// The category of the work order
    /// </summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>
    /// Notes on the work order.
    /// </summary>
    [JsonPropertyName("closingNotes")]
    public string? ClosingNotes { get; set; }

    /// <summary>
    /// The time the work order was completed in RFC 3339 format. Is automatically set when the status changes and this field is not provided.
    /// </summary>
    [JsonPropertyName("completedAtTime")]
    public DateTime? CompletedAtTime { get; set; }

    /// <summary>
    /// A description of what needs to be fixed.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("discount")]
    public WorkOrderDiscountObjectRequestBody? Discount { get; set; }

    /// <summary>
    /// The due date of the work order in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("dueAtTime")]
    public DateTime? DueAtTime { get; set; }

    /// <summary>
    /// The engine hours at the time of the work order. Will default to current asset reading if unset.
    /// </summary>
    [JsonPropertyName("engineHours")]
    public long? EngineHours { get; set; }

    /// <summary>
    /// The unique id of the work order.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The invoice number for the work order.
    /// </summary>
    [JsonPropertyName("invoiceNumber")]
    public string? InvoiceNumber { get; set; }

    /// <summary>
    /// Items related to the work order.
    /// </summary>
    [JsonPropertyName("items")]
    public IEnumerable<WorkOrderItemObjectRequestBody>? Items { get; set; }

    /// <summary>
    /// The odometer reading at the time of the work order. Will default to current asset reading if unset.
    /// </summary>
    [JsonPropertyName("odometerMeters")]
    public long? OdometerMeters { get; set; }

    /// <summary>
    /// External ID (`key:value`) of the Place where the work is performed. Resolved against the organization's external IDs for places. Send an empty string to clear the maintenance site on the work order. Mutually exclusive with `placeId`.
    /// </summary>
    [JsonPropertyName("placeExternalId")]
    public string? PlaceExternalId { get; set; }

    /// <summary>
    /// ID of the Place where the work is performed. Must reference a Place returned by the Places API that is linked to a maintenance site in the organization. Send an empty string to clear the maintenance site on the work order. Mutually exclusive with `placeExternalId`.
    /// </summary>
    [JsonPropertyName("placeId")]
    public string? PlaceId { get; set; }

    /// <summary>
    /// The purchase order number for the work order.
    /// </summary>
    [JsonPropertyName("poNumber")]
    public string? PoNumber { get; set; }

    /// <summary>
    /// The priority of the work order  Valid values: `High`, `Low`, `Medium`, `Urgent`
    /// </summary>
    [JsonPropertyName("priority")]
    public WorkOrdersPatchWorkOrdersRequestBodyPriority? Priority { get; set; }

    /// <summary>
    /// Service Tasks for the work order.
    /// </summary>
    [JsonPropertyName("serviceTaskInstances")]
    public IEnumerable<ServiceTaskInstanceInputObjectRequestBody>? ServiceTaskInstances { get; set; }

    /// <summary>
    /// The status of the work order  Valid values: `Assigned`, `Cancelled`, `Closed`, `Completed`, `Estimate`, `In Progress`, `On Hold`, `Open`, `Pending Approval`, `Pending Parts`, `Planning`
    /// </summary>
    [JsonPropertyName("status")]
    public WorkOrdersPatchWorkOrdersRequestBodyStatus? Status { get; set; }

    [JsonPropertyName("tax")]
    public WorkOrderTaxObjectRequestBody? Tax { get; set; }

    /// <summary>
    /// The vendor UUID for the work order.
    /// </summary>
    [JsonPropertyName("vendorUuid")]
    public string? VendorUuid { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
