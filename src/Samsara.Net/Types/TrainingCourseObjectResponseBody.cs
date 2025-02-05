using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TrainingCourseObjectResponseBody
{
    /// <summary>
    /// ID of the course.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// ID of the course's specific version.
    /// </summary>
    [JsonPropertyName("revisionId")]
    public required string RevisionId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
