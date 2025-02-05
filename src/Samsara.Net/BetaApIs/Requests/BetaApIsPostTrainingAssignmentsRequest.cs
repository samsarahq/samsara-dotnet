using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

public record BetaApIsPostTrainingAssignmentsRequest
{
    /// <summary>
    /// String for the course ID.
    /// </summary>
    public required string CourseId { get; set; }

    /// <summary>
    /// Due date of the training assignment in RFC 3339 format. Millisecond precision and timezones are supported.
    /// </summary>
    public required string DueAtTime { get; set; }

    /// <summary>
    /// Optional string of comma separated learner IDs. If learner ID is present, training assignments for the specified learner(s) will be returned. Max value for this value is 100 objects. Example: `learnerIds=driver-281474,driver-46282156`
    /// </summary>
    public IEnumerable<string> LearnerIds { get; set; } = new List<string>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
