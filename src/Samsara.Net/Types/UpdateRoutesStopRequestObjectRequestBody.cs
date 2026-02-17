using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record UpdateRoutesStopRequestObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// ID of the address. An address [externalId](https://developers.samsara.com/docs/external-ids#using-external-ids) can also be used interchangeably here.
    /// </summary>
    [JsonPropertyName("addressId")]
    public string? AddressId { get; set; }

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// ID of the stop
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Name of the stop
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
    /// This is a required field for all stops EXCEPT the start and end, based on route start and stop settings selected.
    /// </summary>
    [JsonPropertyName("scheduledArrivalTime")]
    public DateTime? ScheduledArrivalTime { get; set; }

    /// <summary>
    /// This is a required field for all stops EXCEPT the start and end, based on route start and stop settings selected.
    /// </summary>
    [JsonPropertyName("scheduledDepartureTime")]
    public DateTime? ScheduledDepartureTime { get; set; }

    /// <summary>
    /// Manual sequence position for this stop. Only meaningful when route.settings.sequencingMethod=manual. Must be unique and positive when specified.
    /// </summary>
    [JsonPropertyName("sequenceNumber")]
    public long? SequenceNumber { get; set; }

    [JsonPropertyName("singleUseLocation")]
    public RoutesSingleUseAddressObjectRequestBody? SingleUseLocation { get; set; }

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
