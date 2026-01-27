using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record GetDocumentTypeResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// List of the document type conditional field sections.
    /// </summary>
    [JsonPropertyName("conditionalFieldSections")]
    public IEnumerable<ConditionalFieldSectionObjectResponseBody>? ConditionalFieldSections { get; set; }

    /// <summary>
    /// The fields associated with this document type.
    /// </summary>
    [JsonPropertyName("fieldTypes")]
    public IEnumerable<FieldTypesObjectResponseBody>? FieldTypes { get; set; }

    /// <summary>
    /// Universally unique identifier for the document type. This value can be passed in as the documentTypeId when creating a document.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Name of the document type.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// ID for the organization this document type belongs to.
    /// </summary>
    [JsonPropertyName("orgId")]
    public long? OrgId { get; set; }

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
