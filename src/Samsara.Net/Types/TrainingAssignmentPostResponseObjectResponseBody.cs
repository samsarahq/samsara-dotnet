using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Training Assignment response object.
/// </summary>
public record TrainingAssignmentPostResponseObjectResponseBody
{
    [JsonPropertyName("course")]
    public required TrainingCourseObjectResponseBody Course { get; set; }

    /// <summary>
    /// Creation time of the training assignment. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required DateTime CreatedAtTime { get; set; }

    /// <summary>
    /// ID of the user who created the training assignment.
    /// </summary>
    [JsonPropertyName("createdById")]
    public required string CreatedById { get; set; }

    /// <summary>
    /// Time training assignment is due. UTC timestamp in RFC 3339 format. Returned when an assignment has a due date set by an admin.
    /// </summary>
    [JsonPropertyName("dueAtTime")]
    public DateTime? DueAtTime { get; set; }

    /// <summary>
    /// ID of the training assignment.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Indicates whether the training assignment was already created.
    /// </summary>
    [JsonPropertyName("isExistingAssignment")]
    public required bool IsExistingAssignment { get; set; }

    [JsonPropertyName("learner")]
    public required TrainingLearnerObjectResponseBody Learner { get; set; }

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
