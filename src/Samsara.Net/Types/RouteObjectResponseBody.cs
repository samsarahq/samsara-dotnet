using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Route object
/// </summary>
[Serializable]
public record RouteObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The cost of the route
    /// </summary>
    [JsonPropertyName("cost")]
    public required double Cost { get; set; }

    /// <summary>
    /// The timestamp (in UTC) when the route was created
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// The dispatch route identifier
    /// </summary>
    [JsonPropertyName("dispatchRouteId")]
    public string? DispatchRouteId { get; set; }

    /// <summary>
    /// The total distance of the route in meters
    /// </summary>
    [JsonPropertyName("distanceMeters")]
    public required int DistanceMeters { get; set; }

    /// <summary>
    /// The total duration of the route in seconds
    /// </summary>
    [JsonPropertyName("durationSeconds")]
    public required int DurationSeconds { get; set; }

    /// <summary>
    /// The ID of the hub this route belongs to
    /// </summary>
    [JsonPropertyName("hubId")]
    public required string HubId { get; set; }

    /// <summary>
    /// The Samsara-generated unique identifier (UUID) for the route
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Whether the route has been edited
    /// </summary>
    [JsonPropertyName("isEdited")]
    public required bool IsEdited { get; set; }

    /// <summary>
    /// Whether the route is pinned
    /// </summary>
    [JsonPropertyName("isPinned")]
    public required bool IsPinned { get; set; }

    /// <summary>
    /// The name of the route
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The organization location timezone calculated from hub
    /// </summary>
    [JsonPropertyName("orgLocationTimezone")]
    public required string OrgLocationTimezone { get; set; }

    /// <summary>
    /// The ID of the plan this route belongs to
    /// </summary>
    [JsonPropertyName("planId")]
    public required string PlanId { get; set; }

    /// <summary>
    /// List of quantity information for the route
    /// </summary>
    [JsonPropertyName("quantities")]
    public IEnumerable<QuantityObjectResponseBody>? Quantities { get; set; }

    /// <summary>
    /// The scheduled end time of the route calculated from last stop
    /// </summary>
    [JsonPropertyName("scheduledRouteEndTime")]
    public required DateTime ScheduledRouteEndTime { get; set; }

    /// <summary>
    /// The scheduled start time of the route calculated from first stop
    /// </summary>
    [JsonPropertyName("scheduledRouteStartTime")]
    public required DateTime ScheduledRouteStartTime { get; set; }

    /// <summary>
    /// List of stops on the route
    /// </summary>
    [JsonPropertyName("stops")]
    public IEnumerable<RouteStopObjectResponseBody> Stops { get; set; } =
        new List<RouteStopObjectResponseBody>();

    /// <summary>
    /// The type of route
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// The timestamp (in UTC) when the route was last updated
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

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
