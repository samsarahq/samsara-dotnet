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

    [JsonPropertyName("geofence")]
    public required PlaceGeofenceInputRequestBody Geofence { get; set; }

    /// <summary>
    /// IFTA exemption types for this place.
    /// </summary>
    [JsonPropertyName("iftaExemptionTypes")]
    public IEnumerable<string>? IftaExemptionTypes { get; set; }

    /// <summary>
    /// When true, show addresses inside the geofence on the map.
    /// </summary>
    [JsonPropertyName("isShowAddressesEnabled")]
    public bool? IsShowAddressesEnabled { get; set; }

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
    /// When present, replaces address-type categories via address metadata. Metadata-derived types (hubLocation, navigation, iftaExemption) must match routing, navigation, and existing IFTA metadata in the same request; conflicting combinations return InvalidArgument.
    /// </summary>
    [JsonPropertyName("placeTypes")]
    public IEnumerable<string>? PlaceTypes { get; set; }

    /// <summary>
    /// Initial route-planning rows for the new place. Each entry requires hubId; (placeId, hubId) must be unique.
    /// </summary>
    [JsonPropertyName("routing")]
    public IEnumerable<PlaceRoutingInputRequestBody>? Routing { get; set; }

    /// <summary>
    /// Safety event types excluded at this place.
    /// </summary>
    [JsonPropertyName("safetyEventExclusions")]
    public IEnumerable<string>? SafetyEventExclusions { get; set; }

    [JsonPropertyName("streetView")]
    public PlaceStreetViewInputRequestBody? StreetView { get; set; }

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
