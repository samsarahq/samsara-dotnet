using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AttributeEntity
{
    [JsonPropertyName("entityId")]
    public long? EntityId { get; set; }

    /// <summary>
    /// The [external IDs](https://developers.samsara.com/docs/external-ids) for the given object.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public AttributeEntityExternalIds? ExternalIds { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Number values that are associated with this attribute.
    /// </summary>
    [JsonPropertyName("numberValues")]
    public IEnumerable<double>? NumberValues { get; set; }

    /// <summary>
    /// String values that are associated with this attribute.
    /// </summary>
    [JsonPropertyName("stringValues")]
    public IEnumerable<string>? StringValues { get; set; }

    /// <summary>
    /// Representation of values that includes ids.
    /// </summary>
    [JsonPropertyName("values")]
    public IEnumerable<AttributeValueTiny>? Values { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
