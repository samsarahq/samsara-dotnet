using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DocumentPdfGenerationResponseData
{
    /// <summary>
    /// ID of the document.
    /// </summary>
    [JsonPropertyName("documentId")]
    public string? DocumentId { get; set; }

    /// <summary>
    /// ID of the PDF file generated or being generated for the document.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
