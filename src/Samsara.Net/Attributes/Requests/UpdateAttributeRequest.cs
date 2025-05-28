using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Attributes;

public record UpdateAttributeRequest
{
    /// <summary>
    /// Denotes the data type of the attribute's values. Valid values: `string`, `number`.
    /// </summary>
    [JsonPropertyName("attributeType")]
    public UpdateAttributeRequestAttributeType? AttributeType { get; set; }

    /// <summary>
    /// Defines whether or not this attribute can be used on the same entity many times (with different values). Denotes the type of entity, driver or asset. Valid values: `driver`, `asset`.
    /// </summary>
    [JsonPropertyName("attributeValueQuantity")]
    public UpdateAttributeRequestAttributeValueQuantity? AttributeValueQuantity { get; set; }

    /// <summary>
    /// Entities that will be applied to this attribute
    /// </summary>
    [JsonPropertyName("entities")]
    public IEnumerable<CreateAttributeRequestEntities>? Entities { get; set; }

    /// <summary>
    /// Denotes the type of entity, driver or asset.
    /// </summary>
    [JsonPropertyName("entityType")]
    public required UpdateAttributeRequestEntityType EntityType { get; set; }

    /// <summary>
    /// Name
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

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
