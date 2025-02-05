using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TrainingCoursesGetTrainingCoursesResponseBody
{
    /// <summary>
    /// List of training courses.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<TrainingCourseResponseObjectResponseBody> Data { get; set; } =
        new List<TrainingCourseResponseObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
