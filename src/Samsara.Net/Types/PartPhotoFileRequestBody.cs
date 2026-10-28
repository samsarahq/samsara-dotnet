using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Photo to add to a part.
/// </summary>
[Serializable]
public record PartPhotoFileRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Base64 encoded image content. Maximum decoded size: 7.5MB.
    /// </summary>
    [JsonPropertyName("base64Content")]
    public required string Base64Content { get; set; }

    /// <summary>
    /// MIME type of the image. Supported types: image/jpeg, image/png.
    /// </summary>
    [JsonPropertyName("contentType")]
    public required string ContentType { get; set; }

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
