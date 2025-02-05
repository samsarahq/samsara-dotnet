using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleDetectedResponseBody
{
    [JsonPropertyName("cameraStream")]
    public AlertObjectOnvifCameraStreamResponseBody? CameraStream { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
