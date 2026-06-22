using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Discriminated place geofence. GET returns circle, polygon, or unknown when stored geometry cannot be mapped.
/// </summary>
[Serializable]
public record PlaceGeofenceResponseResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("circle")]
    public PlaceGeofenceCircleResponseResponseBody? Circle { get; set; }

    [JsonPropertyName("polygon")]
    public PlaceGeofencePolygonResponseResponseBody? Polygon { get; set; }

    /// <summary>
    /// Geofence type: circle, polygon, or unknown.  Valid values: `circle`, `polygon`, `unknown`
    /// </summary>
    [JsonPropertyName("type")]
    public required PlaceGeofenceResponseResponseBodyType Type { get; set; }

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
