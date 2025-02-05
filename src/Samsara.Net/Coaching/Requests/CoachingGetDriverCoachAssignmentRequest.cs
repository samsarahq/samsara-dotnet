using Samsara.Net.Core;

namespace Samsara.Net.Coaching;

public record CoachingGetDriverCoachAssignmentRequest
{
    /// <summary>
    /// Optional string of comma separated IDs of the drivers. This can be either a unique Samsara driver ID or an external ID for the driver.
    /// </summary>
    public IEnumerable<string> DriverIds { get; set; } = new List<string>();

    /// <summary>
    /// Optional string of comma separated IDs of the coaches.
    /// </summary>
    public IEnumerable<string> CoachIds { get; set; } = new List<string>();

    /// <summary>
    /// Optional boolean indicating whether to return external IDs on supported entities
    /// </summary>
    public bool? IncludeExternalIds { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    public string? After { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
