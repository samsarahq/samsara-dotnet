using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Auto-geofence settings on write. Server geocodes from top-level address when seed coordinates are omitted, then suggests and persists resolved geometry.
/// </summary>
[Serializable]
public record PlaceGeofenceAutoInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("fallbackBehavior")]
    public PlaceGeofenceAutoFallbackBehaviorInputRequestBody? FallbackBehavior { get; set; }

    /// <summary>
    /// When true, replace the request name with the winning suggestion name when non-empty.
    /// </summary>
    [JsonPropertyName("isSuggestedNameEnabled")]
    public bool? IsSuggestedNameEnabled { get; set; }

    /// <summary>
    /// When true and both top-level address and seed coordinates are present, geocode the address and reject the request when the result does not correlate with the seed.
    /// </summary>
    [JsonPropertyName("isValidateAddressEnabled")]
    public bool? IsValidateAddressEnabled { get; set; }

    /// <summary>
    /// Seed latitude in WGS84 decimal degrees. Omit to geocode from top-level address.
    /// </summary>
    [JsonPropertyName("latitude")]
    public double? Latitude { get; set; }

    /// <summary>
    /// Seed longitude in WGS84 decimal degrees. Omit to geocode from top-level address.
    /// </summary>
    [JsonPropertyName("longitude")]
    public double? Longitude { get; set; }

    /// <summary>
    /// Drop candidates with area above this value in square meters.
    /// </summary>
    [JsonPropertyName("maxAreaSquareMeters")]
    public double? MaxAreaSquareMeters { get; set; }

    /// <summary>
    /// Drop candidates whose source polygon exceeds this vertex count before simplification.
    /// </summary>
    [JsonPropertyName("maxSourceVertices")]
    public long? MaxSourceVertices { get; set; }

    /// <summary>
    /// Simplify the selected polygon to at most this many vertices before persist.
    /// </summary>
    [JsonPropertyName("maxVertices")]
    public long? MaxVertices { get; set; }

    [JsonPropertyName("searchBounds")]
    public PlaceGeofenceAutoSearchBoundsInputRequestBody? SearchBounds { get; set; }

    /// <summary>
    /// Candidate sort order within each type tier.  Valid values: `smallestFirst`, `largestFirst`
    /// </summary>
    [JsonPropertyName("sizeOrder")]
    public PlaceGeofenceAutoInputRequestBodySizeOrder? SizeOrder { get; set; }

    /// <summary>
    /// Candidate types in priority order. Defaults to building, parcel, landUse, boundary.
    /// </summary>
    [JsonPropertyName("suggestionTypes")]
    public IEnumerable<PlaceGeofenceAutoInputRequestBodySuggestionTypesItem>? SuggestionTypes { get; set; }

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
