using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DocumentTypesGetDocumentTypesResponseBody
{
    /// <summary>
    /// List of all document types for the organization
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<GetDocumentTypeResponseObjectResponseBody> Data { get; set; } =
        new List<GetDocumentTypeResponseObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
