using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Object with driver assignment information and associated driver and trailer information.
/// </summary>
public record GetDriverTrailerAssignmentsResponseBodyResponseBody
{
    /// <summary>
    /// Time when the driver trailer assignment was created, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public string? CreatedAtTime { get; set; }

    [JsonPropertyName("driver")]
    public required DriverWithExternalIdObjectResponseBody Driver { get; set; }

    /// <summary>
    /// Time when the driver trailer assignment will end, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>
    /// Samsara ID of the driver trailer assignment.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Time when the driver trailer assignment starts, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("startTime")]
    public required string StartTime { get; set; }

    [JsonPropertyName("trailer")]
    public required TrailerObjectResponseBody Trailer { get; set; }

    /// <summary>
    /// Time when the driver trailer assignment was last updated, in RFC 3339 format.
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
