using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.FormSubmissions.PdfExports;

public record PdfExportsListRequest
{
    /// <summary>
    /// ID of the form submission PDF export.
    /// </summary>
    [JsonIgnore]
    public required string PdfId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
