using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AccessoryResponseObjectResponseBody
{
    /// <summary>
    /// Product model name of the device
    /// </summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>
    /// The serial number of the accessory device.
    /// </summary>
    [JsonPropertyName("serial")]
    public string? Serial { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
