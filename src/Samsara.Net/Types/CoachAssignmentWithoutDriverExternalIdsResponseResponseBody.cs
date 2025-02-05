using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record CoachAssignmentWithoutDriverExternalIdsResponseResponseBody
{
    /// <summary>
    /// Coach ID associated with coach assignment. Optional. Will be empty if no driver coach is assigned
    /// </summary>
    [JsonPropertyName("coachId")]
    public string? CoachId { get; set; }

    /// <summary>
    /// Time coach assignment was created in UTC. Always returned.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required DateTime CreatedAtTime { get; set; }

    /// <summary>
    /// Unique user ID for the driver of the driver coach assignment
    /// </summary>
    [JsonPropertyName("driverId")]
    public required string DriverId { get; set; }

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
