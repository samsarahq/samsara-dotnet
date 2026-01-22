using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The geofence that defines this address and its bounds. This can either be a circle or a polygon, but not both.
/// </summary>
[Serializable]
public record UpdateAddressRequestGeofence : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("circle")]
    public AddressGeofenceCircle? Circle { get; set; }

    [JsonPropertyName("polygon")]
    public AddressGeofencePolygon? Polygon { get; set; }

    [JsonPropertyName("settings")]
    public AddressGeofenceSettings? Settings { get; set; }

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
