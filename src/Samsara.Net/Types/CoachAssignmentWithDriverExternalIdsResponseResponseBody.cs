using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Driver coach assignment object.
/// </summary>
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
