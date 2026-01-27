using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Attributes;

[Serializable]
public record CreateAttributeRequest
{
    /// <summary>
    /// Denotes the data type of the attribute's values. Valid values: `single-select`, `multi-select`, `text`, `freeform-multi-select`, `number`, `date`.
    /// </summary>
    [JsonPropertyName("attributeType")]
    public required CreateAttributeRequestAttributeType AttributeType { get; set; }

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

    /// <summary>
    /// Unit of the attribute (only for Number attributes).
    /// </summary>
    [JsonPropertyName("unit")]
    public CreateAttributeRequestUnit? Unit { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
