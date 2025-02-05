using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AlertObjectDriverResponseBody
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
    /// The ID of the driver
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The name of the driver.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The list of [tags](https://kb.samsara.com/hc/en-us/articles/360026674631-Using-Tags-and-Tag-Nesting) associated with the driver.
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<GoaTagTinyResponseResponseBody>? Tags { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
