using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record UploadedMediaObjectResponseBody
{
    /// <summary>
    /// Timestamp, in RFC 3339 format, at which the media item was made available. Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00
    /// </summary>
    [JsonPropertyName("availableAtTime")]
    public required string AvailableAtTime { get; set; }

    /// <summary>
    /// An end time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonPropertyName("endTime")]
    public required string EndTime { get; set; }

    /// <summary>
    /// Input type for this media. Examples: dashcamForwardFacing  Valid values: `dashcamForwardFacing`, `dashcamInwardFacing`, `dashcamRearFacing`
    /// </summary>
    [JsonPropertyName("input")]
    public required UploadedMediaObjectResponseBodyInput Input { get; set; }

    /// <summary>
    /// Type of media. Examples: image  Valid values: `image`
    /// </summary>
    [JsonPropertyName("mediaType")]
    public string MediaType { get; set; } = "image";

    /// <summary>
    /// A start time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonPropertyName("startTime")]
    public required string StartTime { get; set; }

    /// <summary>
    /// Trigger reason for this media capture. Examples: api  Valid values: `api`, `panicButton`, `periodicStill`, `tripEndStill`, `tripStartStill`, `videoRetrieval`
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
