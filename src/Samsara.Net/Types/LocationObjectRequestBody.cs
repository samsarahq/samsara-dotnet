using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record LocationObjectRequestBody
{
    /// <summary>
    /// All locations with selected address IDs will trigger.
    /// </summary>
    [JsonPropertyName("addressIds")]
    public IEnumerable<string>? AddressIds { get; set; }

    /// <summary>
    /// All locations with the selected address types will trigger.
    /// </summary>
    [JsonPropertyName("addressTypes")]
    public IEnumerable<LocationObjectRequestBodyAddressTypesItem>? AddressTypes { get; set; }

    [JsonPropertyName("circle")]
    public CircleRequestBody? Circle { get; set; }

    [JsonPropertyName("polygon")]
    public PolygonRequestBody? Polygon { get; set; }

    /// <summary>
    /// All locations with selected tag will trigger.
    /// </summary>
    [JsonPropertyName("tagIds")]
    public IEnumerable<string>? TagIds { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
