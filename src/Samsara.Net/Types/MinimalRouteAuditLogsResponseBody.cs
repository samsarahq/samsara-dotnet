using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A single route. Only the fields that have changed are present in the response. All other fields, including the route id, will not be present in the response. For now, only routeStops are included since only Route Tracking updates are supported.
/// </summary>
public record MinimalRouteAuditLogsResponseBody
{
    /// <summary>
    /// The route stops in the route. Only stops that have been updated will be included in the response.
    /// </summary>
    [JsonPropertyName("stops")]
    public IEnumerable<MinimalRouteStopAuditLogsResponseBody>? Stops { get; set; }

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
