using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.VehicleStats;

[JsonConverter(typeof(EnumSerializer<VehicleStatsGetVehicleStatsRequestTypesItem>))]
public enum VehicleStatsGetVehicleStatsRequestTypesItem
{
    [EnumMember(Value = "ambientAirTemperatureMilliC")]
    AmbientAirTemperatureMilliC,

    [EnumMember(Value = "auxInput1")]
    AuxInput1,

    [EnumMember(Value = "auxInput2")]
    AuxInput2,

    [EnumMember(Value = "auxInput3")]
    AuxInput3,

    [EnumMember(Value = "auxInput4")]
    AuxInput4,

    [EnumMember(Value = "auxInput5")]
    AuxInput5,

    [EnumMember(Value = "auxInput6")]
    AuxInput6,

    [EnumMember(Value = "auxInput7")]
    AuxInput7,

    [EnumMember(Value = "auxInput8")]
    AuxInput8,

    [EnumMember(Value = "auxInput9")]
    AuxInput9,

    [EnumMember(Value = "auxInput10")]
    AuxInput10,

    [EnumMember(Value = "auxInput11")]
    AuxInput11,

    [EnumMember(Value = "auxInput12")]
    AuxInput12,

    [EnumMember(Value = "auxInput13")]
    AuxInput13,

    [EnumMember(Value = "barometricPressurePa")]
    BarometricPressurePa,

    [EnumMember(Value = "batteryMilliVolts")]
    BatteryMilliVolts,

    [EnumMember(Value = "defLevelMilliPercent")]
    DefLevelMilliPercent,

    [EnumMember(Value = "ecuSpeedMph")]
    EcuSpeedMph,

    [EnumMember(Value = "engineCoolantTemperatureMilliC")]
    EngineCoolantTemperatureMilliC,

    [EnumMember(Value = "engineImmobilizer")]
    EngineImmobilizer,

    [EnumMember(Value = "engineLoadPercent")]
    EngineLoadPercent,

    [EnumMember(Value = "engineOilPressureKPa")]
    EngineOilPressureKPa,

    [EnumMember(Value = "engineRpm")]
    EngineRpm,

    [EnumMember(Value = "engineStates")]
    EngineStates,

    [EnumMember(Value = "faultCodes")]
    FaultCodes,

    [EnumMember(Value = "fuelPercents")]
    FuelPercents,

    [EnumMember(Value = "gps")]
    Gps,

    [EnumMember(Value = "gpsDistanceMeters")]
    GpsDistanceMeters,

    [EnumMember(Value = "gpsOdometerMeters")]
    GpsOdometerMeters,

    [EnumMember(Value = "intakeManifoldTemperatureMilliC")]
    IntakeManifoldTemperatureMilliC,

    [EnumMember(Value = "nfcCardScans")]
    NfcCardScans,

    [EnumMember(Value = "obdEngineSeconds")]
    ObdEngineSeconds,

    [EnumMember(Value = "obdOdometerMeters")]
    ObdOdometerMeters,

    [EnumMember(Value = "syntheticEngineSeconds")]
    SyntheticEngineSeconds,

    [EnumMember(Value = "evStateOfChargeMilliPercent")]
    EvStateOfChargeMilliPercent,

    [EnumMember(Value = "evChargingStatus")]
    EvChargingStatus,

    [EnumMember(Value = "evChargingEnergyMicroWh")]
    EvChargingEnergyMicroWh,

    [EnumMember(Value = "evChargingVoltageMilliVolt")]
    EvChargingVoltageMilliVolt,

    [EnumMember(Value = "evChargingCurrentMilliAmp")]
    EvChargingCurrentMilliAmp,

    [EnumMember(Value = "evConsumedEnergyMicroWh")]
    EvConsumedEnergyMicroWh,

    [EnumMember(Value = "evRegeneratedEnergyMicroWh")]
    EvRegeneratedEnergyMicroWh,

    [EnumMember(Value = "evBatteryVoltageMilliVolt")]
    EvBatteryVoltageMilliVolt,

    [EnumMember(Value = "evBatteryCurrentMilliAmp")]
    EvBatteryCurrentMilliAmp,

    [EnumMember(Value = "evBatteryStateOfHealthMilliPercent")]
    EvBatteryStateOfHealthMilliPercent,

    [EnumMember(Value = "evAverageBatteryTemperatureMilliCelsius")]
    EvAverageBatteryTemperatureMilliCelsius,

    [EnumMember(Value = "evDistanceDrivenMeters")]
    EvDistanceDrivenMeters,

    [EnumMember(Value = "spreaderLiquidRate")]
    SpreaderLiquidRate,

    [EnumMember(Value = "spreaderGranularRate")]
    SpreaderGranularRate,

    [EnumMember(Value = "spreaderPrewetRate")]
    SpreaderPrewetRate,

    [EnumMember(Value = "spreaderAirTemp")]
    SpreaderAirTemp,

    [EnumMember(Value = "spreaderRoadTemp")]
    SpreaderRoadTemp,

    [EnumMember(Value = "spreaderOnState")]
    SpreaderOnState,

    [EnumMember(Value = "spreaderActive")]
    SpreaderActive,

    [EnumMember(Value = "spreaderBlastState")]
    SpreaderBlastState,

    [EnumMember(Value = "spreaderGranularName")]
    SpreaderGranularName,

    [EnumMember(Value = "spreaderPrewetName")]
    SpreaderPrewetName,

    [EnumMember(Value = "spreaderLiquidName")]
    SpreaderLiquidName,

    [EnumMember(Value = "spreaderPlowStatus")]
    SpreaderPlowStatus,

    [EnumMember(Value = "seatbeltDriver")]
    SeatbeltDriver,
}
