using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record DocumentPdfQueryResponseData : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Time that PDF generation was completed, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("completedAtTime")]
    public string? CompletedAtTime { get; set; }

    /// <summary>
    /// ID of the document.
    /// </summary>
    [JsonPropertyName("documentId")]
    public string? DocumentId { get; set; }

    /// <summary>
    /// S3 pre-signed URL to download PDF file.
    /// </summary>
    [JsonPropertyName("downloadDocumentPdfUrl")]
    public string? DownloadDocumentPdfUrl { get; set; }

    /// <summary>
    /// ID of the PDF file generated or being generated for the document
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Describes status of the PDF generation job. Valid values: `requested`, `processing`, `completed`.
    /// </summary>
    [JsonPropertyName("jobStatus")]
    public DocumentPdfQueryResponseDataJobStatus? JobStatus { get; set; }

    /// <summary>
    /// Time that PDF generation was requested, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("requestedAtTime")]
    public string? RequestedAtTime { get; set; }

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
