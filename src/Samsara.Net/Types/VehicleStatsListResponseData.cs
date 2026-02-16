using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A vehicle and its list of stat events.
/// </summary>
[Serializable]
public record VehicleStatsListResponseData : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of ambient air temperature readings in millidegree Celsius for the given vehicle.
    /// </summary>
    [JsonPropertyName("ambientAirTemperatureMilliC")]
    public IEnumerable<VehicleStatsAmbientAirTempMilliCWithDecoration>? AmbientAirTemperatureMilliC { get; set; }

    /// <summary>
    /// A list of auxiliary equipment states.
    /// </summary>
    [JsonPropertyName("auxInput1")]
    public IEnumerable<VehicleStatsAuxInputWithDecoration>? AuxInput1 { get; set; }

    /// <summary>
    /// A list of auxiliary equipment states.
    /// </summary>
    [JsonPropertyName("auxInput10")]
    public IEnumerable<VehicleStatsAuxInputWithDecoration>? AuxInput10 { get; set; }

    /// <summary>
    /// A list of auxiliary equipment states.
    /// </summary>
    [JsonPropertyName("auxInput11")]
    public IEnumerable<VehicleStatsAuxInputWithDecoration>? AuxInput11 { get; set; }

    /// <summary>
    /// A list of auxiliary equipment states.
    /// </summary>
    [JsonPropertyName("auxInput12")]
    public IEnumerable<VehicleStatsAuxInputWithDecoration>? AuxInput12 { get; set; }

    /// <summary>
    /// A list of auxiliary equipment states.
    /// </summary>
    [JsonPropertyName("auxInput13")]
    public IEnumerable<VehicleStatsAuxInputWithDecoration>? AuxInput13 { get; set; }

    /// <summary>
    /// A list of auxiliary equipment states.
    /// </summary>
    [JsonPropertyName("auxInput2")]
    public IEnumerable<VehicleStatsAuxInputWithDecoration>? AuxInput2 { get; set; }

    /// <summary>
    /// A list of auxiliary equipment states.
    /// </summary>
    [JsonPropertyName("auxInput3")]
    public IEnumerable<VehicleStatsAuxInputWithDecoration>? AuxInput3 { get; set; }

    /// <summary>
    /// A list of auxiliary equipment states.
    /// </summary>
    [JsonPropertyName("auxInput4")]
    public IEnumerable<VehicleStatsAuxInputWithDecoration>? AuxInput4 { get; set; }

    /// <summary>
    /// A list of auxiliary equipment states.
    /// </summary>
    [JsonPropertyName("auxInput5")]
    public IEnumerable<VehicleStatsAuxInputWithDecoration>? AuxInput5 { get; set; }

    /// <summary>
    /// A list of auxiliary equipment states.
    /// </summary>
    [JsonPropertyName("auxInput6")]
    public IEnumerable<VehicleStatsAuxInputWithDecoration>? AuxInput6 { get; set; }

    /// <summary>
    /// A list of auxiliary equipment states.
    /// </summary>
    [JsonPropertyName("auxInput7")]
    public IEnumerable<VehicleStatsAuxInputWithDecoration>? AuxInput7 { get; set; }

    /// <summary>
    /// A list of auxiliary equipment states.
    /// </summary>
    [JsonPropertyName("auxInput8")]
    public IEnumerable<VehicleStatsAuxInputWithDecoration>? AuxInput8 { get; set; }

    /// <summary>
    /// A list of auxiliary equipment states.
    /// </summary>
    [JsonPropertyName("auxInput9")]
    public IEnumerable<VehicleStatsAuxInputWithDecoration>? AuxInput9 { get; set; }

    /// <summary>
    /// A list of barometric pressure readings in pascals for the given vehicle.
    /// </summary>
    [JsonPropertyName("barometricPressurePa")]
    public IEnumerable<VehicleStatsBarometricPressurePaWithDecoration>? BarometricPressurePa { get; set; }

    /// <summary>
    /// A list of battery levels in milliVolts for the given vehicle.
    /// </summary>
    [JsonPropertyName("batteryMilliVolts")]
    public IEnumerable<VehicleStatsBatteryVoltageWithDecoration>? BatteryMilliVolts { get; set; }

    /// <summary>
    /// A list of DEF level milli percentage readings for the given vehicle.
    /// </summary>
    [JsonPropertyName("defLevelMilliPercent")]
    public IEnumerable<VehicleStatsDefLevelMilliPercentWithDecoration>? DefLevelMilliPercent { get; set; }

    /// <summary>
    /// Door status as read from the vehicle (either from ECU or AUX as a fallback).
    /// </summary>
    [JsonPropertyName("ecuDoorStatus")]
    public IEnumerable<VehicleStatsEcuDoorStatus>? EcuDoorStatus { get; set; }

    /// <summary>
    /// A list of the speeds of the vehicle in miles per hour, as reported by the ECU.
    /// </summary>
    [JsonPropertyName("ecuSpeedMph")]
    public IEnumerable<VehicleStatsEcuSpeedMphWithDecoration>? EcuSpeedMph { get; set; }

    /// <summary>
    /// A list of engine coolant temperature readings in millidegree Celsius for the given vehicle.
    /// </summary>
    [JsonPropertyName("engineCoolantTemperatureMilliC")]
    public IEnumerable<VehicleStatsEngineCoolantTempMilliCWithDecoration>? EngineCoolantTemperatureMilliC { get; set; }

    /// <summary>
    /// A list of engine immobilizer data for the given vehicle.
    /// </summary>
    [JsonPropertyName("engineImmobilizer")]
    public IEnumerable<VehicleStatsEngineImmobilizerWithDecoration>? EngineImmobilizer { get; set; }

    /// <summary>
    /// A list of engine load percentage readings for the given vehicle.
    /// </summary>
    [JsonPropertyName("engineLoadPercent")]
    public IEnumerable<VehicleStatsEngineLoadPercentWithDecoration>? EngineLoadPercent { get; set; }

    /// <summary>
    /// A list of engine oil pressure readings in kilopascals for the given vehicle.
    /// </summary>
    [JsonPropertyName("engineOilPressureKPa")]
    public IEnumerable<VehicleStatsEngineOilPressureKPaWithDecoration>? EngineOilPressureKPa { get; set; }

    /// <summary>
    /// A list engine RPM values for the given vehicle.
    /// </summary>
    [JsonPropertyName("engineRpm")]
    public IEnumerable<VehicleStatsEngineRpmWithDecoration>? EngineRpm { get; set; }

    /// <summary>
    /// A list of engine state events for the given vehicle.
    /// </summary>
    [JsonPropertyName("engineStates")]
    public IEnumerable<VehicleStatsEngineStateWithDecoration>? EngineStates { get; set; }

    /// <summary>
    /// Battery temperature for electric and hybrid vehicles in milli celsius. Not all EV and HEVs may report this field.
    /// </summary>
    [JsonPropertyName("evAverageBatteryTemperatureMilliCelsius")]
    public IEnumerable<VehicleStatsEvAverageBatteryTemperatureMilliCelsius>? EvAverageBatteryTemperatureMilliCelsius { get; set; }

    /// <summary>
    /// Battery current for electric and hybrid vehicles in milli amps. Not all EV and HEVs may report this field.
    /// </summary>
    [JsonPropertyName("evBatteryCurrentMilliAmp")]
    public IEnumerable<VehicleStatsEvBatteryCurrentMilliAmp>? EvBatteryCurrentMilliAmp { get; set; }

    /// <summary>
    /// Milli percent battery state of health for electric and hybrid vehicles. Not all EV and HEVs may report this field.
    /// </summary>
    [JsonPropertyName("evBatteryStateOfHealthMilliPercent")]
    public IEnumerable<VehicleStatsEvBatteryStateOfHealthMilliPercent>? EvBatteryStateOfHealthMilliPercent { get; set; }

    /// <summary>
    /// Battery voltage for electric and hybrid vehicles in milli volts. Not all EV and HEVs may report this field.
    /// </summary>
    [JsonPropertyName("evBatteryVoltageMilliVolt")]
    public IEnumerable<VehicleStatsEvBatteryVoltageMilliVolt>? EvBatteryVoltageMilliVolt { get; set; }

    /// <summary>
    /// Charging current for electric and hybrid vehicles in milli amps. Not all EV and HEVs may report this field.
    /// </summary>
    [JsonPropertyName("evChargingCurrentMilliAmp")]
    public IEnumerable<VehicleStatsEvChargingCurrentMilliAmp>? EvChargingCurrentMilliAmp { get; set; }

    /// <summary>
    /// Charging energy for electric and hybrid vehicles in microwatt hours. Not all EV and HEVs may report this field.
    /// </summary>
    [JsonPropertyName("evChargingEnergyMicroWh")]
    public IEnumerable<VehicleStatsEvChargingEnergyMicroWh>? EvChargingEnergyMicroWh { get; set; }

    /// <summary>
    /// Charging status for electric and hybrid vehicles. Not all EV and HEVs may report this field.
    /// </summary>
    [JsonPropertyName("evChargingStatus")]
    public IEnumerable<VehicleStatsEvChargingStatus>? EvChargingStatus { get; set; }

    /// <summary>
    /// Charging voltage for electric and hybrid vehicles in milli  volts. Not all EV and HEVs may report this field.
    /// </summary>
    [JsonPropertyName("evChargingVoltageMilliVolt")]
    public IEnumerable<VehicleStatsEvChargingVoltageMilliVolt>? EvChargingVoltageMilliVolt { get; set; }

    /// <summary>
    /// Consumed energy (including regenerated) for electric and hybrid vehicles in microwatt hours. Not all EV and HEVs may report this field.
    /// </summary>
    [JsonPropertyName("evConsumedEnergyMicroWh")]
    public IEnumerable<VehicleStatsEvConsumedEnergyMicroWh>? EvConsumedEnergyMicroWh { get; set; }

    /// <summary>
    /// Electric distance driven for electric and hybrid vehicles in meters. Not all EV and HEVs may report this field.
    /// </summary>
    [JsonPropertyName("evDistanceDrivenMeters")]
    public IEnumerable<VehicleStatsEvDistanceDrivenMeters>? EvDistanceDrivenMeters { get; set; }

    /// <summary>
    /// Regenerated energy for electric and hybrid vehicles in microwatt hours. Not all EV and HEVs may report this field.
    /// </summary>
    [JsonPropertyName("evRegeneratedEnergyMicroWh")]
    public IEnumerable<VehicleStatsEvRegeneratedEnergyMicroWh>? EvRegeneratedEnergyMicroWh { get; set; }

    /// <summary>
    /// State of Charge for electric and hybrid vehicles. Not all EV and HEVs may report this field.
    /// </summary>
    [JsonPropertyName("evStateOfChargeMilliPercent")]
    public IEnumerable<VehicleStatsEvStateOfChargeMilliPercent>? EvStateOfChargeMilliPercent { get; set; }

    [JsonPropertyName("externalIds")]
    public Dictionary<string, object?>? ExternalIds { get; set; }

    /// <summary>
    /// A list of engine fault codes.
    /// </summary>
    [JsonPropertyName("faultCodes")]
    public IEnumerable<VehicleStatsFaultCodesWithDecoration>? FaultCodes { get; set; }

    /// <summary>
    /// A list of cumulative fuel consumption readings in milliliters for the given vehicle. Cumulative values always increase. This includes all fuel consumption reported by vehicles without filtering of invalid data points. For filtered fuel consumption that matches the Fuel & Energy Report, please use <a href="https://developers.samsara.com/reference/getfuelenergyvehiclereports" target="_blank">the Fuel and Energy API</a>.
    /// </summary>
    [JsonPropertyName("fuelConsumedMilliliters")]
    public IEnumerable<VehicleStatsFuelConsumedMillilitersWithDecoration>? FuelConsumedMilliliters { get; set; }

    /// <summary>
    /// A list of fuel percentage readings for the given vehicle.
    /// </summary>
    [JsonPropertyName("fuelPercents")]
    public IEnumerable<VehicleStatsFuelPercentWithDecoration>? FuelPercents { get; set; }

    /// <summary>
    /// A list of GPS location events for the given vehicles.
    /// </summary>
    [JsonPropertyName("gps")]
    public IEnumerable<VehicleStatsListGps>? Gps { get; set; }

    /// <summary>
    /// A list of GPS distance events for the given vehicle.
    /// </summary>
    [JsonPropertyName("gpsDistanceMeters")]
    public IEnumerable<VehicleStatsGpsDistanceMetersWithDecoration>? GpsDistanceMeters { get; set; }

    /// <summary>
    /// A list of GPS odometer events for the given vehicle.
    /// </summary>
    [JsonPropertyName("gpsOdometerMeters")]
    public IEnumerable<VehicleStatsGpsOdometerMetersWithDecoration>? GpsOdometerMeters { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// A list of cumulative idling duration readings in milliseconds for the given vehicle. Cumulative values always increase. For filtering of idling duration please use <a href="https://developers.samsara.com/reference/getvehicleidlingreports" target="_blank">the Idling Events API</a>.
    /// </summary>
    [JsonPropertyName("idlingDurationMilliseconds")]
    public IEnumerable<VehicleStatsIdlingDurationMillisecondsWithDecoration>? IdlingDurationMilliseconds { get; set; }

    /// <summary>
    /// A list of intake manifold temperature readings in millidegree Celsius for the given vehicle.
    /// </summary>
    [JsonPropertyName("intakeManifoldTemperatureMilliC")]
    public IEnumerable<VehicleStatsIntakeManifoldTempMilliCWithDecoration>? IntakeManifoldTemperatureMilliC { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// A list of NFC cards that were scanned for the given vehicles.
    /// </summary>
    [JsonPropertyName("nfcCardScans")]
    public IEnumerable<VehicleStatsNfcCardScanWithDecoration>? NfcCardScans { get; set; }

    /// <summary>
    /// A list of OBD engine seconds readings for the given vehicle.
    /// </summary>
    [JsonPropertyName("obdEngineSeconds")]
    public IEnumerable<VehicleStatsObdEngineSecondsWithDecoration>? ObdEngineSeconds { get; set; }

    /// <summary>
    /// A list of OBD odometer readings for the given vehicle.
    /// </summary>
    [JsonPropertyName("obdOdometerMeters")]
    public IEnumerable<VehicleStatsObdOdometerMetersWithDecoration>? ObdOdometerMeters { get; set; }

    /// <summary>
    /// Seatbelt Driver Status as read from the vehicle. `Buckled` or `Unbuckled`.
    /// </summary>
    [JsonPropertyName("seatbeltDriver")]
    public IEnumerable<VehicleStatsSeatbeltDriver>? SeatbeltDriver { get; set; }

    /// <summary>
    /// Whether vehicle is actively spreading any material.
    /// </summary>
    [JsonPropertyName("spreaderActive")]
    public IEnumerable<VehicleStatsSpreaderActive>? SpreaderActive { get; set; }

    /// <summary>
    /// Air (ambient) temperature in milli celsius reading from material spreader.
    /// </summary>
    [JsonPropertyName("spreaderAirTemp")]
    public IEnumerable<VehicleStatsSpreaderAirTemp>? SpreaderAirTemp { get; set; }

    /// <summary>
    /// Whether vehicle is actively spreading material in ‘blast mode’.
    /// </summary>
    [JsonPropertyName("spreaderBlastState")]
    public IEnumerable<VehicleStatsSpreaderBlastState>? SpreaderBlastState { get; set; }

    /// <summary>
    /// Name of most recent type of granular material spread, read from the material spreader.
    /// </summary>
    [JsonPropertyName("spreaderGranularName")]
    public IEnumerable<VehicleStatsSpreaderGranularName>? SpreaderGranularName { get; set; }

    /// <summary>
    /// Granular spread rate reading in milliliters per meter, read from the material spreader. Unfiltered live stats are supplied as-read from the Material Spreader unit. Readings do not consider total spread rate(s) over time or distance.
    /// </summary>
    [JsonPropertyName("spreaderGranularRate")]
    public IEnumerable<VehicleStatsSpreaderGranularRate>? SpreaderGranularRate { get; set; }

    /// <summary>
    /// Name of most recent type of liquid material spread, read from the material spreader.
    /// </summary>
    [JsonPropertyName("spreaderLiquidName")]
    public IEnumerable<VehicleStatsSpreaderLiquidName>? SpreaderLiquidName { get; set; }

    /// <summary>
    /// Liquid spread rate reading in milliliters per meter, read from the material spreader. Unfiltered live stats are supplied as-read from the Material Spreader unit. Readings do not consider total spread rate(s) over time or distance.
    /// </summary>
    [JsonPropertyName("spreaderLiquidRate")]
    public IEnumerable<VehicleStatsSpreaderLiquidRate>? SpreaderLiquidRate { get; set; }

    /// <summary>
    /// Whether vehicle spreader is enabled.
    /// </summary>
    [JsonPropertyName("spreaderOnState")]
    public IEnumerable<VehicleStatsSpreaderOnState>? SpreaderOnState { get; set; }

    /// <summary>
    /// Snow plow status (`Up` or `Down`), as read from the material spreader. Note: this is separate from plow status defined via auxInput.
    /// </summary>
    [JsonPropertyName("spreaderPlowStatus")]
    public IEnumerable<VehicleStatsSpreaderPlowStatus>? SpreaderPlowStatus { get; set; }

    /// <summary>
    /// Name of most recent type of prewet material spread, read from the material spreader.
    /// </summary>
    [JsonPropertyName("spreaderPrewetName")]
    public IEnumerable<VehicleStatsSpreaderPrewetName>? SpreaderPrewetName { get; set; }

    /// <summary>
    /// Prewet spread rate reading in milliliters per meter, read from the material spreader. Unfiltered live stats are supplied as-read from the Material Spreader unit. Readings do not consider total spread rate(s) over time or distance.
    /// </summary>
    [JsonPropertyName("spreaderPrewetRate")]
    public IEnumerable<VehicleStatsSpreaderPrewetRate>? SpreaderPrewetRate { get; set; }

    /// <summary>
    /// Road temperature reading in milli celsius from material spreader.
    /// </summary>
    [JsonPropertyName("spreaderRoadTemp")]
    public IEnumerable<VehicleStatsSpreaderRoadTemp>? SpreaderRoadTemp { get; set; }

    /// <summary>
    /// A list of synthetic engine seconds values.
    /// </summary>
    [JsonPropertyName("syntheticEngineSeconds")]
    public IEnumerable<VehicleStatsListSyntheticEngineSeconds>? SyntheticEngineSeconds { get; set; }

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
