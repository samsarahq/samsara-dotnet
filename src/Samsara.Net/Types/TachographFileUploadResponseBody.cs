using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A reserved tachograph file upload with a presigned URL to upload the file bytes to.
/// </summary>
[Serializable]
public record TachographFileUploadResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// RFC 3339 timestamp when the presigned upload URL expires.
    /// </summary>
    [JsonPropertyName("expiresAtTime")]
    public required DateTime ExpiresAtTime { get; set; }

    /// <summary>
    /// The HTTP headers that must be included on the upload PUT request.
    /// </summary>
    [JsonPropertyName("requiredHeaders")]
    public IEnumerable<TachographUploadRequiredHeaderResponseBody> RequiredHeaders { get; set; } =
        new List<TachographUploadRequiredHeaderResponseBody>();

    /// <summary>
    /// The presigned URL to upload the file bytes to with an HTTP PUT. Upload the raw bytes directly to this URL with the required headers.
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
