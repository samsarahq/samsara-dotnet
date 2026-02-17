using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// An idling event object.
/// </summary>
[Serializable]
public record IdlingEventObjectV20251023ResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("address")]
    public IdlingEventAddressObjectResponseBody? Address { get; set; }

    /// <summary>
    /// The air temperature in millicelsius during the idling event. Value is returned only when it is known.
    /// </summary>
    [JsonPropertyName("airTemperatureMillicelsius")]
    public long? AirTemperatureMillicelsius { get; set; }

    [JsonPropertyName("asset")]
    public required IdlingEventAssetObjectResponseBody Asset { get; set; }

    /// <summary>
    /// The duration of the idling event in milliseconds.
    /// </summary>
    [JsonPropertyName("durationMilliseconds")]
    public required long DurationMilliseconds { get; set; }

    /// <summary>
    /// Universally unique identifier of the idling event.
    /// </summary>
    [JsonPropertyName("eventUuid")]
    public required string EventUuid { get; set; }

    /// <summary>
    /// The amount of fuel consumed in milliliters during the idling event.
    /// </summary>
    [JsonPropertyName("fuelConsumedMilliliters")]
    public required double FuelConsumedMilliliters { get; set; }

    [JsonPropertyName("fuelCost")]
    public required FuelCostObjectResponseBody FuelCost { get; set; }

    /// <summary>
    /// The amount of gaseous fuel consumed in grams during the idling event.
    /// </summary>
    [JsonPropertyName("gaseousFuelConsumedGrams")]
    public required double GaseousFuelConsumedGrams { get; set; }

    [JsonPropertyName("gaseousFuelCost")]
    public required GaseousFuelCostObjectResponseBody GaseousFuelCost { get; set; }

    /// <summary>
    /// The latitude of the location where the idling event occurred.
    /// </summary>
    [JsonPropertyName("latitude")]
    public double? Latitude { get; set; }

    /// <summary>
    /// The longitude of the location where the idling event occurred.
    /// </summary>
    [JsonPropertyName("longitude")]
    public double? Longitude { get; set; }

    [JsonPropertyName("operator")]
    public IdlingEventOperatorObjectResponseBody? Operator { get; set; }

    /// <summary>
    /// The PTO (Power Take-Off) state during the idling event.  Valid values: `active, inactive`
    /// </summary>
    [JsonPropertyName("ptoState")]
    public required IdlingEventObjectV20251023ResponseBodyPtoState PtoState { get; set; }

    /// <summary>
    /// The start time of the idling event in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("startTime")]
    public required string StartTime { get; set; }

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
