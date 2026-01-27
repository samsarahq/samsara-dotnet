using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Live Sharing Link response object.
/// </summary>
[Serializable]
public record LiveSharingLinkResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Date that this link expires, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("expiresAtTime")]
    public string? ExpiresAtTime { get; set; }

    /// <summary>
    /// The shareable URL of the vehicle's location.
    /// </summary>
    [JsonPropertyName("liveSharingUrl")]
    public required string LiveSharingUrl { get; set; }

    /// <summary>
    /// Name of the Live Sharing Link.
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
