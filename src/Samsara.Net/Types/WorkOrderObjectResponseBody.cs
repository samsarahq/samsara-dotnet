using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A work order object.
/// </summary>
public record WorkOrderObjectResponseBody
{
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
    /// Files attached to the work order.
    /// </summary>
    [JsonPropertyName("attachments")]
    public IEnumerable<WorkOrderAttachmentObjectResponseBody>? Attachments { get; set; }

    /// <summary>
    /// The category of the work order  Valid values: `Annual`, `Corrective`, `Damage Repair`, `Preventive`, `Recall`, `Unspecified`
    /// </summary>
    [JsonPropertyName("category")]
    public WorkOrderObjectResponseBodyCategory? Category { get; set; }

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
    /// The ID of the creator of the work order.
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
    /// The unique id of the work order.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Items related to the work order.
    /// </summary>
    [JsonPropertyName("items")]
    public IEnumerable<WorkOrderItemObjectResponseBody>? Items { get; set; }

    /// <summary>
    /// The odometer reading at the time of the work order.
    /// </summary>
    [JsonPropertyName("odometerMeters")]
    public long? OdometerMeters { get; set; }

    /// <summary>
    /// The priority of the work order  Valid values: `High`, `Low`, `Medium`, `Urgent`
    /// </summary>
    [JsonPropertyName("priority")]
    public WorkOrderObjectResponseBodyPriority? Priority { get; set; }

    /// <summary>
    /// Service Tasks for the work order.
    /// </summary>
    [JsonPropertyName("serviceTaskInstances")]
    public IEnumerable<ServiceTaskInstanceObjectResponseBody>? ServiceTaskInstances { get; set; }

    /// <summary>
    /// The status of the work order  Valid values: `Assigned`, `Cancelled`, `Closed`, `Completed`, `In Progress`, `On Hold`, `Open`, `Pending Approval`, `Pending Parts`
    /// </summary>
    [JsonPropertyName("status")]
    public required WorkOrderObjectResponseBodyStatus Status { get; set; }

    [JsonPropertyName("tax")]
    public WorkOrderTaxObjectResponseBody? Tax { get; set; }

    /// <summary>
    /// The time the work order was last updated in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required DateTime UpdatedAtTime { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
