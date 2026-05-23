using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record PlacesPostPlaceRequestBody
{
    /// <summary>
    /// Single-line address string.
    /// </summary>
    [JsonPropertyName("address")]
    public required string Address { get; set; }

    /// <summary>
    /// Camera recording mode: fullRecording, driverPrivacy, completePrivacy, or inherit.  Valid values: `fullRecording`, `driverPrivacy`, `completePrivacy`, `inherit`, `unknown`, `unspecified`
    /// </summary>
    [JsonPropertyName("cameraRecordingModeType")]
    public PlacesPostPlaceRequestBodyCameraRecordingModeType? CameraRecordingModeType { get; set; }

    /// <summary>
    /// External identifiers.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public PlacesPostPlaceRequestBodyExternalIds? ExternalIds { get; set; }

    /// <summary>
    /// Polygon vertices; at least three when using polygon mode (omit entirely when using latitude, longitude, and radiusMeters for a circle).
    /// </summary>
    [JsonPropertyName("geofence")]
    public IEnumerable<GeofenceVertexInputRequestBody>? Geofence { get; set; }

    /// <summary>
    /// Initial route-planning hub rows for the new place. Each entry requires hubId. Omit hubLocationId to let the server assign a row UUID, or set hubLocationId to pin the UUID for idempotent creates.
    /// </summary>
    [JsonPropertyName("hubLocations")]
    public IEnumerable<PatchPlaceHubLocationUpsertBodyRequestBody>? HubLocations { get; set; }

    /// <summary>
    /// IFTA exemption types for this place.
    /// </summary>
    [JsonPropertyName("iftaExemptionTypes")]
    public IEnumerable<string>? IftaExemptionTypes { get; set; }

    /// <summary>
    /// Center latitude when using a circle geofence with radiusMeters.
    /// </summary>
    [JsonPropertyName("latitude")]
    public double? Latitude { get; set; }

    /// <summary>
    /// Center longitude when using a circle geofence with radiusMeters.
    /// </summary>
    [JsonPropertyName("longitude")]
    public double? Longitude { get; set; }

    /// <summary>
    /// Place name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("navigation")]
    public PostPlaceNavigationInputRequestBody? Navigation { get; set; }

    /// <summary>
    /// Optional notes.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// Unsupported on create; when provided this API returns InvalidArgument.
    /// </summary>
    [JsonPropertyName("placeTypes")]
    public IEnumerable<string>? PlaceTypes { get; set; }

    /// <summary>
    /// Circle radius in meters; requires latitude and longitude. Must be at least 1 when set.
    /// </summary>
    [JsonPropertyName("radiusMeters")]
    public long? RadiusMeters { get; set; }

    /// <summary>
    /// Safety event types excluded at this place.
    /// </summary>
    [JsonPropertyName("safetyEventExclusions")]
    public IEnumerable<string>? SafetyEventExclusions { get; set; }

    [JsonPropertyName("streetView")]
    public PlaceStreetViewResponseRequestBody? StreetView { get; set; }

    /// <summary>
    /// Tags to associate.
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<PostPlaceTagRefRequestBody>? Tags { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
