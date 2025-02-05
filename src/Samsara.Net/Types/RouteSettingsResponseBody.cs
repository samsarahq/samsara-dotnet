using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record RouteSettingsResponseBody
{
    /// <summary>
    /// Defaults to 'arriveLastStop' which ends the route upon arriving at the final stop. The condition 'departLastStop'
    /// ends the route upon departing the last stop. If 'arriveLastStop' is set, then the departure time of the final stop should not be set.  Valid values: `arriveLastStop`, `departLastStop`
    /// </summary>
    [JsonPropertyName("routeCompletionCondition")]
    public RouteSettingsResponseBodyRouteCompletionCondition? RouteCompletionCondition { get; set; }

    /// <summary>
    /// Defaults to 'departFirstStop' which starts the route upon departing the first stop in the route.
    ///  The condition 'arriveFirstStop' starts the route upon arriving at the first stop in the route. If 'departFirstStop' is set,
    /// the arrival time of the first stop should not be set.  Valid values: `departFirstStop`, `arriveFirstStop`
    /// </summary>
    [JsonPropertyName("routeStartingCondition")]
    public RouteSettingsResponseBodyRouteStartingCondition? RouteStartingCondition { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
