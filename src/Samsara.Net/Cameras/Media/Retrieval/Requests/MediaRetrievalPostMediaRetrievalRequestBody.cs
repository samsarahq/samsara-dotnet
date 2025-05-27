using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Cameras.Media.Retrieval;

public record MediaRetrievalPostMediaRetrievalRequestBody
{
    /// <summary>
    /// An end time in RFC 3339 format. If endTime is the same as startTime, an image will be captured at startTime. Must be 1 second or more after startTime and no more than 60 seconds after startTime (Examples: 2019-06-13T19:08:55Z, 2019-06-13T19:08:55.455Z, OR 2015-09-15T14:00:42-04:00).
    /// </summary>
    [JsonPropertyName("endTime")]
    public required string EndTime { get; set; }

    /// <summary>
    /// A list of desired camera inputs for which to capture media. Only media with valid inputs (e.g. device has that input stream and device was recording at the time) will be uploaded. An empty list is invalid.
    /// </summary>
    [JsonPropertyName("inputs")]
    public IEnumerable<MediaRetrievalPostMediaRetrievalRequestBodyInputsItem> Inputs { get; set; } =
        new List<MediaRetrievalPostMediaRetrievalRequestBodyInputsItem>();

    /// <summary>
    /// The desired media type. If a video is requested, endTime must be after startTime. If an image is requested, endTime must be the same as startTime. Must be one of: image, videoHighRes. Examples: image, videoHighRes.  Valid values: `image`, `videoHighRes`
    /// </summary>
    [JsonPropertyName("mediaType")]
    public required MediaRetrievalPostMediaRetrievalRequestBodyMediaType MediaType { get; set; }

    /// <summary>
    /// A start time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonPropertyName("startTime")]
    public required string StartTime { get; set; }

    /// <summary>
    /// Vehicle ID for which to initiate media capture. Examples: 1234
    /// </summary>
    [JsonPropertyName("vehicleId")]
    public required string VehicleId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
