using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A snapshot of a reading value at a point in time.
/// </summary>
public record ReadingSnapshotResponseBody
{
    /// <summary>
    /// The ID of the entity this readings is for.
    /// </summary>
    [JsonPropertyName("entityId")]
    public required string EntityId { get; set; }

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// The time in RFC 3339 format when the reading was measured.
    /// </summary>
    [JsonPropertyName("happenedAtTime")]
    public string? HappenedAtTime { get; set; }

    /// <summary>
    /// The ID of the reading for which the data is being returned.
    /// </summary>
    [JsonPropertyName("readingId")]
    public required string ReadingId { get; set; }

    /// <summary>
    /// The value of the reading.
    /// </summary>
    [JsonPropertyName("value")]
    public object? Value { get; set; }

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
