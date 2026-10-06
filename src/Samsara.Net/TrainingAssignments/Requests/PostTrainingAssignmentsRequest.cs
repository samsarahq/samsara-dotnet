using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.TrainingAssignments;

[Serializable]
public record PostTrainingAssignmentsRequest
{
    /// <summary>
    /// String for the course ID.
    /// </summary>
    [JsonIgnore]
    public required string CourseId { get; set; }

    /// <summary>
    /// Due date of the training assignment in RFC 3339 format. Millisecond precision and timezones are supported.
    /// </summary>
    [JsonIgnore]
    public required string DueAtTime { get; set; }

    /// <summary>
    /// String of comma separated learner IDs using the format `driver-&lt;id&gt;` or `user-&lt;id&gt;`. Training assignments for the specified course ID and learner(s) will be created. Max value for this value is 100 objects. Example: `learnerIds=driver-281474,user-46282156`. Non-driver user learners are available only for organizations with non-driver training enabled. Contact your Samsara representative to request access.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> LearnerIds { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
