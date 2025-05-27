using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// An assignment group of a specific course or a category can be selected for an alert.
/// </summary>
public record TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectResponseBody
{
    /// <summary>
    /// Assignment group type.  Valid values: `CATEGORY`, `COURSE`
    /// </summary>
    [JsonPropertyName("assignmentGroupType")]
    public required TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectResponseBodyAssignmentGroupType AssignmentGroupType { get; set; }

    /// <summary>
    /// The unique ID of the assignment group.
    /// </summary>
    [JsonPropertyName("assignmentGroupUuid")]
    public required string AssignmentGroupUuid { get; set; }

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
