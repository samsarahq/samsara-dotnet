using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The file outputs produced by a successfully completed job.
/// </summary>
[Serializable]
public record IftaDetailJobOutputResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// When this file was created.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required string CreatedAtTime { get; set; }

    /// <summary>
    /// A url to download the generated file. The contents will be gzipped. This url has an expiration and will no longer be valid after expiration.
    /// </summary>
    [JsonPropertyName("downloadUrl")]
    public required string DownloadUrl { get; set; }

    /// <summary>
    /// The expiration time of this file's download url. Requesting this job again by ID will refresh the download urls, if expired.
    /// </summary>
    [JsonPropertyName("downloadUrlExpirationTime")]
    public required string DownloadUrlExpirationTime { get; set; }

    /// <summary>
    /// The name of this file.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The number of records in this file.
    /// </summary>
    [JsonPropertyName("recordCount")]
    public required long RecordCount { get; set; }

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
