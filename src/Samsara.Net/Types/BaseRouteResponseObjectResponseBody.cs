using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record BaseRouteResponseObjectResponseBody
{
    /// <summary>
    /// Actual end time, if it exists, for the route in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("actualRouteEndTime")]
    public DateTime? ActualRouteEndTime { get; set; }

    /// <summary>
    /// Actual start time, if it exists, for the route in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("actualRouteStartTime")]
    public DateTime? ActualRouteStartTime { get; set; }

    [JsonPropertyName("driver")]
    public GoaDriverTinyResponseResponseBody? Driver { get; set; }

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// ID of the route
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Route name
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Notes for the route
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// The local timezone, as defined in Settings for your organization. Timezones use [IANA timezone database](https://www.iana.org/time-zones) keys (e.g. `America/Los_Angeles`, `America/New_York`, `Europe/London`, etc.). You can find a mapping of common timezone formats to IANA timezone keys [here](https://unicode.org/cldr/charts/latest/supplemental/zone_tzid.html).
    /// </summary>
    [JsonPropertyName("orgLocalTimezone")]
    public string? OrgLocalTimezone { get; set; }

    /// <summary>
    /// List of shareable, non-expired 'By recurring Route' Live Sharing Links.
    /// </summary>
    [JsonPropertyName("recurringRouteLiveSharingLinks")]
    public IEnumerable<LiveSharingLinkResponseObjectResponseBody>? RecurringRouteLiveSharingLinks { get; set; }

    /// <summary>
    /// Scheduled end time, if it exists, for the route in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("scheduledRouteEndTime")]
    public DateTime? ScheduledRouteEndTime { get; set; }

    /// <summary>
    /// Scheduled start time, if it exists, for the route in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("scheduledRouteStartTime")]
    public DateTime? ScheduledRouteStartTime { get; set; }

    [JsonPropertyName("settings")]
    public RouteSettingsResponseBody? Settings { get; set; }

    /// <summary>
    /// List of stops along the route
    /// </summary>
    [JsonPropertyName("stops")]
    public IEnumerable<RoutesStopResponseObjectResponseBody>? Stops { get; set; }

    [JsonPropertyName("vehicle")]
    public GoaVehicleTinyResponseResponseBody? Vehicle { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
