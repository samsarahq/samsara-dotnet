using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A single route event.
/// </summary>
[Serializable]
public record RouteEventResponseResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("eventDetails")]
    public RouteEventDetailsResponseBody? EventDetails { get; set; }

    /// <summary>
    /// Time the event was processed in RFC 3339 format
    /// </summary>
    [JsonPropertyName("eventTime")]
    public required DateTime EventTime { get; set; }

    /// <summary>
    /// Type of the event that occurred.  Valid values: `stopArrived`, `stopCompleted`, `stopEnRoute`, `stopSkipped`, `stopTaskCompleted`, `stopTaskSkipped`, `stopEtaUpdated`, `unspecified`
    /// </summary>
    [JsonPropertyName("eventType")]
    public required RouteEventResponseResponseBodyEventType EventType { get; set; }

    /// <summary>
    /// Time the event happened in RFC 3339 format
    /// </summary>
    [JsonPropertyName("happenedAtTime")]
    public required DateTime HappenedAtTime { get; set; }

    /// <summary>
    /// Unique ID of the route event.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("route")]
    public required RouteEventRouteResponseResponseBody Route { get; set; }

    [JsonPropertyName("stop")]
    public RouteEventStopResponseResponseBody? Stop { get; set; }

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
