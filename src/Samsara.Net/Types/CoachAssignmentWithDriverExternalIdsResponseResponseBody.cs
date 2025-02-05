using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record CoachAssignmentWithDriverExternalIdsResponseResponseBody
{
    /// <summary>
    /// Coach ID associated with coach assignment. Always returned.
    /// </summary>
    [JsonPropertyName("coachId")]
    public required string CoachId { get; set; }

    /// <summary>
    /// Time coach assignment was created in UTC. Always returned.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required DateTime CreatedAtTime { get; set; }

    [JsonPropertyName("driver")]
    public required DriverWithExternalIdObjectResponseBody Driver { get; set; }

    /// <summary>
    /// Time coaching assignment was updated in UTC. Always returned.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required DateTime UpdatedAtTime { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
