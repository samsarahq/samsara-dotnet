using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Created attachment and optional upload session.
/// </summary>
[Serializable]
public record MaintenanceEstimateAttachmentCreateResultResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Time the attachment was created.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required DateTime CreatedAtTime { get; set; }

    /// <summary>
    /// Stable attachment ID.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Original or generated filename.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Attachment availability. Defaults to processing until a validated download is available; unknown when availability cannot be determined.  Valid values: `unknown`, `processing`, `finished`
    /// </summary>
    [JsonPropertyName("processingStatus")]
    public required MaintenanceEstimateAttachmentCreateResultResponseBodyProcessingStatus ProcessingStatus { get; set; }

    /// <summary>
    /// Latest attachment change; initially equal to creation time.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required DateTime UpdatedAtTime { get; set; }

    [JsonPropertyName("uploadPut")]
    public FunctionsStorageSignedUrlOfTypeResponseBody? UploadPut { get; set; }

    /// <summary>
    /// Temporary download URL; present only when processingStatus is finished.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// Expiration of the temporary download URL; present only with url.
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
