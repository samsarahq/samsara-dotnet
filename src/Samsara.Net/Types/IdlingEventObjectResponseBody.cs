using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// An idling event object.
/// </summary>
public record IdlingEventObjectResponseBody
{
    /// <summary>
    /// The ID of the geofence address of the idling location, if applicable. It will be the address at the time of idling.
    /// </summary>
    [JsonPropertyName("addressId")]
    public string? AddressId { get; set; }

    /// <summary>
    /// The type of the geofence address of the idling location, if applicable.  Valid values: `agricultureSource`, `alertsOnly`, `industrialSite`, `riskZone`, `shortHaul`, `undefined`, `workforceSite`, `yard`
    /// </summary>
    [JsonPropertyName("addressType")]
    public IdlingEventObjectResponseBodyAddressType? AddressType { get; set; }

    /// <summary>
    /// The air temperature in millicelsius during the idling event. Value is returned only when it is known.
    /// </summary>
    [JsonPropertyName("airTemperatureMillicelsius")]
    public long? AirTemperatureMillicelsius { get; set; }

    /// <summary>
    /// Samsara ID of the asset assigned to the event. Returns vehicle ID at this time.
    /// </summary>
    [JsonPropertyName("assetId")]
    public required long AssetId { get; set; }

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
    /// Samsara ID of the operator assigned the event. Returns driver ID at this time. Value is returned when the driver is assigned to the vehicle.
    /// </summary>
    [JsonPropertyName("operatorId")]
    public long? OperatorId { get; set; }

    /// <summary>
    /// The PTO (Power Take-Off) state during the idling event.  Valid values: `active, inactive`
    /// </summary>
    [JsonPropertyName("ptoState")]
    public string PtoState { get; set; } = "active, inactive";

    /// <summary>
    /// The start time of the idling event in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("startTime")]
    public required string StartTime { get; set; }

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
