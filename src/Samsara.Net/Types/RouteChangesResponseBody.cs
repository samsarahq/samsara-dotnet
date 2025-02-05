using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record RouteChangesResponseBody
{
    [JsonPropertyName("after")]
    public required MinimalRouteAuditLogsResponseBody After { get; set; }

    [JsonPropertyName("before")]
    public required MinimalRouteAuditLogsResponseBody Before { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
