using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record Attribute
{
    /// <summary>
    /// Denotes the data type of the attribute's values. Valid values: `string`, `number`.
    /// </summary>
    [JsonPropertyName("attributeType")]
    public AttributeAttributeType? AttributeType { get; set; }

    /// <summary>
    /// Defines whether or not this attribute can be used on the same entity many times (with different values). Valid values: `single`, `multi`.
    /// </summary>
    [JsonPropertyName("attributeValueQuantity")]
    public AttributeAttributeValueQuantity? AttributeValueQuantity { get; set; }

    /// <summary>
    /// Denotes the type of entity, driver or asset. Valid values: `driver`, `asset`.
    /// </summary>
    [JsonPropertyName("entityType")]
    public AttributeEntityType? EntityType { get; set; }

    /// <summary>
    /// The samsara id of the attribute object.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Name of attribute.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Number values that can be associated with this attribute
    /// </summary>
    [JsonPropertyName("numberValues")]
    public IEnumerable<double>? NumberValues { get; set; }

    /// <summary>
    /// String values that can be associated with this attribute
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
