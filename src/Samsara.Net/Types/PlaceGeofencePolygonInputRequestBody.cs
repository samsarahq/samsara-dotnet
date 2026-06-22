using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Polygon geofence on write.
/// </summary>
[Serializable]
public record PlaceGeofencePolygonInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Polygon vertices; at least three.
    /// </summary>
    [JsonPropertyName("vertices")]
    public IEnumerable<GeofenceVertexInputRequestBody> Vertices { get; set; } =
        new List<GeofenceVertexInputRequestBody>();

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
