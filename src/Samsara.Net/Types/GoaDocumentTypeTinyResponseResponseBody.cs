using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record GoaDocumentTypeTinyResponseResponseBody
{
    /// <summary>
    /// ID of the document type.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Name of the document type.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
