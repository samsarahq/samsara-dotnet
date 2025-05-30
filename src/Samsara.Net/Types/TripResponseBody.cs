using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Trip
/// </summary>
public record TripResponseBody
{
    [JsonPropertyName("asset")]
    public required TripAssetResponseBody Asset { get; set; }

    /// <summary>
    /// Trip completion status  Valid values: `inProgress`, `completed`
    /// </summary>
    [JsonPropertyName("completionStatus")]
    public required TripResponseBodyCompletionStatus CompletionStatus { get; set; }

    /// <summary>
    /// [RFC 3339] Time the trip was created in Samsara in UTC.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required string CreatedAtTime { get; set; }

    [JsonPropertyName("endLocation")]
    public LocationResponseResponseBody? EndLocation { get; set; }

    [JsonPropertyName("startLocation")]
    public required LocationResponseResponseBody StartLocation { get; set; }

    /// <summary>
    /// [RFC 3339] Time the trip ended in UTC.
    /// </summary>
    [JsonPropertyName("tripEndTime")]
    public string? TripEndTime { get; set; }

    /// <summary>
    /// [RFC 3339] Time the trip started in UTC.
    /// </summary>
    [JsonPropertyName("tripStartTime")]
    public required string TripStartTime { get; set; }

    /// <summary>
    /// [RFC 3339] Time the trip was updated in Samsara in UTC. Valid updates are when `endTime` populates or `completionStatus` changes values.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required string UpdatedAtTime { get; set; }

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
