using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A work order object.
/// </summary>
[Serializable]
public record WorkOrderWithTimeEntriesObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The time the work order was archived in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("archivedAtTime")]
    public DateTime? ArchivedAtTime { get; set; }

    /// <summary>
    /// The ID of the asset.
    /// </summary>
    [JsonPropertyName("assetId")]
    public required string AssetId { get; set; }

    /// <summary>
    /// The ID of the assigned mechanic.
    /// </summary>
    [JsonPropertyName("assignedUserId")]
    public string? AssignedUserId { get; set; }

    /// <summary>
    /// Dashboard users assigned to the work order. Only returned for organizations with multiple work order assignees enabled. Technicians backed only by a driver are not represented.
    /// </summary>
    [JsonPropertyName("assignees")]
    public IEnumerable<WorkOrderAssigneeObjectResponseBody>? Assignees { get; set; }

    /// <summary>
    /// Files attached to the work order.
    /// </summary>
    [JsonPropertyName("attachments")]
    public IEnumerable<WorkOrderAttachmentObjectResponseBody>? Attachments { get; set; }

    /// <summary>
    /// Custom fields (attributes) set on the work order. Returned by the work order endpoints when includeAttributes is true, and in work order webhook and stream payloads when work order attributes are enabled for the organization.
    /// </summary>
    [JsonPropertyName("attributes")]
    public IEnumerable<GoaAttributeTinyResponseBody>? Attributes { get; set; }

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
    /// The time the work order was completed in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("completedAtTime")]
    public DateTime? CompletedAtTime { get; set; }

    /// <summary>
    /// The time the work order was created in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required DateTime CreatedAtTime { get; set; }

    /// <summary>
    /// The ID of the creator of the work order. On create, integrations may optionally set this to attribute Created-by UI and creator notifications to a dashboard user; the activity log still records the API token owner as the create actor when that override is used.
    /// </summary>
    [JsonPropertyName("createdByUserId")]
    public string? CreatedByUserId { get; set; }

    /// <summary>
    /// A description of what needs to be fixed.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("discount")]
    public WorkOrderDiscountObjectResponseBody? Discount { get; set; }

    /// <summary>
    /// The due date of the work order in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("dueAtTime")]
    public DateTime? DueAtTime { get; set; }

    /// <summary>
    /// The engine hours at the time of the work order.
    /// </summary>
    [JsonPropertyName("engineHours")]
    public long? EngineHours { get; set; }

    /// <summary>
    /// Identifier for this work order in a third-party system, as set when the work order was imported (for example a Fleetio or Eptura work order ID). Returned by the work order endpoints when the request sets `includeExternalIds=true`, and in work order webhook payloads, when the work order has an external ID. Use it to match imported work orders to their source records, for example before attaching files with POST /maintenance/work-orders/attachments. Only returned for organizations with this field enabled.
    /// </summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

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
    public IEnumerable<WorkOrderItemObjectResponseBody>? Items { get; set; }

    [JsonPropertyName("maintenanceSite")]
    public WorkOrderMaintenanceSiteObjectResponseBody? MaintenanceSite { get; set; }

    /// <summary>
    /// The odometer reading at the time of the work order.
    /// </summary>
    [JsonPropertyName("odometerMeters")]
    public long? OdometerMeters { get; set; }

    /// <summary>
    /// The purchase order number for the work order.
    /// </summary>
    [JsonPropertyName("poNumber")]
    public string? PoNumber { get; set; }

    /// <summary>
    /// The priority of the work order  Valid values: `High`, `Low`, `Medium`, `Urgent`
    /// </summary>
    [JsonPropertyName("priority")]
    public WorkOrderWithTimeEntriesObjectResponseBodyPriority? Priority { get; set; }

    /// <summary>
    /// Service Tasks for the work order.
    /// </summary>
    [JsonPropertyName("serviceTaskInstances")]
    public IEnumerable<ServiceTaskInstanceWithTimeEntriesObjectResponseBody>? ServiceTaskInstances { get; set; }

    /// <summary>
    /// The time work started on the work order, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("startedAtTime")]
    public DateTime? StartedAtTime { get; set; }

    /// <summary>
    /// The status of the work order, including system-managed estimate workflow statuses.  Valid values: `Assigned`, `Awaiting estimate approval`, `Awaiting estimates`, `Cancelled`, `Closed`, `Completed`, `Estimate`, `Estimate approval denied`, `Estimate approved`, `Estimates ready`, `In Progress`, `Needs Vendor Selection`, `On Hold`, `Open`, `Pending Approval`, `Pending Parts`, `Planning`
    /// </summary>
    [JsonPropertyName("status")]
    public required WorkOrderWithTimeEntriesObjectResponseBodyStatus Status { get; set; }

    [JsonPropertyName("tax")]
    public WorkOrderTaxObjectResponseBody? Tax { get; set; }

    [JsonPropertyName("unallocatedLabor")]
    public WorkOrderUnallocatedLaborObjectResponseBody? UnallocatedLabor { get; set; }

    /// <summary>
    /// The time the work order was last updated in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required DateTime UpdatedAtTime { get; set; }

    /// <summary>
    /// The vendor UUID for the work order.
    /// </summary>
    [JsonPropertyName("vendorUuid")]
    public string? VendorUuid { get; set; }

    /// <summary>
    /// IDs of the work order template(s) this work order was created from. May include templates that have since been deleted.
    /// </summary>
    [JsonPropertyName("workOrderTemplateIds")]
    public IEnumerable<string>? WorkOrderTemplateIds { get; set; }

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
