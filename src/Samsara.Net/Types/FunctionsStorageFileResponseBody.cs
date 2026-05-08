using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A file stored in Functions storage.
/// </summary>
[Serializable]
public record FunctionsStorageFileResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// RFC 3339 timestamp of when the file was last modified.
    /// </summary>
    [JsonPropertyName("modifiedAtTime")]
    public required DateTime ModifiedAtTime { get; set; }

    /// <summary>
    /// The name of the file.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The size of the file in bytes.
    /// </summary>
    [JsonPropertyName("sizeBytes")]
    public required long SizeBytes { get; set; }

    /// <summary>
    /// Presigned URLs for this file. Only present when includeDownloadUrls or includeUploadUrls is set.
    /// </summary>
    [JsonPropertyName("urls")]
    public IEnumerable<FunctionsStorageSignedUrlResponseBody>? Urls { get; set; }

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
