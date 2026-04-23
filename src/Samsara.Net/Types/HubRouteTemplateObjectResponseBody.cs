using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A route template for a hub.
/// </summary>
[Serializable]
public record HubRouteTemplateObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The timestamp when the route template was created, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required DateTime CreatedAtTime { get; set; }

    [JsonPropertyName("defaultDepotEnd")]
    public HubRouteTemplateDepotObjectResponseBody? DefaultDepotEnd { get; set; }

    [JsonPropertyName("defaultDepotStart")]
    public HubRouteTemplateDepotObjectResponseBody? DefaultDepotStart { get; set; }

    /// <summary>
    /// Total distance of the route in meters.
    /// </summary>
    [JsonPropertyName("distanceMeters")]
    public required long DistanceMeters { get; set; }

    /// <summary>
    /// Total duration of the route in seconds.
    /// </summary>
    [JsonPropertyName("durationSeconds")]
    public required long DurationSeconds { get; set; }

    /// <summary>
    /// Default start time of day for the route template, in HH:MM format in the hub's local timezone (e.g. '08:00').
    /// </summary>
    [JsonPropertyName("earliestStartTime")]
    public string? EarliestStartTime { get; set; }

    /// <summary>
    /// The hub identifier this route template belongs to.
    /// </summary>
    [JsonPropertyName("hubId")]
    public required string HubId { get; set; }

    /// <summary>
    /// The IANA timezone of the hub (e.g. 'America/Los_Angeles').
    /// </summary>
    [JsonPropertyName("hubTimezone")]
    public required string HubTimezone { get; set; }

    /// <summary>
    /// The unique identifier for the route template.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Ordered list of stop locations in the route template.
    /// </summary>
    [JsonPropertyName("locations")]
    public IEnumerable<HubRouteTemplateLocationObjectResponseBody> Locations { get; set; } =
        new List<HubRouteTemplateLocationObjectResponseBody>();

    /// <summary>
    /// The name of the route template.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The timestamp when the route template was last updated, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required DateTime UpdatedAtTime { get; set; }

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
