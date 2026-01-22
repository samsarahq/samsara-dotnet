using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record WebhookRouteResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
