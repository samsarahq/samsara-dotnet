using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record RoutesGetRoutesFeedResponseBody
{
    /// <summary>
    /// Route feed response.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<RouteFeedObjectResponseBody> Data { get; set; } =
        new List<RouteFeedObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
