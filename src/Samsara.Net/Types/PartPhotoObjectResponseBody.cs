using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A photo of a part.
/// </summary>
[Serializable]
public record PartPhotoObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// ID of the photo.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Processing status of the photo.  Valid values: `unknown`, `processing`, `finished`
    /// </summary>
    [JsonPropertyName("processingStatus")]
    public required PartPhotoObjectResponseBodyProcessingStatus ProcessingStatus { get; set; }

    /// <summary>
    /// Link to the photo. Included when processingStatus is 'finished'.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// Expiration time of url in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("urlExpiresAtTime")]
    public DateTime? UrlExpiresAtTime { get; set; }

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
