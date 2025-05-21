using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A single route stop for a route.
/// </summary>
public record MinimalRouteStopResponseBody
{
    /// <summary>
    /// Actual arrival time, if it exists, for the route stop in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("actualArrivalTime")]
    public DateTime? ActualArrivalTime { get; set; }

    /// <summary>
    /// Actual departure time, if it exists, for the route stop in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("actualDepartureTime")]
    public DateTime? ActualDepartureTime { get; set; }

    /// <summary>
    /// The time the stop became en-route, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("enRouteTime")]
    public DateTime? EnRouteTime { get; set; }

    /// <summary>
    /// Estimated time of arrival, if this stop is currently en-route, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("eta")]
    public DateTime? Eta { get; set; }

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// Unique identifier for the route stop.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The shareable url of the stop's current status.
    /// </summary>
    [JsonPropertyName("liveSharingUrl")]
    public string? LiveSharingUrl { get; set; }

    /// <summary>
    /// Skipped time, if it exists, for the route stop in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("skippedTime")]
    public DateTime? SkippedTime { get; set; }

    /// <summary>
    /// The current state of the route stop.  Valid values: `unassigned`, `scheduled`, `en route`, `skipped`, `arrived`, `departed`
    /// </summary>
    [JsonPropertyName("state")]
    public required MinimalRouteStopResponseBodyState State { get; set; }

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
