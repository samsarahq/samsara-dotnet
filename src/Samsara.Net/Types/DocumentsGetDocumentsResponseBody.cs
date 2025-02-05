using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DocumentsGetDocumentsResponseBody
{
    /// <summary>
    /// Multiple documents.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<DocumentResponseObjectResponseBody> Data { get; set; } =
        new List<DocumentResponseObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
