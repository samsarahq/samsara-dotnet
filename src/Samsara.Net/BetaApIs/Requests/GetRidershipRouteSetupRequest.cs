using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetRidershipRouteSetupRequest
{
    /// <summary>
    /// The route ID. This is the Samsara route ID returned by the Routing API.
    /// </summary>
    [JsonIgnore]
    public required string RouteId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
