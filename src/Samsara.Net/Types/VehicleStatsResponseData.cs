using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A vehicle and its most recent stat.
/// </summary>
public record VehicleStatsResponseData
{
    [JsonPropertyName("ambientAirTemperatureMilliC")]
    public VehicleStatsAmbientAirTempMilliC? AmbientAirTemperatureMilliC { get; set; }

    [JsonPropertyName("auxInput1")]
    public VehicleStatsAuxInput? AuxInput1 { get; set; }

    [JsonPropertyName("auxInput10")]
    public VehicleStatsAuxInput? AuxInput10 { get; set; }

    [JsonPropertyName("auxInput11")]
    public VehicleStatsAuxInput? AuxInput11 { get; set; }

    [JsonPropertyName("auxInput12")]
    public VehicleStatsAuxInput? AuxInput12 { get; set; }

    [JsonPropertyName("auxInput13")]
    public VehicleStatsAuxInput? AuxInput13 { get; set; }

    [JsonPropertyName("auxInput2")]
    public VehicleStatsAuxInput? AuxInput2 { get; set; }

    [JsonPropertyName("auxInput3")]
    public VehicleStatsAuxInput? AuxInput3 { get; set; }

    [JsonPropertyName("auxInput4")]
    public VehicleStatsAuxInput? AuxInput4 { get; set; }

    [JsonPropertyName("auxInput5")]
    public VehicleStatsAuxInput? AuxInput5 { get; set; }

    [JsonPropertyName("auxInput6")]
    public VehicleStatsAuxInput? AuxInput6 { get; set; }

    [JsonPropertyName("auxInput7")]
    public VehicleStatsAuxInput? AuxInput7 { get; set; }

    [JsonPropertyName("auxInput8")]
    public VehicleStatsAuxInput? AuxInput8 { get; set; }

    [JsonPropertyName("auxInput9")]
    public VehicleStatsAuxInput? AuxInput9 { get; set; }

    [JsonPropertyName("barometricPressurePa")]
    public VehicleStatsBarometricPressurePa? BarometricPressurePa { get; set; }

    [JsonPropertyName("batteryMilliVolts")]
    public VehicleStatsBatteryVoltage? BatteryMilliVolts { get; set; }

    [JsonPropertyName("defLevelMilliPercent")]
    public VehicleStatsDefLevelMilliPercent? DefLevelMilliPercent { get; set; }

    [JsonPropertyName("ecuSpeedMph")]
    public VehicleStatsEcuSpeedMph? EcuSpeedMph { get; set; }

    [JsonPropertyName("engineCoolantTemperatureMilliC")]
    public VehicleStatsEngineCoolantTempMilliC? EngineCoolantTemperatureMilliC { get; set; }

    [JsonPropertyName("engineImmobilizer")]
    public VehicleStatsEngineImmobilizer? EngineImmobilizer { get; set; }

    [JsonPropertyName("engineLoadPercent")]
    public VehicleStatsEngineLoadPercent? EngineLoadPercent { get; set; }

    [JsonPropertyName("engineOilPressureKPa")]
    public VehicleStatsEngineOilPressureKPa? EngineOilPressureKPa { get; set; }

    [JsonPropertyName("engineRpm")]
    public VehicleStatsEngineRpm? EngineRpm { get; set; }

    [JsonPropertyName("engineState")]
    public VehicleStatsEngineState? EngineState { get; set; }

    [JsonPropertyName("evAverageBatteryTemperatureMilliCelsius")]
    public VehicleStatsResponseEvAverageBatteryTemperatureMilliCelsius? EvAverageBatteryTemperatureMilliCelsius { get; set; }

    [JsonPropertyName("evBatteryCurrentMilliAmp")]
    public VehicleStatsResponseEvBatteryCurrentMilliAmp? EvBatteryCurrentMilliAmp { get; set; }

    [JsonPropertyName("evBatteryStateOfHealthMilliPercent")]
    public VehicleStatsResponseEvBatteryStateOfHealthMilliPercent? EvBatteryStateOfHealthMilliPercent { get; set; }

    [JsonPropertyName("evBatteryVoltageMilliVolt")]
    public VehicleStatsResponseEvBatteryVoltageMilliVolt? EvBatteryVoltageMilliVolt { get; set; }

    [JsonPropertyName("evChargingCurrentMilliAmp")]
    public VehicleStatsResponseEvChargingCurrentMilliAmp? EvChargingCurrentMilliAmp { get; set; }

    [JsonPropertyName("evChargingEnergyMicroWh")]
    public VehicleStatsResponseEvChargingEnergyMicroWh? EvChargingEnergyMicroWh { get; set; }

