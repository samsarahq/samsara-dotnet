using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A geofence suggestion candidate.
/// </summary>
[Serializable]
public record PlaceGeofenceSuggestionCandidateResponseResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Candidate area in square meters.
    /// </summary>
    [JsonPropertyName("areaSquareMeters")]
    public required double AreaSquareMeters { get; set; }

    [JsonPropertyName("geofence")]
    public required PlaceGeofenceResponseResponseBody Geofence { get; set; }

    /// <summary>
    /// Candidate name from map data when available.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Candidate category from map data.  Valid values: `building`, `parcel`, `landUse`, `boundary`, `facility`, `infrastructure`, `unknown`
    /// </summary>
    [JsonPropertyName("type")]
    public required PlaceGeofenceSuggestionCandidateResponseResponseBodyType Type { get; set; }

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
