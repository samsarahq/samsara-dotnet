using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Work Order Attachment object.
/// </summary>
[Serializable]
public record WorkOrderAttachmentObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// ID of the media record.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Status of the media record.  Valid values: `unknown`, `processing`, `finished`
    /// </summary>
    [JsonPropertyName("processingStatus")]
    public required WorkOrderAttachmentObjectResponseBodyProcessingStatus ProcessingStatus { get; set; }

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