    [JsonPropertyName("evChargingStatus")]
    public VehicleStatsResponseEvChargingStatus? EvChargingStatus { get; set; }

    [JsonPropertyName("evChargingVoltageMilliVolt")]
    public VehicleStatsResponseEvChargingVoltageMilliVolt? EvChargingVoltageMilliVolt { get; set; }

    [JsonPropertyName("evConsumedEnergyMicroWh")]
    public VehicleStatsResponseEvConsumedEnergyMicroWh? EvConsumedEnergyMicroWh { get; set; }

    [JsonPropertyName("evDistanceDrivenMeters")]
    public VehicleStatsResponseEvDistanceDrivenMeters? EvDistanceDrivenMeters { get; set; }

    [JsonPropertyName("evRegeneratedEnergyMicroWh")]
    public VehicleStatsResponseEvRegeneratedEnergyMicroWh? EvRegeneratedEnergyMicroWh { get; set; }

    [JsonPropertyName("evStateOfChargeMilliPercent")]
    public VehicleStatsResponseEvStateOfChargeMilliPercent? EvStateOfChargeMilliPercent { get; set; }

    [JsonPropertyName("externalIds")]
    public object? ExternalIds { get; set; }

    [JsonPropertyName("faultCodes")]
    public VehicleStatsFaultCodes? FaultCodes { get; set; }

    [JsonPropertyName("fuelPercent")]
    public VehicleStatsFuelPercent? FuelPercent { get; set; }

    [JsonPropertyName("gps")]
    public VehicleStatsGps? Gps { get; set; }

    [JsonPropertyName("gpsDistanceMeters")]
    public VehicleStatsGpsDistanceMeters? GpsDistanceMeters { get; set; }

    [JsonPropertyName("gpsOdometerMeters")]
    public VehicleStatsGpsOdometerMeters? GpsOdometerMeters { get; set; }

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("intakeManifoldTemperatureMilliC")]
    public VehicleStatsIntakeManifoldTempMilliC? IntakeManifoldTemperatureMilliC { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("nfcCardScan")]
    public VehicleStatsNfcCardScan? NfcCardScan { get; set; }

    [JsonPropertyName("obdEngineSeconds")]
    public VehicleStatsObdEngineSeconds? ObdEngineSeconds { get; set; }

    [JsonPropertyName("obdOdometerMeters")]
    public VehicleStatsObdOdometerMeters? ObdOdometerMeters { get; set; }

    [JsonPropertyName("seatbeltDriver")]
    public VehicleStatsResponseSeatbeltDriver? SeatbeltDriver { get; set; }

    [JsonPropertyName("spreaderActive")]
    public VehicleStatsResponseSpreaderActive? SpreaderActive { get; set; }

    [JsonPropertyName("spreaderAirTemp")]
    public VehicleStatsResponseSpreaderAirTemp? SpreaderAirTemp { get; set; }

    [JsonPropertyName("spreaderBlastState")]
    public VehicleStatsResponseSpreaderBlastState? SpreaderBlastState { get; set; }

    [JsonPropertyName("spreaderGranularName")]
    public VehicleStatsResponseSpreaderGranularName? SpreaderGranularName { get; set; }

    [JsonPropertyName("spreaderGranularRate")]
    public VehicleStatsResponseSpreaderGranularRate? SpreaderGranularRate { get; set; }

    [JsonPropertyName("spreaderLiquidName")]
    public VehicleStatsResponseSpreaderLiquidName? SpreaderLiquidName { get; set; }

    [JsonPropertyName("spreaderLiquidRate")]
    public VehicleStatsResponseSpreaderLiquidRate? SpreaderLiquidRate { get; set; }

    [JsonPropertyName("spreaderOnState")]
    public VehicleStatsResponseSpreaderOnState? SpreaderOnState { get; set; }

    [JsonPropertyName("spreaderPlowStatus")]
    public VehicleStatsResponseSpreaderPlowStatus? SpreaderPlowStatus { get; set; }

    [JsonPropertyName("spreaderPrewetName")]
    public VehicleStatsResponseSpreaderPrewetName? SpreaderPrewetName { get; set; }

    [JsonPropertyName("spreaderPrewetRate")]
    public VehicleStatsResponseSpreaderPrewetRate? SpreaderPrewetRate { get; set; }

    [JsonPropertyName("spreaderRoadTemp")]
    public VehicleStatsResponseSpreaderRoadTemp? SpreaderRoadTemp { get; set; }

    [JsonPropertyName("syntheticEngineSeconds")]
    public VehicleStatsSyntheticEngineSeconds? SyntheticEngineSeconds { get; set; }

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
