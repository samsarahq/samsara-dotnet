using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Inline file; at most 7.5 MB decoded or 10 MB base64 encoded.
/// </summary>
[Serializable]
public record MaintenanceEstimateInlineFileRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Base64-encoded document bytes; at most 10 MB encoded and 7.5 MB decoded.
    /// </summary>
    [JsonPropertyName("base64Content")]
    public required string Base64Content { get; set; }

    /// <summary>
    /// Media MIME type. Supported formats are PDF, JPEG and PNG.  Valid values: `application/pdf`, `image/jpeg`, `image/png`
    /// </summary>
    [JsonPropertyName("contentType")]
    public required MaintenanceEstimateInlineFileRequestBodyContentType ContentType { get; set; }

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
