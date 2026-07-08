using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record PlacesPatchPlaceRequestBody
{
    /// <summary>
    /// Samsara place id to update. Mutually exclusive with `externalId`; provide exactly one.
    /// </summary>
    [JsonIgnore]
    public long? PlaceId { get; set; }

    /// <summary>
    /// External id token in `key:value` form (e.g. crmId:warehouse-east). Mutually exclusive with `placeId`; provide exactly one.
    /// </summary>
    [JsonIgnore]
    public string? ExternalId { get; set; }

    /// <summary>
    /// Single-line address string.
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("businessContacts")]
    public PostPlaceBusinessContactsInputRequestBody? BusinessContacts { get; set; }

    /// <summary>
    /// Camera recording mode: fullRecording, driverPrivacy, completePrivacy, or inherit.  Valid values: `fullRecording`, `driverPrivacy`, `completePrivacy`, `inherit`, `unknown`, `unspecified`
    /// </summary>
    [JsonPropertyName("cameraRecordingModeType")]
    public PlacesPatchPlaceRequestBodyCameraRecordingModeType? CameraRecordingModeType { get; set; }

    /// <summary>
    /// When present, replaces external ids for the place.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public PlacesPatchPlaceRequestBodyExternalIds? ExternalIds { get; set; }

    [JsonPropertyName("geofence")]
    public PlaceGeofenceInputRequestBody? Geofence { get; set; }

    /// <summary>
    /// When present, replaces IFTA exemption types for the place.
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
    public string? Name { get; set; }

    [JsonPropertyName("navigation")]
    public PostPlaceNavigationInputRequestBody? Navigation { get; set; }

    /// <summary>
    /// Notes.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// When present, replaces address-type categories via address metadata. Metadata-derived types (hubLocation, navigation, iftaExemption) must match routing, navigation, and IFTA metadata after this request; conflicting combinations return InvalidArgument.
    /// </summary>
    [JsonPropertyName("placeTypes")]
    public IEnumerable<string>? PlaceTypes { get; set; }

    [JsonPropertyName("routing")]
    public PlaceRoutingPatchInputRequestBody? Routing { get; set; }

    /// <summary>
    /// When present, replaces safety event exclusions for the place.
    /// </summary>
    [JsonPropertyName("safetyEventExclusions")]
    public IEnumerable<string>? SafetyEventExclusions { get; set; }

    [JsonPropertyName("streetView")]
    public PlaceStreetViewInputRequestBody? StreetView { get; set; }

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
