using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A trailer and its stats
/// </summary>
[Serializable]
public record TrailerStatsSnapshotObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("carrierReeferState")]
    public TrailerStatReeferStateTypeResponseBody? CarrierReeferState { get; set; }

    [JsonPropertyName("gps")]
    public TrailerStatGpsTypeResponseBody? Gps { get; set; }

    [JsonPropertyName("gpsOdometerMeters")]
    public TrailerStatGpsOdometerMetersTypeResponseBody? GpsOdometerMeters { get; set; }

    /// <summary>
    /// ID of the trailer.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Name of the vehicle.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("reeferAlarms")]
    public TrailerStatReeferAlarmTypeResponseBody? ReeferAlarms { get; set; }

    [JsonPropertyName("reeferAmbientAirTemperatureMilliC")]
    public TrailerStatReeferAmbientAirTemperatureMilliCTypeResponseBody? ReeferAmbientAirTemperatureMilliC { get; set; }

    [JsonPropertyName("reeferDoorStateZone1")]
    public TrailerStatReeferDoorStateZone1TypeResponseBody? ReeferDoorStateZone1 { get; set; }

    [JsonPropertyName("reeferDoorStateZone2")]
    public TrailerStatReeferDoorStateZone2TypeResponseBody? ReeferDoorStateZone2 { get; set; }

    [JsonPropertyName("reeferDoorStateZone3")]
    public TrailerStatReeferDoorStateZone3TypeResponseBody? ReeferDoorStateZone3 { get; set; }

    [JsonPropertyName("reeferFuelPercent")]
    public TrailerStatReeferFuelPercentTypeResponseBody? ReeferFuelPercent { get; set; }

    [JsonPropertyName("reeferObdEngineSeconds")]
    public TrailerStatReeferObdEngineSecondsTypeResponseBody? ReeferObdEngineSeconds { get; set; }

    [JsonPropertyName("reeferReturnAirTemperatureMilliCZone1")]
    public TrailerStatReeferReturnAirTemperatureMilliCZone1TypeResponseBody? ReeferReturnAirTemperatureMilliCZone1 { get; set; }

    [JsonPropertyName("reeferReturnAirTemperatureMilliCZone2")]
    public TrailerStatReeferReturnAirTemperatureMilliCZone2TypeResponseBody? ReeferReturnAirTemperatureMilliCZone2 { get; set; }

    [JsonPropertyName("reeferReturnAirTemperatureMilliCZone3")]
    public TrailerStatReeferReturnAirTemperatureMilliCZone3TypeResponseBody? ReeferReturnAirTemperatureMilliCZone3 { get; set; }

    [JsonPropertyName("reeferRunMode")]
    public TrailerStatReeferRunModeTypeResponseBody? ReeferRunMode { get; set; }

    [JsonPropertyName("reeferSetPointTemperatureMilliCZone1")]
    public TrailerStatReeferSetPointTemperatureMilliCZone1TypeResponseBody? ReeferSetPointTemperatureMilliCZone1 { get; set; }

    [JsonPropertyName("reeferSetPointTemperatureMilliCZone2")]
    public TrailerStatReeferSetPointTemperatureMilliCZone2TypeResponseBody? ReeferSetPointTemperatureMilliCZone2 { get; set; }

    [JsonPropertyName("reeferSetPointTemperatureMilliCZone3")]
    public TrailerStatReeferSetPointTemperatureMilliCZone3TypeResponseBody? ReeferSetPointTemperatureMilliCZone3 { get; set; }

    [JsonPropertyName("reeferStateZone1")]
    public TrailerStatReeferStateZone1TypeResponseBody? ReeferStateZone1 { get; set; }

    [JsonPropertyName("reeferStateZone2")]
    public TrailerStatReeferStateZone2TypeResponseBody? ReeferStateZone2 { get; set; }

    [JsonPropertyName("reeferStateZone3")]
    public TrailerStatReeferStateZone3TypeResponseBody? ReeferStateZone3 { get; set; }

    [JsonPropertyName("reeferSupplyAirTemperatureMilliCZone1")]
    public TrailerStatReeferSupplyAirTemperatureMilliCZone1TypeResponseBody? ReeferSupplyAirTemperatureMilliCZone1 { get; set; }

    [JsonPropertyName("reeferSupplyAirTemperatureMilliCZone2")]
    public TrailerStatReeferSupplyAirTemperatureMilliCZone2TypeResponseBody? ReeferSupplyAirTemperatureMilliCZone2 { get; set; }

    [JsonPropertyName("reeferSupplyAirTemperatureMilliCZone3")]
    public TrailerStatReeferSupplyAirTemperatureMilliCZone3TypeResponseBody? ReeferSupplyAirTemperatureMilliCZone3 { get; set; }

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
