using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Response after successfully updating a Driver Trailer Assignment
/// </summary>
public record PatchDriverTrailerAssignmentsResponseBodyResponseBody
{
    /// <summary>
    /// Time when the driver trailer assignment was created, in RFC 3339 format
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public string? CreatedAtTime { get; set; }

    /// <summary>
    /// Samsara ID for the driver that this assignment is for.
    /// </summary>
    [JsonPropertyName("driverId")]
    public required string DriverId { get; set; }

    /// <summary>
    /// Time when the driver trailer assignment ends, in RFC 3339 format
    /// </summary>
    [JsonPropertyName("endTime")]
    public required string EndTime { get; set; }

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
    public string? UpdatedAtTime { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
