using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Maintenance.WorkOrders;

public record PostWorkOrdersRequestBody
{
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
    /// The category of the work order  Valid values: `Annual`, `Corrective`, `Damage Repair`, `Preventive`, `Recall`, `Unspecified`
    /// </summary>
    [JsonPropertyName("category")]
    public WorkOrdersPostWorkOrdersRequestBodyCategory? Category { get; set; }

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
    /// The priority of the work order  Valid values: `High`, `Low`, `Medium`, `Urgent`
    /// </summary>
    [JsonPropertyName("priority")]
    public WorkOrdersPostWorkOrdersRequestBodyPriority? Priority { get; set; }

    /// <summary>
    /// Service Tasks for the work order.
    /// </summary>
    [JsonPropertyName("serviceTaskInstances")]
    public IEnumerable<ServiceTaskInstanceInputObjectRequestBody>? ServiceTaskInstances { get; set; }

    [JsonPropertyName("tax")]
    public WorkOrderTaxObjectRequestBody? Tax { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
