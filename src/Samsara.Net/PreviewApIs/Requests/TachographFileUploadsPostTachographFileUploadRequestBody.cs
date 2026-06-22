using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.PreviewApIs;

[Serializable]
public record TachographFileUploadsPostTachographFileUploadRequestBody
{
    /// <summary>
    /// Base64-encoded MD5 digest of the file bytes (base64(md5(bytes))). Used as the Content-MD5 integrity check enforced by object storage on upload.
    /// </summary>
    [JsonPropertyName("contentMd5")]
    public required string ContentMd5 { get; set; }

    /// <summary>
    /// The MIME content type of the file. The upload is sent to object storage as raw bytes.  Valid values: `application/octet-stream`
    /// </summary>
    [JsonPropertyName("contentType")]
    public required TachographFileUploadsPostTachographFileUploadRequestBodyContentType ContentType { get; set; }

    /// <summary>
    /// The size of the file in bytes. Enforced as the Content-Length on upload and validated against the maximum allowed tachograph file size.
    /// </summary>
    [JsonPropertyName("fileSizeBytes")]
    public required long FileSizeBytes { get; set; }

    /// <summary>
    /// The kind of tachograph file being uploaded. The driver or device the file belongs to is resolved from the file contents, not from this field.  Valid values: `driverCard`, `vehicleUnit`
    /// </summary>
    [JsonPropertyName("fileType")]
    public required TachographFileUploadsPostTachographFileUploadRequestBodyFileType FileType { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
