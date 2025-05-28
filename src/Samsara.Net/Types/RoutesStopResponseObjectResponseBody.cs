using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record RoutesStopResponseObjectResponseBody
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

    [JsonPropertyName("address")]
    public GoaAddressTinyResponseResponseBody? Address { get; set; }

    /// <summary>
    /// List of documents associated with the stop.
    /// </summary>
    [JsonPropertyName("documents")]
    public IEnumerable<GoaDocumentTinyResponseResponseBody>? Documents { get; set; }

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
    /// Id of the stop
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The shareable url of the stop's current status.
    /// </summary>
    [JsonPropertyName("liveSharingUrl")]
    public string? LiveSharingUrl { get; set; }

    /// <summary>
    /// List of shareable, non-expired 'By Location' Live Sharing Links.
    /// </summary>
    [JsonPropertyName("locationLiveSharingLinks")]
    public IEnumerable<LiveSharingLinkResponseObjectResponseBody>? LocationLiveSharingLinks { get; set; }

    /// <summary>
    /// Name of the stop
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Notes for the stop
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// Specifies the time window (in milliseconds) after a stop's scheduled arrival time during which the stop is considered 'on-time'.
    /// </summary>
    [JsonPropertyName("ontimeWindowAfterArrivalMs")]
    public long? OntimeWindowAfterArrivalMs { get; set; }

    /// <summary>
    /// Specifies the time window (in milliseconds) before a stop's scheduled arrival time during which the stop is considered 'on-time'.
    /// </summary>
    [JsonPropertyName("ontimeWindowBeforeArrivalMs")]
    public long? OntimeWindowBeforeArrivalMs { get; set; }

    /// <summary>
    /// Scheduled arrival time, if it exists, for the stop in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("scheduledArrivalTime")]
    public DateTime? ScheduledArrivalTime { get; set; }

    /// <summary>
    /// Scheduled departure time, if it exists, for the stop in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("scheduledDepartureTime")]
    public DateTime? ScheduledDepartureTime { get; set; }

    [JsonPropertyName("singleUseLocation")]
    public RoutesSingleUseAddressObjectResponseBody? SingleUseLocation { get; set; }

    /// <summary>
    /// Skipped time, if it exists, for the route stop in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("skippedTime")]
    public DateTime? SkippedTime { get; set; }

    /// <summary>
    /// The current state of the route stop.  Valid values: `unassigned`, `scheduled`, `en route`, `skipped`, `arrived`, `departed`
    /// </summary>
    [JsonPropertyName("state")]
    public required RoutesStopResponseObjectResponseBodyState State { get; set; }

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
