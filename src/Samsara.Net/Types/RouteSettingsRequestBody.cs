using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// An optional dictionary, only necessary to override the defaults for route start and end conditions.
/// </summary>
[Serializable]
public record RouteSettingsRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Defaults to 'arriveLastStop' which ends the route upon arriving at the final stop. The condition 'departLastStop'
    /// ends the route upon departing the last stop. If 'arriveLastStop' is set, then the departure time of the final stop should not be set.  Valid values: `arriveLastStop`, `departLastStop`
    /// </summary>
    [JsonPropertyName("routeCompletionCondition")]
    public RouteSettingsRequestBodyRouteCompletionCondition? RouteCompletionCondition { get; set; }

    /// <summary>
    /// Defaults to 'departFirstStop' which starts the route upon departing the first stop in the route.
    ///  The condition 'arriveFirstStop' starts the route upon arriving at the first stop in the route. If 'departFirstStop' is set,
    /// the arrival time of the first stop should not be set.  Valid values: `departFirstStop`, `arriveFirstStop`
    /// </summary>
    [JsonPropertyName("routeStartingCondition")]
    public RouteSettingsRequestBodyRouteStartingCondition? RouteStartingCondition { get; set; }

    /// <summary>
    /// Determines how stops are sequenced on the route. 'scheduledArrivalTime' sequences stops by their scheduled arrival times (default). 'manual' allows custom sequencing via stop.sequenceNumber. 'unknown' indicates the method is not specified.  Valid values: `unknown`, `scheduledArrivalTime`, `manual`
    /// </summary>
    [JsonPropertyName("sequencingMethod")]
    public RouteSettingsRequestBodySequencingMethod? SequencingMethod { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
