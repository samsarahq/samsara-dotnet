using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Deletion marker for a soft-deleted place.
/// </summary>
[Serializable]
public record PlaceDeletionMarkerObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// When the delete became customer-visible, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("deletedAtTime")]
    public required DateTime DeletedAtTime { get; set; }

    /// <summary>
    /// External ids captured for the place when present.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public PlaceDeletionMarkerObjectResponseBodyExternalIds? ExternalIds { get; set; }

    /// <summary>
    /// Samsara place id.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

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
