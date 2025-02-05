using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AlertObjectVehicleResponseBody
{
    /// <summary>
    /// List of attributes associated with the entity
    /// </summary>
    [JsonPropertyName("attributes")]
    public IEnumerable<GoaAttributeTinyResponseBody>? Attributes { get; set; }

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// The ID of the vehicle.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The name of the vehicle.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The serial number of the gateway installed on the asset.
    /// </summary>
    [JsonPropertyName("serial")]
    public required string Serial { get; set; }

    [JsonPropertyName("staticAssignedDriver")]
    public DriverObjectResponseBody? StaticAssignedDriver { get; set; }

    /// <summary>
    /// The list of [tags](https://kb.samsara.com/hc/en-us/articles/360026674631-Using-Tags-and-Tag-Nesting) associated with the vehicle.
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<GoaTagTinyResponseResponseBody>? Tags { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
