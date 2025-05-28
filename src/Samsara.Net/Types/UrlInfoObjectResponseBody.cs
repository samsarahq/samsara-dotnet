using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// URL info for this piece of media. This field is only populated when the 'status' response field is 'available'
/// </summary>
public record UrlInfoObjectResponseBody
{
    /// <summary>
    /// Signed URL for this piece of media. The URL expires in 8 hours (after which you must make another GET request). Examples: https://sample.s3.url.com/image.jpeg
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    /// <summary>
    /// Timestamp, in RFC 3339 format, at which the URL expires. Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00
    /// </summary>
    [JsonPropertyName("urlExpiryTime")]
    public required string UrlExpiryTime { get; set; }

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
