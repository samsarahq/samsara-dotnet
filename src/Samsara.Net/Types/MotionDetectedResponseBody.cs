using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record MotionDetectedResponseBody
{
    [JsonPropertyName("cameraStream")]
    public AlertObjectOnvifCameraStreamResponseBody? CameraStream { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
