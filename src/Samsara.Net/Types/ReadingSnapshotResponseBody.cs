using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A snapshot of a reading value at a point in time.
/// </summary>
[Serializable]
public record ReadingSnapshotResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
    public Dictionary<string, object?>? Value { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
