using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Forms media record object.
/// </summary>
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
