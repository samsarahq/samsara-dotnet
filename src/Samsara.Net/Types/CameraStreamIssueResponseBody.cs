using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record CameraStreamIssueResponseBody
{
    [JsonPropertyName("cameraDevice")]
    public AlertObjectWorkforceCameraDeviceResponseBody? CameraDevice { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
