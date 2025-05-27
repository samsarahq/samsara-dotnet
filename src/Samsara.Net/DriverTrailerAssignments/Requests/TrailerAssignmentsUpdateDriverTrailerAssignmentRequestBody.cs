using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.DriverTrailerAssignments;

public record TrailerAssignmentsUpdateDriverTrailerAssignmentRequestBody
{
    /// <summary>
    /// Samsara ID for the assignment.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// The end time in RFC 3339 format. The end time should not be in the future
    /// </summary>
    [JsonPropertyName("endTime")]
    public required string EndTime { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
