using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Discriminated geofence on write. Exactly one of circle or polygon must be set.
/// </summary>
[Serializable]
public record PlaceGeofenceInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("circle")]
    public PlaceGeofenceCircleInputRequestBody? Circle { get; set; }

    [JsonPropertyName("polygon")]
    public PlaceGeofencePolygonInputRequestBody? Polygon { get; set; }

    /// <summary>
    /// Geofence type: circle or polygon. When present, must match the populated branch.  Valid values: `circle`, `polygon`
    /// </summary>
    [JsonPropertyName("type")]
    public PlaceGeofenceInputRequestBodyType? Type { get; set; }

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
