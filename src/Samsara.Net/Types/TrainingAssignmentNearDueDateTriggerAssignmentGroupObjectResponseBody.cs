using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// An assignment group of a specific course or a category can be selected for an alert.
/// </summary>
[Serializable]
public record TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectResponseBody
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
