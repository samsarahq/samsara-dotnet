using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.VehicleStats;

[JsonConverter(typeof(StringEnumSerializer<GetVehicleStatsHistoryRequestTypesItem>))]
[Serializable]
public readonly record struct GetVehicleStatsHistoryRequestTypesItem : IStringEnum
{
    public static readonly GetVehicleStatsHistoryRequestTypesItem AmbientAirTemperatureMilliC = new(
        Values.AmbientAirTemperatureMilliC
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem AuxInput1 = new(Values.AuxInput1);

    public static readonly GetVehicleStatsHistoryRequestTypesItem AuxInput2 = new(Values.AuxInput2);

    public static readonly GetVehicleStatsHistoryRequestTypesItem AuxInput3 = new(Values.AuxInput3);

    public static readonly GetVehicleStatsHistoryRequestTypesItem AuxInput4 = new(Values.AuxInput4);

    public static readonly GetVehicleStatsHistoryRequestTypesItem AuxInput5 = new(Values.AuxInput5);

    public static readonly GetVehicleStatsHistoryRequestTypesItem AuxInput6 = new(Values.AuxInput6);

    public static readonly GetVehicleStatsHistoryRequestTypesItem AuxInput7 = new(Values.AuxInput7);

    public static readonly GetVehicleStatsHistoryRequestTypesItem AuxInput8 = new(Values.AuxInput8);

    public static readonly GetVehicleStatsHistoryRequestTypesItem AuxInput9 = new(Values.AuxInput9);

    public static readonly GetVehicleStatsHistoryRequestTypesItem AuxInput10 = new(
        Values.AuxInput10
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem AuxInput11 = new(
        Values.AuxInput11
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem AuxInput12 = new(
        Values.AuxInput12
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem AuxInput13 = new(
        Values.AuxInput13
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem BarometricPressurePa = new(
        Values.BarometricPressurePa
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem BatteryMilliVolts = new(
        Values.BatteryMilliVolts
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem DefLevelMilliPercent = new(
        Values.DefLevelMilliPercent
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem EcuSpeedMph = new(
        Values.EcuSpeedMph
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem EngineCoolantTemperatureMilliC =
        new(Values.EngineCoolantTemperatureMilliC);

    public static readonly GetVehicleStatsHistoryRequestTypesItem EngineImmobilizer = new(
        Values.EngineImmobilizer
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem EngineLoadPercent = new(
        Values.EngineLoadPercent
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem EngineOilPressureKPa = new(
        Values.EngineOilPressureKPa
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem EngineRpm = new(Values.EngineRpm);

    public static readonly GetVehicleStatsHistoryRequestTypesItem EngineStates = new(
        Values.EngineStates
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem FaultCodes = new(
        Values.FaultCodes
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem FuelPercents = new(
        Values.FuelPercents
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem FuelConsumedMilliliters = new(
        Values.FuelConsumedMilliliters
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem Gps = new(Values.Gps);

    public static readonly GetVehicleStatsHistoryRequestTypesItem GpsDistanceMeters = new(
        Values.GpsDistanceMeters
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem GpsOdometerMeters = new(
        Values.GpsOdometerMeters
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem IdlingDurationMilliseconds = new(
        Values.IdlingDurationMilliseconds
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem IntakeManifoldTemperatureMilliC =
        new(Values.IntakeManifoldTemperatureMilliC);

    public static readonly GetVehicleStatsHistoryRequestTypesItem NfcCardScans = new(
        Values.NfcCardScans
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem ObdEngineSeconds = new(
        Values.ObdEngineSeconds
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem ObdOdometerMeters = new(
        Values.ObdOdometerMeters
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem SyntheticEngineSeconds = new(
        Values.SyntheticEngineSeconds
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem EvStateOfChargeMilliPercent = new(
        Values.EvStateOfChargeMilliPercent
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem EvChargingStatus = new(
        Values.EvChargingStatus
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem EvChargingEnergyMicroWh = new(
        Values.EvChargingEnergyMicroWh
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem EvChargingVoltageMilliVolt = new(
        Values.EvChargingVoltageMilliVolt
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem EvChargingCurrentMilliAmp = new(
        Values.EvChargingCurrentMilliAmp
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem EvConsumedEnergyMicroWh = new(
        Values.EvConsumedEnergyMicroWh
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem EvRegeneratedEnergyMicroWh = new(
        Values.EvRegeneratedEnergyMicroWh
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem EvBatteryVoltageMilliVolt = new(
        Values.EvBatteryVoltageMilliVolt
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem EvBatteryCurrentMilliAmp = new(
        Values.EvBatteryCurrentMilliAmp
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem EvBatteryStateOfHealthMilliPercent =
        new(Values.EvBatteryStateOfHealthMilliPercent);

    public static readonly GetVehicleStatsHistoryRequestTypesItem EvAverageBatteryTemperatureMilliCelsius =
        new(Values.EvAverageBatteryTemperatureMilliCelsius);

    public static readonly GetVehicleStatsHistoryRequestTypesItem EvDistanceDrivenMeters = new(
        Values.EvDistanceDrivenMeters
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem SpreaderLiquidRate = new(
        Values.SpreaderLiquidRate
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem SpreaderGranularRate = new(
        Values.SpreaderGranularRate
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem SpreaderPrewetRate = new(
        Values.SpreaderPrewetRate
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem SpreaderAirTemp = new(
        Values.SpreaderAirTemp
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem SpreaderRoadTemp = new(
        Values.SpreaderRoadTemp
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem SpreaderOnState = new(
        Values.SpreaderOnState
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem SpreaderActive = new(
        Values.SpreaderActive
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem SpreaderBlastState = new(
        Values.SpreaderBlastState
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem SpreaderGranularName = new(
        Values.SpreaderGranularName
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem SpreaderPrewetName = new(
        Values.SpreaderPrewetName
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem SpreaderLiquidName = new(
        Values.SpreaderLiquidName
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem SpreaderPlowStatus = new(
        Values.SpreaderPlowStatus
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem SeatbeltDriver = new(
        Values.SeatbeltDriver
    );

    public static readonly GetVehicleStatsHistoryRequestTypesItem TellTales = new(Values.TellTales);

    public static readonly GetVehicleStatsHistoryRequestTypesItem EcuDoorStatus = new(
        Values.EcuDoorStatus
    );

    public GetVehicleStatsHistoryRequestTypesItem(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static GetVehicleStatsHistoryRequestTypesItem FromCustom(string value)
    {
        return new GetVehicleStatsHistoryRequestTypesItem(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(GetVehicleStatsHistoryRequestTypesItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetVehicleStatsHistoryRequestTypesItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetVehicleStatsHistoryRequestTypesItem value) =>
        value.Value;

    public static explicit operator GetVehicleStatsHistoryRequestTypesItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AmbientAirTemperatureMilliC = "ambientAirTemperatureMilliC";

        public const string AuxInput1 = "auxInput1";

        public const string AuxInput2 = "auxInput2";

        public const string AuxInput3 = "auxInput3";

        public const string AuxInput4 = "auxInput4";

        public const string AuxInput5 = "auxInput5";

        public const string AuxInput6 = "auxInput6";

        public const string AuxInput7 = "auxInput7";

        public const string AuxInput8 = "auxInput8";

        public const string AuxInput9 = "auxInput9";

        public const string AuxInput10 = "auxInput10";

        public const string AuxInput11 = "auxInput11";

        public const string AuxInput12 = "auxInput12";

        public const string AuxInput13 = "auxInput13";

        public const string BarometricPressurePa = "barometricPressurePa";

        public const string BatteryMilliVolts = "batteryMilliVolts";

        public const string DefLevelMilliPercent = "defLevelMilliPercent";

        public const string EcuSpeedMph = "ecuSpeedMph";

        public const string EngineCoolantTemperatureMilliC = "engineCoolantTemperatureMilliC";

        public const string EngineImmobilizer = "engineImmobilizer";

        public const string EngineLoadPercent = "engineLoadPercent";

        public const string EngineOilPressureKPa = "engineOilPressureKPa";

        public const string EngineRpm = "engineRpm";

        public const string EngineStates = "engineStates";

        public const string FaultCodes = "faultCodes";

        public const string FuelPercents = "fuelPercents";

        public const string FuelConsumedMilliliters = "fuelConsumedMilliliters";

        public const string Gps = "gps";

        public const string GpsDistanceMeters = "gpsDistanceMeters";

        public const string GpsOdometerMeters = "gpsOdometerMeters";

        public const string IdlingDurationMilliseconds = "idlingDurationMilliseconds";

        public const string IntakeManifoldTemperatureMilliC = "intakeManifoldTemperatureMilliC";

        public const string NfcCardScans = "nfcCardScans";

        public const string ObdEngineSeconds = "obdEngineSeconds";

        public const string ObdOdometerMeters = "obdOdometerMeters";

        public const string SyntheticEngineSeconds = "syntheticEngineSeconds";

        public const string EvStateOfChargeMilliPercent = "evStateOfChargeMilliPercent";

        public const string EvChargingStatus = "evChargingStatus";

        public const string EvChargingEnergyMicroWh = "evChargingEnergyMicroWh";

        public const string EvChargingVoltageMilliVolt = "evChargingVoltageMilliVolt";

        public const string EvChargingCurrentMilliAmp = "evChargingCurrentMilliAmp";

        public const string EvConsumedEnergyMicroWh = "evConsumedEnergyMicroWh";

        public const string EvRegeneratedEnergyMicroWh = "evRegeneratedEnergyMicroWh";

        public const string EvBatteryVoltageMilliVolt = "evBatteryVoltageMilliVolt";

        public const string EvBatteryCurrentMilliAmp = "evBatteryCurrentMilliAmp";

        public const string EvBatteryStateOfHealthMilliPercent =
            "evBatteryStateOfHealthMilliPercent";

        public const string EvAverageBatteryTemperatureMilliCelsius =
            "evAverageBatteryTemperatureMilliCelsius";

        public const string EvDistanceDrivenMeters = "evDistanceDrivenMeters";

        public const string SpreaderLiquidRate = "spreaderLiquidRate";

        public const string SpreaderGranularRate = "spreaderGranularRate";

        public const string SpreaderPrewetRate = "spreaderPrewetRate";

        public const string SpreaderAirTemp = "spreaderAirTemp";

        public const string SpreaderRoadTemp = "spreaderRoadTemp";

        public const string SpreaderOnState = "spreaderOnState";

        public const string SpreaderActive = "spreaderActive";

        public const string SpreaderBlastState = "spreaderBlastState";

        public const string SpreaderGranularName = "spreaderGranularName";

        public const string SpreaderPrewetName = "spreaderPrewetName";

        public const string SpreaderLiquidName = "spreaderLiquidName";

        public const string SpreaderPlowStatus = "spreaderPlowStatus";

        public const string SeatbeltDriver = "seatbeltDriver";

        public const string TellTales = "tellTales";

        public const string EcuDoorStatus = "ecuDoorStatus";
    }
}
