using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormsMediaRecordObjectResponseBody
{
    /// <summary>
    /// ID of the media record.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Status of the media record.  Valid values: `unknown`, `processing`, `finished`
    /// </summary>
    [JsonPropertyName("processingStatus")]
    public required FormsMediaRecordObjectResponseBodyProcessingStatus ProcessingStatus { get; set; }

    /// <summary>
    /// URL containing a link to associated media content. Included if 'processingStatus' is 'finished'.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// Expiration time of the media record 'url'. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("urlExpiresAt")]
    public DateTime? UrlExpiresAt { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
