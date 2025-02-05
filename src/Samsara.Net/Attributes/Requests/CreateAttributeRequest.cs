using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Attributes;

public record CreateAttributeRequest
{
    /// <summary>
    /// Denotes the data type of the attribute's values. Valid values: `string`, `number`.
    /// </summary>
    [JsonPropertyName("attributeType")]
    public required CreateAttributeRequestAttributeType AttributeType { get; set; }

    /// <summary>
    /// Defines whether or not this attribute can be used on the same entity many times (with different values). Valid values: `single`, `multi`.
    /// </summary>
    [JsonPropertyName("attributeValueQuantity")]
    public required CreateAttributeRequestAttributeValueQuantity AttributeValueQuantity { get; set; }

    /// <summary>
    /// Entities that will be applied to this attribute
    /// </summary>
    [JsonPropertyName("entities")]
    public IEnumerable<CreateAttributeRequestEntities>? Entities { get; set; }

    /// <summary>
    /// Denotes the type of entity, driver or asset.
    /// </summary>
    [JsonPropertyName("entityType")]
    public required CreateAttributeRequestEntityType EntityType { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
