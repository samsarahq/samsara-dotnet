using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A file in Functions storage with a presigned download URL.
/// </summary>
[Serializable]
public record GetFunctionStorageFileDetailResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("downloadGet")]
    public required FunctionsStorageSignedUrlOfTypeResponseBody DownloadGet { get; set; }

    /// <summary>
    /// The name of the file.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

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
