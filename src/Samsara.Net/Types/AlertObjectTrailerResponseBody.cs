using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AlertObjectTrailerResponseBody
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
    /// The ID of the trailer. This is automatically generated when the trailer is created. It cannot be changed.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The name of the trailer. This is set by a fleet administrator and will appear in both Samsara’s cloud dashboard as well as the Samsara Driver mobile app. By default, this name is the serial number of the Samsara Asset Gateway. It can be set or updated through the Samsara Dashboard or through the API at any time.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The list of [tags](https://kb.samsara.com/hc/en-us/articles/360026674631-Using-Tags-and-Tag-Nesting) associated with the Trailer.
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<GoaTagTinyResponseResponseBody>? Tags { get; set; }

    /// <summary>
    /// The serial number of the trailer.
    /// </summary>
    [JsonPropertyName("trailerSerialNumber")]
    public string? TrailerSerialNumber { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
