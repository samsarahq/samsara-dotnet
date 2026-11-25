using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record ShopsPatchShopsRequestBody
{
    /// <summary>
    /// Shop UUID.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// When true, each shop includes tags with id, name, and parentTagId. Defaults to false. Repeat this value with after.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeTags { get; set; }

    /// <summary>
    /// Replaces all inventory location ids. Empty clears the list.
    /// </summary>
    [JsonPropertyName("inventoryLocationIds")]
    public IEnumerable<string>? InventoryLocationIds { get; set; }

    /// <summary>
    /// New shop display name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Replaces all place ids. Empty clears the list.
    /// </summary>
    [JsonPropertyName("placeIds")]
    public IEnumerable<string>? PlaceIds { get; set; }

    /// <summary>
    /// Replaces all tag ids. Empty clears the list.
    /// </summary>
    [JsonPropertyName("tagIds")]
    public IEnumerable<string>? TagIds { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
