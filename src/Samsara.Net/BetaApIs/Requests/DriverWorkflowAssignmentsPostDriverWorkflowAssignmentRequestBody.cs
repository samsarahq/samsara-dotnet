using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record DriverWorkflowAssignmentsPostDriverWorkflowAssignmentRequestBody
{
    /// <summary>
    /// List of driver IDs to publish the workflow to. If a driver already has the workflow, the operation is a no-op for that driver.
    /// </summary>
    [JsonPropertyName("driverIdsToPublish")]
    public IEnumerable<string>? DriverIdsToPublish { get; set; }

    /// <summary>
    /// List of driver IDs to unpublish the workflow from. If a driver does not have the workflow, the operation is a no-op for that driver.
    /// </summary>
    [JsonPropertyName("driverIdsToUnpublish")]
    public IEnumerable<string>? DriverIdsToUnpublish { get; set; }

    /// <summary>
    /// The UUID of the workflow to publish.
    /// </summary>
    [JsonPropertyName("workflowId")]
    public required string WorkflowId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
