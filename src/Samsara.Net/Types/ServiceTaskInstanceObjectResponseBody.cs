using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Work Order Service Task object.
/// </summary>
public record ServiceTaskInstanceObjectResponseBody
{
    /// <summary>
    /// ID of the service task instance.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("laborHourlyCost")]
    public WorkOrderMoneyObjectResponseBody? LaborHourlyCost { get; set; }

    /// <summary>
    /// The time of labor needed
    /// </summary>
    [JsonPropertyName("laborTimeMinutes")]
    public int? LaborTimeMinutes { get; set; }

    [JsonPropertyName("partsCost")]
    public WorkOrderMoneyObjectResponseBody? PartsCost { get; set; }

    /// <summary>
    /// ID of the service task.
    /// </summary>
    [JsonPropertyName("serviceTaskId")]
    public required string ServiceTaskId { get; set; }

    /// <summary>
    /// The status of the service task.  Valid values: `Unknown`, `Open`, `In Progress`, `On Hold`, `Completed`
    /// </summary>
    [JsonPropertyName("status")]
    public required ServiceTaskInstanceObjectResponseBodyStatus Status { get; set; }

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
