using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VisionCamerasResponseItem
{
    [JsonPropertyName("cameraId")]
    public long? CameraId { get; set; }

    [JsonPropertyName("cameraName")]
    public string? CameraName { get; set; }

    [JsonPropertyName("ethernetIp")]
    public string? EthernetIp { get; set; }

    [JsonPropertyName("wifiIp")]
    public string? WifiIp { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
