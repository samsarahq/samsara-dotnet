using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record AttributeEntity : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Date values that are associated with this attribute (RFC 3339 date format: YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("dateValues")]
    public IEnumerable<string>? DateValues { get; set; }

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
    /// Number values that are associated with this attribute. Note: this field is `null` for `text` and `freeform-multi-select` attribute types.`
    /// </summary>
    [JsonPropertyName("numberValues")]
    public IEnumerable<double>? NumberValues { get; set; }

    /// <summary>
    /// String values that are associated with this attribute. Note: this field is `null` for `text` and `freeform-multi-select` attribute types.`
    /// </summary>
    [JsonPropertyName("stringValues")]
    public IEnumerable<string>? StringValues { get; set; }

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
