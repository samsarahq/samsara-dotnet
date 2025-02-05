using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TrainingAssignmentNearDueDateTriggerDetailsObjectResponseBody
{
    /// <summary>
    /// The assignment groups the trigger is configured for.
    /// </summary>
    [JsonPropertyName("assignmentGroups")]
    public IEnumerable<TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectResponseBody>? AssignmentGroups { get; set; }

    /// <summary>
    /// Whether the trigger is configured in days or weeks.  Valid values: `DAYS`, `WEEKS`
    /// </summary>
    [JsonPropertyName("conditionUnits")]
    public required TrainingAssignmentNearDueDateTriggerDetailsObjectResponseBodyConditionUnits ConditionUnits { get; set; }

    /// <summary>
    /// The number of days or weeks near the due date to trigger on.
    /// </summary>
    [JsonPropertyName("conditionValue")]
    public required long ConditionValue { get; set; }

    /// <summary>
    /// The timezone that the alert will be set up in.
    /// </summary>
    [JsonPropertyName("timezone")]
    public required string Timezone { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
