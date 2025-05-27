using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// An optional dictionary, only necessary to override the defaults for route start and end conditions.
/// </summary>
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
