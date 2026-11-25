using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record ShopsPostShopsRequestBody
{
    /// <summary>
    /// When true, each shop includes tags with id, name, and parentTagId. Defaults to false. Repeat this value with after.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeTags { get; set; }

    /// <summary>
    /// Up to 10 existing inventory location UUIDs.
    /// </summary>
    [JsonPropertyName("inventoryLocationIds")]
    public IEnumerable<string>? InventoryLocationIds { get; set; }

    /// <summary>
    /// Shop display name, unique ignoring case.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Up to 10 existing place ids.
    /// </summary>
    [JsonPropertyName("placeIds")]
    public IEnumerable<string>? PlaceIds { get; set; }

    /// <summary>
    /// Up to 10 existing tag ids.
    /// </summary>
    [JsonPropertyName("tagIds")]
    public IEnumerable<string>? TagIds { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
