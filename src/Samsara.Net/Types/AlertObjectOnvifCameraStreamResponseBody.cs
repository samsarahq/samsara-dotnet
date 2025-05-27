using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A camera stream associated with the alert.
/// </summary>
public record AlertObjectOnvifCameraStreamResponseBody
{
    [JsonPropertyName("cameraDevice")]
    public AlertObjectWorkforceCameraDeviceResponseBody? CameraDevice { get; set; }

    /// <summary>
    /// The ID of the camera stream associated with the alert.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The name of the camera stream.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The list of [tags](https://kb.samsara.com/hc/en-us/articles/360026674631-Using-Tags-and-Tag-Nesting) associated with the camera stream.
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<GoaTagTinyResponseResponseBody>? Tags { get; set; }

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
