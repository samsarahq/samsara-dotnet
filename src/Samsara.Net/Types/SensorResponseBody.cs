using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record SensorResponseBody
{
    /// <summary>
    /// ID of the sensor
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The MAC address of the sensor
    /// </summary>
    [JsonPropertyName("mac")]
    public required string Mac { get; set; }

    /// <summary>
    /// The name of the sensor
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
