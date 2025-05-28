using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to Training Assignment Near Due Date
/// </summary>
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
