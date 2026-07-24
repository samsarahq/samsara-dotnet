using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBody
{
    /// <summary>
    /// Base64-encoded MD5 of the file bytes. Signed into the presigned URL as Content-MD5; object storage verifies upload integrity on PUT. Must be exactly 24 characters (base64-encoded 16-byte MD5 digest).
    /// </summary>
    [JsonPropertyName("contentMd5")]
    public required string ContentMd5 { get; set; }

    /// <summary>
    /// Samsara device ID. The device must belong to the caller's organization.
    /// </summary>
    [JsonPropertyName("deviceId")]
    public required string DeviceId { get; set; }

    /// <summary>
    /// File format. Samsara maps this to the corresponding MIME type for the presigned URL.  Valid values: `imageJpeg`, `imagePng`
    /// </summary>
    [JsonPropertyName("fileFormatType")]
    public required FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyFileFormatType FileFormatType { get; set; }

    /// <summary>
    /// Original file name. Max 255 characters; printable characters only; no null bytes or path separators (/ or \).
    /// </summary>
    [JsonPropertyName("fileName")]
    public required string FileName { get; set; }

    /// <summary>
    /// Hardware category of the device being installed.  Valid values: `vehicleGateway`, `assetGateway`, `camera`, `cameraConnector`, `environmentalMonitor`, `assetTag`, `trackingLabel`
    /// </summary>
    [JsonPropertyName("hardwareType")]
    public required FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyHardwareType HardwareType { get; set; }

    /// <summary>
    /// Purpose of the photo.  Valid values: `installPhoto`, `assetPhoto`
    /// </summary>
    [JsonPropertyName("photoType")]
    public required FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyPhotoType PhotoType { get; set; }

    /// <summary>
    /// File size in bytes. Validated against the maximum allowed size (10 MB) and signed into the presigned URL as Content-Length.
    /// </summary>
    [JsonPropertyName("sizeBytes")]
    public required long SizeBytes { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
