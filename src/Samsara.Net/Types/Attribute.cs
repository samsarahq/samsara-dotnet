using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record Attribute : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Denotes the data type of the attribute's values. Valid values: `single-select`, `multi-select`, `text`, `freeform-multi-select`, `number`, `date`.
    /// </summary>
    [JsonPropertyName("attributeType")]
    public AttributeAttributeType? AttributeType { get; set; }

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
    /// Number values that can be associated with this attribute. Note: this field is `null` for `text` and `freeform-multi-select` attribute types.`
    /// </summary>
    [JsonPropertyName("numberValues")]
    public IEnumerable<double>? NumberValues { get; set; }

    /// <summary>
    /// String values that can be associated with this attribute. Note: this field is `null` for `text` and `freeform-multi-select` attribute types.`
    /// </summary>
    [JsonPropertyName("stringValues")]
    public IEnumerable<string>? StringValues { get; set; }

    /// <summary>
    /// Unit of the attribute (only for Number attributes).
    /// </summary>
    [JsonPropertyName("unit")]
    public AttributeUnit? Unit { get; set; }

    /// <summary>
    /// Representation of values that includes ids. Note: this field is `null` for `text` and `freeform-multi-select` attribute types.`
    /// </summary>
    [JsonPropertyName("values")]
    public IEnumerable<AttributeValueTiny>? Values { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
