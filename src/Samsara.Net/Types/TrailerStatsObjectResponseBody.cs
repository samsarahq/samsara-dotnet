using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A trailer and its stats
/// </summary>
[Serializable]
public record TrailerStatsObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of engine state points.
    /// </summary>
    [JsonPropertyName("carrierReeferState")]
    public IEnumerable<TrailerStatReeferStateWithDecorationsTypeResponseBody>? CarrierReeferState { get; set; }

    /// <summary>
    /// A list of GPS points.
    /// </summary>
    [JsonPropertyName("gps")]
    public IEnumerable<TrailerStatGpsWithDecorationsTypeResponseBody>? Gps { get; set; }

    /// <summary>
    /// A list of odometer points.
    /// </summary>
    [JsonPropertyName("gpsOdometerMeters")]
    public IEnumerable<TrailerStatGpsOdometerMetersWithDecorationsTypeResponseBody>? GpsOdometerMeters { get; set; }

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

    /// <summary>
    /// A list of reefer alarm points.
    /// </summary>
    [JsonPropertyName("reeferAlarms")]
    public IEnumerable<TrailerStatReeferAlarmWithDecorationsTypeResponseBody>? ReeferAlarms { get; set; }

    /// <summary>
    /// A list of ambient air temperature points.
    /// </summary>
    [JsonPropertyName("reeferAmbientAirTemperatureMilliC")]
    public IEnumerable<TrailerStatReeferAmbientAirTemperatureWithDecorationsTypeResponseBody>? ReeferAmbientAirTemperatureMilliC { get; set; }

    /// <summary>
    /// A list of door state points.
    /// </summary>
    [JsonPropertyName("reeferDoorStateZone1")]
    public IEnumerable<TrailerStatReeferDoorStateZone1WithDecorationsTypeResponseBody>? ReeferDoorStateZone1 { get; set; }

    /// <summary>
    /// A list of door state points.
    /// </summary>
    [JsonPropertyName("reeferDoorStateZone2")]
    public IEnumerable<TrailerStatReeferDoorStateZone2WithDecorationsTypeResponseBody>? ReeferDoorStateZone2 { get; set; }

    /// <summary>
    /// A list of door state points.
    /// </summary>
    [JsonPropertyName("reeferDoorStateZone3")]
    public IEnumerable<TrailerStatReeferDoorStateZone3WithDecorationsTypeResponseBody>? ReeferDoorStateZone3 { get; set; }

    /// <summary>
    /// A list of fuel percent points.
    /// </summary>
    [JsonPropertyName("reeferFuelPercent")]
    public IEnumerable<TrailerStatReeferFuelPercentWithDecorationsTypeResponseBody>? ReeferFuelPercent { get; set; }

    /// <summary>
    /// A list of engine second points
    /// </summary>
    [JsonPropertyName("reeferObdEngineSeconds")]
    public IEnumerable<TrailerStatReeferObdEngineSecondsWithDecorationsTypeResponseBody>? ReeferObdEngineSeconds { get; set; }

    /// <summary>
    /// A list of return air temperature points.
    /// </summary>
    [JsonPropertyName("reeferReturnAirTemperatureMilliCZone1")]
    public IEnumerable<TrailerStatReeferReturnAirTemperatureMilliCZone1WithDecorationsTypeResponseBody>? ReeferReturnAirTemperatureMilliCZone1 { get; set; }

    /// <summary>
    /// A list of return air temperature points.
    /// </summary>
    [JsonPropertyName("reeferReturnAirTemperatureMilliCZone2")]
    public IEnumerable<TrailerStatReeferReturnAirTemperatureMilliCZone2WithDecorationsTypeResponseBody>? ReeferReturnAirTemperatureMilliCZone2 { get; set; }

    /// <summary>
    /// A list of return air temperature points.
    /// </summary>
    [JsonPropertyName("reeferReturnAirTemperatureMilliCZone3")]
    public IEnumerable<TrailerStatReeferReturnAirTemperatureMilliCZone3WithDecorationsTypeResponseBody>? ReeferReturnAirTemperatureMilliCZone3 { get; set; }

    /// <summary>
    /// A list of run mode points
    /// </summary>
    [JsonPropertyName("reeferRunMode")]
    public IEnumerable<TrailerStatReeferRunModeWithDecorationsTypeResponseBody>? ReeferRunMode { get; set; }

    /// <summary>
    /// A list of set point temperature points.
    /// </summary>
    [JsonPropertyName("reeferSetPointTemperatureMilliCZone1")]
    public IEnumerable<TrailerStatReeferSetPointTemperatureMilliCZone1WithDecorationsTypeResponseBody>? ReeferSetPointTemperatureMilliCZone1 { get; set; }

    /// <summary>
    /// A list of set point temperature points.
    /// </summary>
    [JsonPropertyName("reeferSetPointTemperatureMilliCZone2")]
    public IEnumerable<TrailerStatReeferSetPointTemperatureMilliCZone2WithDecorationsTypeResponseBody>? ReeferSetPointTemperatureMilliCZone2 { get; set; }

    /// <summary>
    /// A list of set point temperature points.
    /// </summary>
    [JsonPropertyName("reeferSetPointTemperatureMilliCZone3")]
    public IEnumerable<TrailerStatReeferSetPointTemperatureMilliCZone3WithDecorationsTypeResponseBody>? ReeferSetPointTemperatureMilliCZone3 { get; set; }

    /// <summary>
    /// A list of engine state points.
    /// </summary>
    [JsonPropertyName("reeferStateZone1")]
    public IEnumerable<TrailerStatReeferStateZone1WithDecorationsTypeResponseBody>? ReeferStateZone1 { get; set; }

    /// <summary>
    /// A list of engine state points.
    /// </summary>
    [JsonPropertyName("reeferStateZone2")]
    public IEnumerable<TrailerStatReeferStateZone2WithDecorationsTypeResponseBody>? ReeferStateZone2 { get; set; }

    /// <summary>
    /// A list of engine state points.
    /// </summary>
    [JsonPropertyName("reeferStateZone3")]
    public IEnumerable<TrailerStatReeferStateZone3WithDecorationsTypeResponseBody>? ReeferStateZone3 { get; set; }

    /// <summary>
    /// A list of supply air temperature points.
    /// </summary>
    [JsonPropertyName("reeferSupplyAirTemperatureMilliCZone1")]
    public IEnumerable<TrailerStatReeferSupplyAirTemperatureMilliCZone1WithDecorationsTypeResponseBody>? ReeferSupplyAirTemperatureMilliCZone1 { get; set; }

    /// <summary>
    /// A list of supply air temperature points.
    /// </summary>
    [JsonPropertyName("reeferSupplyAirTemperatureMilliCZone2")]
    public IEnumerable<TrailerStatReeferSupplyAirTemperatureMilliCZone2WithDecorationsTypeResponseBody>? ReeferSupplyAirTemperatureMilliCZone2 { get; set; }

    /// <summary>
    /// A list of supply air temperature points.
    /// </summary>
    [JsonPropertyName("reeferSupplyAirTemperatureMilliCZone3")]
    public IEnumerable<TrailerStatReeferSupplyAirTemperatureMilliCZone3WithDecorationsTypeResponseBody>? ReeferSupplyAirTemperatureMilliCZone3 { get; set; }

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
