using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Optional decorations to the primary stat event. See [here](doc:decorations) for more details. The example shows the response if you were to submit `decorations=engineStates&obdEngineSeconds` to the query parameter:
///
/// ```json
/// "decorations":{
///   "engineStates": {
///     "value": "Off"
///   },
///   "obdEngineSeconds": {
///     "value": 9723103
///   }
/// }
/// ```
/// </summary>
public record VehicleStatsDecorations
{
    [JsonPropertyName("ambientAirTemperatureMilliC")]
    public VehicleStatsDecorationsAmbientAirTemperatureMilliC? AmbientAirTemperatureMilliC { get; set; }

    [JsonPropertyName("auxInput1")]
    public VehicleStatsAuxInputDecoration? AuxInput1 { get; set; }

    [JsonPropertyName("auxInput10")]
    public VehicleStatsAuxInputDecoration? AuxInput10 { get; set; }

    [JsonPropertyName("auxInput11")]
    public VehicleStatsAuxInputDecoration? AuxInput11 { get; set; }

    [JsonPropertyName("auxInput12")]
    public VehicleStatsAuxInputDecoration? AuxInput12 { get; set; }

    [JsonPropertyName("auxInput13")]
    public VehicleStatsAuxInputDecoration? AuxInput13 { get; set; }

    [JsonPropertyName("auxInput2")]
    public VehicleStatsAuxInputDecoration? AuxInput2 { get; set; }

    [JsonPropertyName("auxInput3")]
    public VehicleStatsAuxInputDecoration? AuxInput3 { get; set; }

    [JsonPropertyName("auxInput4")]
    public VehicleStatsAuxInputDecoration? AuxInput4 { get; set; }

    [JsonPropertyName("auxInput5")]
    public VehicleStatsAuxInputDecoration? AuxInput5 { get; set; }

    [JsonPropertyName("auxInput6")]
    public VehicleStatsAuxInputDecoration? AuxInput6 { get; set; }

    [JsonPropertyName("auxInput7")]
    public VehicleStatsAuxInputDecoration? AuxInput7 { get; set; }

    [JsonPropertyName("auxInput8")]
    public VehicleStatsAuxInputDecoration? AuxInput8 { get; set; }

    [JsonPropertyName("auxInput9")]
    public VehicleStatsAuxInputDecoration? AuxInput9 { get; set; }

    [JsonPropertyName("barometricPressurePa")]
    public VehicleStatsDecorationsBarometricPressurePa? BarometricPressurePa { get; set; }

    [JsonPropertyName("batteryMilliVolts")]
    public VehicleStatsDecorationsBatteryMilliVolts? BatteryMilliVolts { get; set; }

    [JsonPropertyName("defLevelMilliPercent")]
    public VehicleStatsDecorationsDefLevelMilliPercent? DefLevelMilliPercent { get; set; }

    [JsonPropertyName("ecuSpeedMph")]
    public VehicleStatsDecorationsEcuSpeedMph? EcuSpeedMph { get; set; }

    [JsonPropertyName("engineCoolantTemperatureMilliC")]
    public VehicleStatsDecorationsEngineCoolantTemperatureMilliC? EngineCoolantTemperatureMilliC { get; set; }

    [JsonPropertyName("engineImmobilizer")]
    public VehicleStatsEngineImmobilizer? EngineImmobilizer { get; set; }

    [JsonPropertyName("engineLoadPercent")]
    public VehicleStatsDecorationsEngineLoadPercent? EngineLoadPercent { get; set; }

    [JsonPropertyName("engineOilPressureKPa")]
    public VehicleStatsDecorationsEngineOilPressureKPa? EngineOilPressureKPa { get; set; }

    [JsonPropertyName("engineRpm")]
    public VehicleStatsDecorationsEngineRpm? EngineRpm { get; set; }

    [JsonPropertyName("engineStates")]
    public VehicleStatsDecorationsEngineStates? EngineStates { get; set; }

    [JsonPropertyName("evAverageBatteryTemperatureMilliCelsius")]
    public VehicleStatsEvAverageBatteryTemperatureMilliCelsius? EvAverageBatteryTemperatureMilliCelsius { get; set; }

    [JsonPropertyName("evBatteryCurrentMilliAmp")]
    public VehicleStatsEvBatteryCurrentMilliAmp? EvBatteryCurrentMilliAmp { get; set; }

    [JsonPropertyName("evBatteryStateOfHealthMilliPercent")]
    public VehicleStatsEvBatteryStateOfHealthMilliPercent? EvBatteryStateOfHealthMilliPercent { get; set; }

    [JsonPropertyName("evBatteryVoltageMilliVolt")]
    public VehicleStatsEvBatteryVoltageMilliVolt? EvBatteryVoltageMilliVolt { get; set; }

