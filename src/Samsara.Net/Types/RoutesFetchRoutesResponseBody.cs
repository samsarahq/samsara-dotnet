using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record RoutesFetchRoutesResponseBody
{
    /// <summary>
    /// An array containing multiple routes.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<BaseRouteResponseObjectResponseBody> Data { get; set; } =
        new List<BaseRouteResponseObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
