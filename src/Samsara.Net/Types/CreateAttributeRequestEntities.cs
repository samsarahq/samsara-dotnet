using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record CreateAttributeRequestEntities : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Date values that can be associated with this attribute in RFC 3339 full-date format (YYYY-MM-DD)
    /// </summary>
    [JsonPropertyName("dateValues")]
    public IEnumerable<DateOnly>? DateValues { get; set; }

    /// <summary>
    /// Entity id, based on the entity type.
    /// </summary>
    [JsonPropertyName("entityId")]
    public string? EntityId { get; set; }

    /// <summary>
    /// The [external IDs](/docs/external-ids) for the given object.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

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
