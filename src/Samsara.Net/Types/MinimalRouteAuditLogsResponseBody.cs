using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record MinimalRouteAuditLogsResponseBody
{
    /// <summary>
    /// The route stops in the route. Only stops that have been updated will be included in the response.
    /// </summary>
    [JsonPropertyName("stops")]
    public IEnumerable<MinimalRouteStopAuditLogsResponseBody>? Stops { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
