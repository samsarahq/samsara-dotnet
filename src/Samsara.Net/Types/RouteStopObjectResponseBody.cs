using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Route stop object
/// </summary>
[Serializable]
public record RouteStopObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The hub location identifier from dispatch
    /// </summary>
    [JsonPropertyName("hubLocationId")]
    public string? HubLocationId { get; set; }

    /// <summary>
    /// The Samsara-generated unique identifier (UUID) for the stop
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The name of the stop
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Additional notes for the stop
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// List of order tasks associated with this stop
    /// </summary>
    [JsonPropertyName("orders")]
    public IEnumerable<OrderTaskObjectResponseBody>? Orders { get; set; }

    /// <summary>
    /// The scheduled arrival time at the stop
    /// </summary>
    [JsonPropertyName("scheduledArrivalTime")]
    public required DateTime ScheduledArrivalTime { get; set; }

    /// <summary>
    /// The scheduled departure time from the stop
    /// </summary>
    [JsonPropertyName("scheduledDepartureTime")]
    public required DateTime ScheduledDepartureTime { get; set; }

    [JsonPropertyName("singleUseLocation")]
    public SingleUseLocationObjectResponseBody? SingleUseLocation { get; set; }

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
