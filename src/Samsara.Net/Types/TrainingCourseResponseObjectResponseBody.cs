using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Training Course response object.
/// </summary>
public record TrainingCourseResponseObjectResponseBody
{
    [JsonPropertyName("category")]
    public required TrainingCategoryObjectResponseBody Category { get; set; }

    /// <summary>
    /// Description of the course.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Estimated time it takes to complete the course.
    /// </summary>
    [JsonPropertyName("estimatedTimeToCompleteMinutes")]
    public required long EstimatedTimeToCompleteMinutes { get; set; }

    /// <summary>
    /// ID of the training course.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("label")]
    public TrainingCourseLabelObjectResponseBody? Label { get; set; }

    /// <summary>
    /// ID of the course's specific version.
    /// </summary>
    [JsonPropertyName("revisionId")]
    public required string RevisionId { get; set; }

    /// <summary>
    /// Status of the training course. Always returned.
    /// Note: Only courses in a ‘published’ state are assignable to learners. Archiving a course deletes only ‘inProgress’ assignments associated with that course, and deleting a course deletes all assignments associated with that course.  Valid values: `published`, `deleted`, `archived`, `unknown`
    /// </summary>
    [JsonPropertyName("status")]
    public required TrainingCourseResponseObjectResponseBodyStatus Status { get; set; }

    /// <summary>
    /// Title of the course.
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }

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
