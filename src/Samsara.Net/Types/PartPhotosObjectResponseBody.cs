using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The photos of a part.
/// </summary>
[Serializable]
public record PartPhotosObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// ID of the part.
    /// </summary>
    [JsonPropertyName("partId")]
    public required string PartId { get; set; }

    /// <summary>
    /// Photos of the part other than the profile photo.
    /// </summary>
    [JsonPropertyName("photos")]
    public IEnumerable<PartPhotoObjectResponseBody> Photos { get; set; } =
        new List<PartPhotoObjectResponseBody>();

    [JsonPropertyName("profilePhoto")]
    public PartPhotoObjectResponseBody? ProfilePhoto { get; set; }

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
