using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A fleet installer photo upload session.
/// </summary>
[Serializable]
public record FleetInstallerPhotoUploadSessionResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Base64-encoded MD5 of the file bytes.
    /// </summary>
    [JsonPropertyName("contentMd5")]
    public required string ContentMd5 { get; set; }

    /// <summary>
    /// Session creation timestamp (RFC 3339).
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required DateTime CreatedAtTime { get; set; }

    /// <summary>
    /// Samsara device ID.
    /// </summary>
    [JsonPropertyName("deviceId")]
    public required string DeviceId { get; set; }

    /// <summary>
    /// File format.  Valid values: `imageJpeg`, `imagePng`, `unknown`
    /// </summary>
    [JsonPropertyName("fileFormatType")]
    public required FleetInstallerPhotoUploadSessionResponseBodyFileFormatType FileFormatType { get; set; }

    /// <summary>
    /// Original file name supplied at session creation.
    /// </summary>
    [JsonPropertyName("fileName")]
    public required string FileName { get; set; }

    /// <summary>
    /// Hardware category of the device.  Valid values: `vehicleGateway`, `assetGateway`, `camera`, `cameraConnector`, `environmentalMonitor`, `assetTag`, `trackingLabel`, `unknown`
    /// </summary>
    [JsonPropertyName("hardwareType")]
    public required FleetInstallerPhotoUploadSessionResponseBodyHardwareType HardwareType { get; set; }

    /// <summary>
    /// Unique session UUID.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Purpose of the photo.  Valid values: `installPhoto`, `assetPhoto`, `unknown`
    /// </summary>
    [JsonPropertyName("photoType")]
    public required FleetInstallerPhotoUploadSessionResponseBodyPhotoType PhotoType { get; set; }

    /// <summary>
    /// Upload lifecycle state.  Valid values: `awaitingUpload`, `processing`, `finished`, `unknown`
    /// </summary>
    [JsonPropertyName("processingStatus")]
    public required FleetInstallerPhotoUploadSessionResponseBodyProcessingStatus ProcessingStatus { get; set; }

    /// <summary>
    /// File size in bytes.
    /// </summary>
    [JsonPropertyName("sizeBytes")]
    public required long SizeBytes { get; set; }

    /// <summary>
    /// Timestamp of last state change (RFC 3339). Equals createdAtTime at session creation; updated when processingStatus changes.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required DateTime UpdatedAtTime { get; set; }

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
