using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AlertObjectSensorResponseBody
{
    /// <summary>
    /// Thye ID of the sensor associated with the alert
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The name of the sensor.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The Pinned Device ID associated with the alert
    /// </summary>
    [JsonPropertyName("pinnedDeviceId")]
    public string? PinnedDeviceId { get; set; }

    [JsonPropertyName("product")]
    public AlertObjectProductResponseBody? Product { get; set; }

    /// <summary>
    /// The list of [tags](https://kb.samsara.com/hc/en-us/articles/360026674631-Using-Tags-and-Tag-Nesting) associated with the sensor.
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<GoaTagTinyResponseResponseBody>? Tags { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
