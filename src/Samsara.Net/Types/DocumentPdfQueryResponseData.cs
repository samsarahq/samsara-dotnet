using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DocumentPdfQueryResponseData
{
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
