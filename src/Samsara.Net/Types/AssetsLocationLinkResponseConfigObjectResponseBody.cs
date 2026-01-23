using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Configuration details specific to the 'By Asset' Live Sharing Link.
/// </summary>
[Serializable]
public record AssetsLocationLinkResponseConfigObjectResponseBody : IJsonOnDeserialized
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
    public AssetsLocationLinkConfigAddressDetailsObjectResponseBody? Location { get; set; }

    /// <summary>
    /// The list of [tags](https://kb.samsara.com/hc/en-us/articles/360026674631-Using-Tags-and-Tag-Nesting) associated with assets for Live Sharing Link. Only populated if the link is configured for by tags instead of by asset ID.
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<GoaTagTinyResponseResponseBody>? Tags { get; set; }

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
