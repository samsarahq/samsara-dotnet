using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Training Assignment response object.
/// </summary>
public record TrainingAssignmentResponseObjectResponseBody
{
    /// <summary>
    /// Time training assignment is completed. UTC timestamp in RFC 3339 format. Returned when a training assignment completion status is "complete".
    /// </summary>
    [JsonPropertyName("completedAtTime")]
    public DateTime? CompletedAtTime { get; set; }

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
    /// Time training assignment is deleted. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("deletedAtTime")]
    public DateTime? DeletedAtTime { get; set; }

    /// <summary>
    /// Time training assignment is due. UTC timestamp in RFC 3339 format. Returned when an assignment has a due date set by an admin.
    /// </summary>
    [JsonPropertyName("dueAtTime")]
    public DateTime? DueAtTime { get; set; }

    /// <summary>
    /// Time spent on the training assignment.
    /// </summary>
    [JsonPropertyName("durationMinutes")]
    public required long DurationMinutes { get; set; }

    /// <summary>
    /// ID of the training assignment.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Indicates whether the training assignment was completed on time or not. Returned when a training assignment completion status is "complete" and has a dueAtTime set by an admin.
    /// </summary>
    [JsonPropertyName("isCompletedLate")]
    public bool? IsCompletedLate { get; set; }

    /// <summary>
    /// Indicates whether the training assignment is past the due date. Returned when a training assignment completion status is 'inProgress' or 'notStarted' and has a dueAtTime set by an admin.
    /// </summary>
    [JsonPropertyName("isOverdue")]
    public bool? IsOverdue { get; set; }

    [JsonPropertyName("learner")]
    public required TrainingLearnerObjectResponseBody Learner { get; set; }

    /// <summary>
    /// Quiz score associated with training assignment. Returned when a training assignment completion status is "complete".
    /// </summary>
    [JsonPropertyName("scorePercent")]
    public double? ScorePercent { get; set; }

    /// <summary>
    /// Time training assignment is started. UTC timestamp in RFC 3339 format. Returned when a training assignment completion status is "complete" or "inProgress".
    /// </summary>
    [JsonPropertyName("startedAtTime")]
    public DateTime? StartedAtTime { get; set; }

    /// <summary>
    /// State for the Training Assignment. Always returned.  Valid values: `notStarted`, `inProgress`, `completed`
    /// </summary>
    [JsonPropertyName("status")]
    public required TrainingAssignmentResponseObjectResponseBodyStatus Status { get; set; }

    /// <summary>
    /// Time training assignment was updated by either a learner or an admin. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required DateTime UpdatedAtTime { get; set; }

    /// <summary>
    /// ID of the user who updated the training assignment, either an admin or a learner.
    /// </summary>
    [JsonPropertyName("updatedById")]
    public required string UpdatedById { get; set; }

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
