using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Configuration details specific to the 'By Asset' Live Sharing Link.
/// </summary>
[Serializable]
public record AssetsLocationLinkRequestConfigObject : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Unique assets ID that Live Sharing Link will show.
    /// </summary>
    [JsonPropertyName("assetId")]
    public string? AssetId { get; set; }

    [JsonPropertyName("location")]
    public AssetsLocationLinkConfigAddressDetailsObject? Location { get; set; }

    /// <summary>
    /// Array of tag IDs to filter data by.
    /// </summary>
    [JsonPropertyName("tagIds")]
    public IEnumerable<string>? TagIds { get; set; }

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
