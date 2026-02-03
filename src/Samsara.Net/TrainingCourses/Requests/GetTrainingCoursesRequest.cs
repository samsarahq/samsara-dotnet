using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.TrainingCourses;

[Serializable]
public record GetTrainingCoursesRequest
{
    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// Optional string of comma separated course IDs. If course ID is present, training assignments for the specified course ID(s) will be returned. Max value for this value is 100 objects. Defaults to returning all courses. Example: `courseIds=a4db8702-79d5-4396-a717-e301d52ecc11,c6490f6a-d84e-49b5-b0ad-b6baae304075`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> CourseIds { get; set; } = new List<string>();

    /// <summary>
    /// Optional string of comma separated course category IDs. If courseCategoryId is present, training courses for the specified course category(s) will be returned. Max value for this value is 100 objects. Defaults to returning all courses.  Example: `categoryIds=a4db8702-79d5-4396-a717-e301d52ecc11,c6490f6a-d84e-49b5-b0ad-b6baae304075`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> CategoryIds { get; set; } = new List<string>();

    /// <summary>
    /// Optional string of comma separated values. If status is present, training courses with the specified status(s) will be returned. Valid values: “published”, “deleted”, “archived”. Defaults to returning all courses.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Status { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
