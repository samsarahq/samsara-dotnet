using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A place (geofence / location) in the organization.
/// </summary>
[Serializable]
public record PlaceResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Address string.
    /// </summary>
    [JsonPropertyName("address")]
    public required string Address { get; set; }

    /// <summary>
    /// Camera recording mode: inherit, fullRecording, driverPrivacy, completePrivacy, or unknown.
    /// </summary>
    [JsonPropertyName("cameraRecordingModeType")]
    public string? CameraRecordingModeType { get; set; }

    /// <summary>
    /// Created timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required DateTime CreatedAtTime { get; set; }

    /// <summary>
    /// External ids when includeExternalIds=true.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public PlaceResponseObjectResponseBodyExternalIds? ExternalIds { get; set; }

    [JsonPropertyName("geofence")]
    public required PlaceGeofenceResponseResponseBody Geofence { get; set; }

    /// <summary>
    /// Samsara place id.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// IFTA exemption labels.
    /// </summary>
    [JsonPropertyName("iftaExemptionTypes")]
    public IEnumerable<string>? IftaExemptionTypes { get; set; }

    /// <summary>
    /// Auto-dismiss rolled stops.
    /// </summary>
    [JsonPropertyName("isAutoDismissRolledStopsEnabled")]
    public bool? IsAutoDismissRolledStopsEnabled { get; set; }

    /// <summary>
    /// Show addresses inside geofence.
    /// </summary>
    [JsonPropertyName("isShowAddressesEnabled")]
    public bool? IsShowAddressesEnabled { get; set; }

    /// <summary>
    /// Place name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("navigation")]
    public PlaceNavigationResponseResponseBody? Navigation { get; set; }

    /// <summary>
    /// Notes.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// Assigned place types.
    /// </summary>
    [JsonPropertyName("placeTypes")]
    public IEnumerable<string>? PlaceTypes { get; set; }

    /// <summary>
    /// Route-planning rows when present.
    /// </summary>
    [JsonPropertyName("routing")]
    public IEnumerable<RoutingResponseResponseBody>? Routing { get; set; }

    /// <summary>
    /// Configured safety exclusions.
    /// </summary>
    [JsonPropertyName("safetyEventExclusions")]
    public IEnumerable<string>? SafetyEventExclusions { get; set; }

    [JsonPropertyName("streetView")]
    public PlaceStreetViewResponseResponseBody? StreetView { get; set; }

    /// <summary>
    /// Tags when includeTags=true.
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<PlaceTagResponseResponseBody>? Tags { get; set; }

    /// <summary>
    /// Updated timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required DateTime UpdatedAtTime { get; set; }

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
