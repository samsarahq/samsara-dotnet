using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A presigned URL for a file in Functions storage.
/// </summary>
[Serializable]
public record FunctionsStorageSignedUrlOfTypeResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// RFC 3339 timestamp when the presigned URL expires.
    /// </summary>
    [JsonPropertyName("expiresAtTime")]
    public required DateTime ExpiresAtTime { get; set; }

    /// <summary>
    /// The presigned URL.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

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
