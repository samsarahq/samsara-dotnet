using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Vertex of a polygon geofence.
/// </summary>
[Serializable]
public record PlaceGeofenceVertexResponseResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Latitude in decimal degrees.
    /// </summary>
    [JsonPropertyName("latitude")]
    public required double Latitude { get; set; }

    /// <summary>
    /// Longitude in decimal degrees.
    /// </summary>
    [JsonPropertyName("longitude")]
    public required double Longitude { get; set; }

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
