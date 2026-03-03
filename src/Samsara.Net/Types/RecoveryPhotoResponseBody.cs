using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A photo associated with an asset recovery event.
/// </summary>
[Serializable]
public record RecoveryPhotoResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Timestamp of when the photo was captured, in milliseconds since epoch.
    /// </summary>
    [JsonPropertyName("start_ms")]
    public required long StartMs { get; set; }

    /// <summary>
    /// The availability status of the photo.  Valid values: `EXISTS`, `NOT_FOUND`, `SERVER_ERROR`
    /// </summary>
    [JsonPropertyName("status")]
    public required RecoveryPhotoResponseBodyStatus Status { get; set; }

    /// <summary>
    /// A temporary presigned URL for the recovery photo. This URL expires at the time indicated by url_expires_at_ms.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    /// <summary>
    /// Timestamp when the presigned URL expires, in milliseconds since epoch.
    /// </summary>
    [JsonPropertyName("url_expires_at_ms")]
    public required long UrlExpiresAtMs { get; set; }

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
