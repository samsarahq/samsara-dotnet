using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A single reading data point to be created.
/// </summary>
[Serializable]
public record ReadingDatapointRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Samsara entity ID. In case of an asset, it’s the assetId. If the asset is not yet present in the system, it is required to create a new one via the /assets endpoint.
    /// </summary>
    [JsonPropertyName("entityId")]
    public required string EntityId { get; set; }

    /// <summary>
    /// The type of the entity (e.g., asset).  Valid values: `asset`
    /// </summary>
    [JsonPropertyName("entityType")]
    public required ReadingDatapointRequestBodyEntityType EntityType { get; set; }

    /// <summary>
    /// The timestamp of when the reading happened in RFC 3339 format. happenedAtTime must not be older than the last known reading for the same series.
    /// </summary>
    [JsonPropertyName("happenedAtTime")]
    public required string HappenedAtTime { get; set; }

    /// <summary>
    /// The ID of the reading, you can get it from the /readings/definitions endpoint.
    /// </summary>
    [JsonPropertyName("readingId")]
    public required string ReadingId { get; set; }

    /// <summary>
    /// The value of the reading. Can be any object. See the /readings/definitions endpoint for the value type for each reading.
    /// </summary>
    [JsonPropertyName("value")]
    public Dictionary<string, object?> Value { get; set; } = new Dictionary<string, object?>();

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
