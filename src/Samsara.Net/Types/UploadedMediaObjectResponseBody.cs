using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record UploadedMediaObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Timestamp, in RFC 3339 format, at which the media item was made available. Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00
    /// </summary>
    [JsonPropertyName("availableAtTime")]
    public required string AvailableAtTime { get; set; }

    /// <summary>
    /// Camera role for this media.  Valid values: `leftMirrorMount`, `leftSide`, `rightMirrorMount`, `rightSide`, `rearHigh`, `rearBumper`, `inCab`, `front`, `hopper`, `other1`, `other2`, `other3`, `other4`, `leftBev`, `rightBev`, `rearBev`, `frontBev`, `otherBev`, `bevNotUsed`
    /// </summary>
    [JsonPropertyName("cameraRole")]
    public UploadedMediaObjectResponseBodyCameraRole? CameraRole { get; set; }

    /// <summary>
    /// An end time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonPropertyName("endTime")]
    public required string EndTime { get; set; }

    /// <summary>
    /// Input type for this media.  Valid values: `dashcamForwardFacing`, `dashcamInwardFacing`, `analog1`, `analog2`, `analog3`, `analog4`
    /// </summary>
    [JsonPropertyName("input")]
    public required UploadedMediaObjectResponseBodyInput Input { get; set; }

    /// <summary>
    /// Type of media.  Valid values: `image`, `video`
    /// </summary>
    [JsonPropertyName("mediaType")]
    public required UploadedMediaObjectResponseBodyMediaType MediaType { get; set; }

    /// <summary>
    /// A start time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonPropertyName("startTime")]
    public required string StartTime { get; set; }

    /// <summary>
    /// Trigger reason for this media capture.  Valid values: `api`, `panicButton`, `periodicStill`, `rfidEvent`, `safetyEvent`, `tripEndStill`, `tripStartStill`, `videoRetrieval`
    /// </summary>
    [JsonPropertyName("triggerReason")]
    public required UploadedMediaObjectResponseBodyTriggerReason TriggerReason { get; set; }

    [JsonPropertyName("urlInfo")]
    public UrlInfoObjectResponseBody? UrlInfo { get; set; }

    /// <summary>
    /// Vehicle ID for which this media was captured. Examples: 1234
    /// </summary>
    [JsonPropertyName("vehicleId")]
    public required string VehicleId { get; set; }

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
