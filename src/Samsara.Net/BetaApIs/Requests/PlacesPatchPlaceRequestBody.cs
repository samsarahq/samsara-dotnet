using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record PlacesPatchPlaceRequestBody
{
    /// <summary>
    /// Samsara place id to update (required). Do not send `externalId` in the same request.
    /// </summary>
    [JsonIgnore]
    public required long PlaceId { get; set; }

    /// <summary>
    /// External id token in `key:value` form (e.g. crmId:warehouse-east). Mutually exclusive with `placeId`. Batch lookup by external id is not implemented for this endpoint yet; callers should use `placeId` until supported.
    /// </summary>
    [JsonIgnore]
    public string? ExternalId { get; set; }

    /// <summary>
    /// Single-line address string.
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// When present, replaces external ids for the place.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public PlacesPatchPlaceRequestBodyExternalIds? ExternalIds { get; set; }

    /// <summary>
    /// Polygon vertices; at least three when switching to polygon mode.
    /// </summary>
    [JsonPropertyName("geofence")]
    public IEnumerable<GeofenceVertexInputRequestBody>? Geofence { get; set; }

    [JsonPropertyName("hubLocations")]
    public PatchPlaceHubLocationsBodyRequestBody? HubLocations { get; set; }

    /// <summary>
    /// Center latitude when switching to or editing a circle geofence.
    /// </summary>
    [JsonPropertyName("latitude")]
    public double? Latitude { get; set; }

    /// <summary>
    /// Center longitude when switching to or editing a circle geofence.
    /// </summary>
    [JsonPropertyName("longitude")]
    public double? Longitude { get; set; }

    /// <summary>
    /// Place name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("navigation")]
    public PostPlaceNavigationInputRequestBody? Navigation { get; set; }

    /// <summary>
    /// Notes.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// Unsupported on patch; when provided this API returns InvalidArgument.
    /// </summary>
    [JsonPropertyName("placeTypes")]
    public IEnumerable<string>? PlaceTypes { get; set; }

    /// <summary>
    /// Circle radius in meters; use with latitude and longitude.
    /// </summary>
    [JsonPropertyName("radiusMeters")]
    public long? RadiusMeters { get; set; }

    /// <summary>
    /// When present, replaces all tag associations for the place.
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<PostPlaceTagRefRequestBody>? Tags { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
