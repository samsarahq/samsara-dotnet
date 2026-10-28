using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Create a presigned PUT upload session. Send the declared Content-Type, Content-MD5 and Content-Length with the PUT before expiry.
/// </summary>
[Serializable]
public record MaintenanceAttachmentUploadRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Standard base64 encoding of the file's 16-byte MD5 digest.
    /// </summary>
    [JsonPropertyName("contentMd5")]
    public required string ContentMd5 { get; set; }

    /// <summary>
    /// File MIME type.  Valid values: `application/pdf`, `image/jpeg`, `image/png`
    /// </summary>
    [JsonPropertyName("contentType")]
    public required MaintenanceAttachmentUploadRequestBodyContentType ContentType { get; set; }

    /// <summary>
    /// Exact file length in bytes; at most 40 MB.
    /// </summary>
    [JsonPropertyName("fileSizeBytes")]
    public required long FileSizeBytes { get; set; }

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
