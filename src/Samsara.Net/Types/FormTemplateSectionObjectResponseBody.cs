using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Form Template section object.
/// </summary>
[Serializable]
public record FormTemplateSectionObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The index of the first field from the fields array that is in this section. Index 0 represents the first field definition of the fields array.
    /// </summary>
    [JsonPropertyName("fieldIndexFirstInclusive")]
    public required long FieldIndexFirstInclusive { get; set; }

    /// <summary>
    /// The index of the last field from the fields array that is in this section.
    /// </summary>
    [JsonPropertyName("fieldIndexLastInclusive")]
    public required long FieldIndexLastInclusive { get; set; }

    /// <summary>
    /// Identifier of the section.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Label of the section.
    /// </summary>
    [JsonPropertyName("label")]
    public required string Label { get; set; }

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
