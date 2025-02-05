using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record PostDriverTrailerAssignmentsResponseBodyResponseBody
{
    /// <summary>
    /// Time when the driver trailer assignment was created, in RFC 3339 format
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required string CreatedAtTime { get; set; }

    /// <summary>
    /// Samsara ID for the driver that this assignment is for.
    /// </summary>
    [JsonPropertyName("driverId")]
    public required string DriverId { get; set; }

    /// <summary>
    /// Samsara ID for the assignment.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Time when the driver trailer assignment starts, in RFC 3339 format
    /// </summary>
    [JsonPropertyName("startTime")]
    public required string StartTime { get; set; }

    /// <summary>
    /// Samsara ID of the trailer
    /// </summary>
    [JsonPropertyName("trailerId")]
    public required string TrailerId { get; set; }

    /// <summary>
    /// Time when the driver trailer assignment was last updated, in RFC 3339 format
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required string UpdatedAtTime { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
