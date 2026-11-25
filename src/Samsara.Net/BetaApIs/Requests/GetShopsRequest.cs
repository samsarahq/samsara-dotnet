using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetShopsRequest
{
    /// <summary>
    /// Comma-separated shop UUIDs. At most 100 non-blank values. Duplicates count toward that limit and are then ignored. Mutually exclusive with after. A blank value is rejected. Every id must match an active shop.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> ShopIds { get; set; } = new List<string>();

    /// <summary>
    /// When true, each shop includes tags with id, name, and parentTagId. Defaults to false. Repeat this value with after.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeTags { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
