using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
