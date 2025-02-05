using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record ScannedDocumentValueObjectRequestBody
{
    /// <summary>
    /// Id of the scanned document.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Url of the scanned document.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
