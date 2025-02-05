using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record GatewaysGetGatewaysResponseBody
{
    /// <summary>
    /// Activated gateways
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<GatewayResponseObjectResponseBody> Data { get; set; } =
        new List<GatewayResponseObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
