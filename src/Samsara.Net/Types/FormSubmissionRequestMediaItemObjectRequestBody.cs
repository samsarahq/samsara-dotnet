using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A media item in a form submission request.
/// </summary>
[Serializable]
public record FormSubmissionRequestMediaItemObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Base64-encoded binary content of the media.
    /// </summary>
    [JsonPropertyName("base64Payload")]
    public required string Base64Payload { get; set; }

    /// <summary>
    /// MIME type of the media.
    /// </summary>
    [JsonPropertyName("mediaType")]
    public required string MediaType { get; set; }

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
