using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FleetDeviceObjectResponseBody
{
    /// <summary>
    /// Id of the device
    /// </summary>
    [JsonPropertyName("id")]
    public required long Id { get; set; }

    /// <summary>
    /// Name of the device
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
