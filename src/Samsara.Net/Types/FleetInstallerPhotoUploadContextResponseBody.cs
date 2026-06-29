using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Presigned S3 PUT context returned on session creation.
/// </summary>
[Serializable]
public record FleetInstallerPhotoUploadContextResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Presigned URL expiry (RFC 3339). The Step 2 PUT must complete before this time.
    /// </summary>
    [JsonPropertyName("expiresAtTime")]
    public required DateTime ExpiresAtTime { get; set; }

    /// <summary>
    /// HTTP headers the client MUST include verbatim on the Step 2 PUT request. Keys use S3 HTTP header naming (Title-Case-With-Hyphens) and are not subject to Samsara naming conventions.
    /// </summary>
    [JsonPropertyName("headers")]
    public Dictionary<string, string> Headers { get; set; } = new Dictionary<string, string>();

    /// <summary>
    /// Presigned S3 PUT URL. Valid until expiresAtTime.
    /// </summary>
    [JsonPropertyName("uploadUrl")]
    public required string UploadUrl { get; set; }

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
