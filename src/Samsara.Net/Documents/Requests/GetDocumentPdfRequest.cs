using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Documents;

[Serializable]
public record GetDocumentPdfRequest
{
    /// <summary>
    /// ID of the pdf.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
