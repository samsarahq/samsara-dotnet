using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetTrainingAssignmentsStreamRequest
{
    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// A start time in RFC 3339 format. Defaults to now if not provided. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonIgnore]
    public required string StartTime { get; set; }

    /// <summary>
    /// An end time in RFC 3339 format. Defaults to now if not provided. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonIgnore]
    public string? EndTime { get; set; }

    /// <summary>
    /// Optional string of comma separated learner IDs. If learner ID is present, training assignments for the specified learner(s) will be returned. Max value for this value is 100 objects. Example: `learnerIds=driver-281474,driver-46282156`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> LearnerIds { get; set; } = new List<string>();

    /// <summary>
    /// Optional string of comma separated course IDs. If course ID is present, training assignments for the specified course ID(s) will be returned. Max value for this value is 100 objects. Defaults to returning all courses. Example: `courseIds=a4db8702-79d5-4396-a717-e301d52ecc11,c6490f6a-d84e-49b5-b0ad-b6baae304075`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> CourseIds { get; set; } = new List<string>();

    /// <summary>
    /// Optional string of comma separated values. If status is present, training assignments for the specified status(s) will be returned. Valid values: "notStarted", "inProgress", "completed". Defaults to returning all courses.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Status { get; set; } = new List<string>();

    /// <summary>
    /// Optional boolean value. If present, training assignments for the specified overdue status will be returned. Valid values: true, false. Defaults to returning all assignments.
    /// </summary>
    [JsonIgnore]
    public bool? IsOverdue { get; set; }

    /// <summary>
    /// Optional string of comma separated category IDs. If category ID is present, training assignments for the specified category ID(s) will be returned. Max value for this value is 100 objects. Example: `categoryIds=a4db8702-79d5-4396-a717-e301d52ecc11,c6490f6a-d84e-49b5-b0ad-b6baae304075`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> CategoryIds { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
