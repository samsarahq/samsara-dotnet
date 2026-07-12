using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Optional search bounds for geofence suggestion lookup.
/// </summary>
[Serializable]
public record PlaceGeofenceAutoSearchBoundsInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Maximum latitude in WGS84 decimal degrees.
    /// </summary>
    [JsonPropertyName("maxLatitude")]
    public required double MaxLatitude { get; set; }

    /// <summary>
    /// Maximum longitude in WGS84 decimal degrees.
    /// </summary>
    [JsonPropertyName("maxLongitude")]
    public required double MaxLongitude { get; set; }

    /// <summary>
    /// Minimum latitude in WGS84 decimal degrees.
    /// </summary>
    [JsonPropertyName("minLatitude")]
    public required double MinLatitude { get; set; }

    /// <summary>
    /// Minimum longitude in WGS84 decimal degrees.
    /// </summary>
    [JsonPropertyName("minLongitude")]
    public required double MinLongitude { get; set; }

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
