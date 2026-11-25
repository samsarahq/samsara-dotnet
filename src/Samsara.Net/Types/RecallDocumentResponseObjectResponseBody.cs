using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A document published by the recall source.
/// </summary>
[Serializable]
public record RecallDocumentResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The source's label for the document type.
    /// </summary>
    [JsonPropertyName("documentType")]
    public required string DocumentType { get; set; }

    /// <summary>
    /// Link to the document on the source's site.
    /// </summary>
    [JsonPropertyName("documentUrl")]
    public required string DocumentUrl { get; set; }

    /// <summary>
    /// File name of the document.
    /// </summary>
    [JsonPropertyName("fileName")]
    public required string FileName { get; set; }

    /// <summary>
    /// Time the source published the document, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("loadedAtTime")]
    public DateTime? LoadedAtTime { get; set; }

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
