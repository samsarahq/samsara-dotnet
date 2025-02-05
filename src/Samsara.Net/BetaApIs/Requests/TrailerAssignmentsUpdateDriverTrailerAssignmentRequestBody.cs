using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

public record TrailerAssignmentsUpdateDriverTrailerAssignmentRequestBody
{
    /// <summary>
    /// Samsara ID for the assignment.
    /// </summary>
    public required string Id { get; set; }

    /// <summary>
    /// The end time in RFC 3339 format. The end time should not be in the future
    /// </summary>
    public required string EndTime { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
