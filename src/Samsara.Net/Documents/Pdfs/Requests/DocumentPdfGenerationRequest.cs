using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Documents.Pdfs;

public record DocumentPdfGenerationRequest
{
    /// <summary>
    /// ID of the document.
    /// </summary>
    [JsonPropertyName("documentId")]
    public required string DocumentId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
