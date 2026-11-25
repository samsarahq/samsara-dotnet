using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// An active maintenance shop.
/// </summary>
[Serializable]
public record ShopObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Unique id of the shop. Use this value as the shop id on the work order API.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Inventory locations linked to this shop. Empty when the shop has none.
    /// </summary>
    [JsonPropertyName("inventoryLocations")]
    public IEnumerable<ShopReferenceResponseBody> InventoryLocations { get; set; } =
        new List<ShopReferenceResponseBody>();

    /// <summary>
    /// Display name of the shop.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Places linked to this shop. Empty when the shop has none.
    /// </summary>
    [JsonPropertyName("places")]
    public IEnumerable<ShopReferenceResponseBody> Places { get; set; } =
        new List<ShopReferenceResponseBody>();

    /// <summary>
    /// Tags linked to this shop. Present only when includeTags is true.
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<ShopTagResponseBody>? Tags { get; set; }

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
