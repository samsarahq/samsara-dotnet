using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Form Submission PDF export response object.
/// </summary>
[Serializable]
public record FormSubmissionPdfExportResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Time when the PDF export job was completed. Included if 'jobStatus' is 'done'. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("completedAtTime")]
    public DateTime? CompletedAtTime { get; set; }

    /// <summary>
    /// An error message for failed PDF export jobs. Included if 'jobStatus' is 'failed'.
    /// </summary>
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    /// <summary>
    /// Time when the PDF export job expires. After expiration, GET requests for this job will fail and clients must create a new one with another POST request. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("expiresAtTime")]
    public required DateTime ExpiresAtTime { get; set; }

    /// <summary>
    /// ID of the form submission being exported.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Status of the PDF export job.  Valid values: `unknown`, `pending`, `done`, `failed`
    /// </summary>
    [JsonPropertyName("jobStatus")]
    public required FormSubmissionPdfExportResponseObjectResponseBodyJobStatus JobStatus { get; set; }

    /// <summary>
    /// Unique ID for the PDF export that is created.
    /// </summary>
    [JsonPropertyName("pdfId")]
    public required string PdfId { get; set; }

    /// <summary>
    /// URL to download the PDF file. Expires at time specified in 'pdfUrlExpiresAtTime'. Included if 'jobStatus' is 'done'.
    /// </summary>
    [JsonPropertyName("pdfUrl")]
    public string? PdfUrl { get; set; }

    /// <summary>
    /// Time when the PDF export's 'pdfUrl' expires. After expiration, clients can retrieve a fresh url with another GET request. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("pdfUrlExpiresAtTime")]
    public DateTime? PdfUrlExpiresAtTime { get; set; }

    /// <summary>
    /// Time when the PDF export POST request was made. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("requestedAtTime")]
    public required DateTime RequestedAtTime { get; set; }

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