    [JsonPropertyName("evChargingCurrentMilliAmp")]
    public VehicleStatsEvChargingCurrentMilliAmp? EvChargingCurrentMilliAmp { get; set; }

    [JsonPropertyName("evChargingEnergyMicroWh")]
    public VehicleStatsEvChargingEnergyMicroWh? EvChargingEnergyMicroWh { get; set; }

    [JsonPropertyName("evChargingStatus")]
    public VehicleStatsEvChargingStatus? EvChargingStatus { get; set; }

    [JsonPropertyName("evChargingVoltageMilliVolt")]
    public VehicleStatsEvChargingVoltageMilliVolt? EvChargingVoltageMilliVolt { get; set; }

    [JsonPropertyName("evConsumedEnergyMicroWh")]
    public VehicleStatsEvConsumedEnergyMicroWh? EvConsumedEnergyMicroWh { get; set; }

    [JsonPropertyName("evDistanceDrivenMeters")]
    public VehicleStatsEvDistanceDrivenMeters? EvDistanceDrivenMeters { get; set; }

    [JsonPropertyName("evRegeneratedEnergyMicroWh")]
    public VehicleStatsEvRegeneratedEnergyMicroWh? EvRegeneratedEnergyMicroWh { get; set; }

    [JsonPropertyName("evStateOfChargeMilliPercent")]
    public VehicleStatsEvStateOfChargeMilliPercent? EvStateOfChargeMilliPercent { get; set; }

    [JsonPropertyName("faultCodes")]
    public VehicleStatsFaultCodesValue? FaultCodes { get; set; }

    [JsonPropertyName("fuelPercents")]
    public VehicleStatsDecorationsFuelPercents? FuelPercents { get; set; }

    [JsonPropertyName("gps")]
    public VehicleStatsDecorationsGps? Gps { get; set; }

    [JsonPropertyName("gpsDistanceMeters")]
    public VehicleStatsDecorationsGpsDistanceMeters? GpsDistanceMeters { get; set; }

    [JsonPropertyName("gpsOdometerMeters")]
    public VehicleStatsDecorationsGpsOdometerMeters? GpsOdometerMeters { get; set; }

    [JsonPropertyName("intakeManifoldTemperatureMilliC")]
    public VehicleStatsDecorationsIntakeManifoldTemperatureMilliC? IntakeManifoldTemperatureMilliC { get; set; }

    [JsonPropertyName("obdEngineSeconds")]
    public VehicleStatsDecorationsObdEngineSeconds? ObdEngineSeconds { get; set; }

    [JsonPropertyName("obdOdometerMeters")]
    public VehicleStatsDecorationsObdOdometerMeters? ObdOdometerMeters { get; set; }

    [JsonPropertyName("seatbeltDriver")]
    public VehicleStatsSeatbeltDriver? SeatbeltDriver { get; set; }

    [JsonPropertyName("spreaderActive")]
    public VehicleStatsSpreaderActive? SpreaderActive { get; set; }

    [JsonPropertyName("spreaderAirTemp")]
    public VehicleStatsSpreaderAirTemp? SpreaderAirTemp { get; set; }

    [JsonPropertyName("spreaderBlastState")]
    public VehicleStatsSpreaderBlastState? SpreaderBlastState { get; set; }

    [JsonPropertyName("spreaderGranularName")]
    public VehicleStatsSpreaderGranularName? SpreaderGranularName { get; set; }

    [JsonPropertyName("spreaderGranularRate")]
    public VehicleStatsSpreaderGranularRate? SpreaderGranularRate { get; set; }

    [JsonPropertyName("spreaderLiquidName")]
    public VehicleStatsSpreaderLiquidName? SpreaderLiquidName { get; set; }

    [JsonPropertyName("spreaderLiquidRate")]
    public VehicleStatsSpreaderLiquidRate? SpreaderLiquidRate { get; set; }

    [JsonPropertyName("spreaderOnState")]
    public VehicleStatsSpreaderOnState? SpreaderOnState { get; set; }

    [JsonPropertyName("spreaderPlowStatus")]
    public VehicleStatsSpreaderPlowStatus? SpreaderPlowStatus { get; set; }

    [JsonPropertyName("spreaderPrewetName")]
    public VehicleStatsSpreaderPrewetName? SpreaderPrewetName { get; set; }

    [JsonPropertyName("spreaderPrewetRate")]
    public VehicleStatsSpreaderPrewetRate? SpreaderPrewetRate { get; set; }

    [JsonPropertyName("spreaderRoadTemp")]
    public VehicleStatsSpreaderRoadTemp? SpreaderRoadTemp { get; set; }

    [JsonPropertyName("tirePressure")]
    public VehicleStatsTirePressures? TirePressure { get; set; }

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
