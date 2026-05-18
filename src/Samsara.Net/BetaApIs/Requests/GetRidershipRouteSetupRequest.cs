using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetRidershipRouteSetupRequest
{
    /// <summary>
    /// The Samsara route ID returned by the Routing API, or an external ID in `key:value` format. For example, `extRoute:WB-12`.
    /// </summary>
    [JsonIgnore]
    public required string RouteId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
