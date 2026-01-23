using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.VehicleStats;

[JsonConverter(typeof(StringEnumSerializer<GetVehicleStatsRequestTypesItem>))]
[Serializable]
public readonly record struct GetVehicleStatsRequestTypesItem : IStringEnum
{
    public static readonly GetVehicleStatsRequestTypesItem AmbientAirTemperatureMilliC = new(
        Values.AmbientAirTemperatureMilliC
    );

    public static readonly GetVehicleStatsRequestTypesItem AuxInput1 = new(Values.AuxInput1);

    public static readonly GetVehicleStatsRequestTypesItem AuxInput2 = new(Values.AuxInput2);

    public static readonly GetVehicleStatsRequestTypesItem AuxInput3 = new(Values.AuxInput3);

    public static readonly GetVehicleStatsRequestTypesItem AuxInput4 = new(Values.AuxInput4);

    public static readonly GetVehicleStatsRequestTypesItem AuxInput5 = new(Values.AuxInput5);

    public static readonly GetVehicleStatsRequestTypesItem AuxInput6 = new(Values.AuxInput6);

    public static readonly GetVehicleStatsRequestTypesItem AuxInput7 = new(Values.AuxInput7);

    public static readonly GetVehicleStatsRequestTypesItem AuxInput8 = new(Values.AuxInput8);

    public static readonly GetVehicleStatsRequestTypesItem AuxInput9 = new(Values.AuxInput9);

    public static readonly GetVehicleStatsRequestTypesItem AuxInput10 = new(Values.AuxInput10);

    public static readonly GetVehicleStatsRequestTypesItem AuxInput11 = new(Values.AuxInput11);

    public static readonly GetVehicleStatsRequestTypesItem AuxInput12 = new(Values.AuxInput12);

    public static readonly GetVehicleStatsRequestTypesItem AuxInput13 = new(Values.AuxInput13);

    public static readonly GetVehicleStatsRequestTypesItem BarometricPressurePa = new(
        Values.BarometricPressurePa
    );

    public static readonly GetVehicleStatsRequestTypesItem BatteryMilliVolts = new(
        Values.BatteryMilliVolts
    );

    public static readonly GetVehicleStatsRequestTypesItem DefLevelMilliPercent = new(
        Values.DefLevelMilliPercent
    );

    public static readonly GetVehicleStatsRequestTypesItem EcuSpeedMph = new(Values.EcuSpeedMph);

    public static readonly GetVehicleStatsRequestTypesItem EngineCoolantTemperatureMilliC = new(
        Values.EngineCoolantTemperatureMilliC
    );

    public static readonly GetVehicleStatsRequestTypesItem EngineImmobilizer = new(
        Values.EngineImmobilizer
    );

    public static readonly GetVehicleStatsRequestTypesItem EngineLoadPercent = new(
        Values.EngineLoadPercent
    );

    public static readonly GetVehicleStatsRequestTypesItem EngineOilPressureKPa = new(
        Values.EngineOilPressureKPa
    );

    public static readonly GetVehicleStatsRequestTypesItem EngineRpm = new(Values.EngineRpm);

    public static readonly GetVehicleStatsRequestTypesItem EngineStates = new(Values.EngineStates);

    public static readonly GetVehicleStatsRequestTypesItem FaultCodes = new(Values.FaultCodes);

    public static readonly GetVehicleStatsRequestTypesItem FuelPercents = new(Values.FuelPercents);

    public static readonly GetVehicleStatsRequestTypesItem FuelConsumedMilliliters = new(
        Values.FuelConsumedMilliliters
    );

    public static readonly GetVehicleStatsRequestTypesItem Gps = new(Values.Gps);

    public static readonly GetVehicleStatsRequestTypesItem GpsDistanceMeters = new(
        Values.GpsDistanceMeters
    );

    public static readonly GetVehicleStatsRequestTypesItem GpsOdometerMeters = new(
        Values.GpsOdometerMeters
    );

    public static readonly GetVehicleStatsRequestTypesItem IdlingDurationMilliseconds = new(
        Values.IdlingDurationMilliseconds
    );

    public static readonly GetVehicleStatsRequestTypesItem IntakeManifoldTemperatureMilliC = new(
        Values.IntakeManifoldTemperatureMilliC
    );

    public static readonly GetVehicleStatsRequestTypesItem NfcCardScans = new(Values.NfcCardScans);

    public static readonly GetVehicleStatsRequestTypesItem ObdEngineSeconds = new(
        Values.ObdEngineSeconds
    );

    public static readonly GetVehicleStatsRequestTypesItem ObdOdometerMeters = new(
        Values.ObdOdometerMeters
    );

    public static readonly GetVehicleStatsRequestTypesItem SyntheticEngineSeconds = new(
        Values.SyntheticEngineSeconds
    );

    public static readonly GetVehicleStatsRequestTypesItem EvStateOfChargeMilliPercent = new(
        Values.EvStateOfChargeMilliPercent
    );

    public static readonly GetVehicleStatsRequestTypesItem EvChargingStatus = new(
        Values.EvChargingStatus
    );

    public static readonly GetVehicleStatsRequestTypesItem EvChargingEnergyMicroWh = new(
        Values.EvChargingEnergyMicroWh
    );

    public static readonly GetVehicleStatsRequestTypesItem EvChargingVoltageMilliVolt = new(
        Values.EvChargingVoltageMilliVolt
    );

    public static readonly GetVehicleStatsRequestTypesItem EvChargingCurrentMilliAmp = new(
        Values.EvChargingCurrentMilliAmp
    );

    public static readonly GetVehicleStatsRequestTypesItem EvConsumedEnergyMicroWh = new(
        Values.EvConsumedEnergyMicroWh
    );

    public static readonly GetVehicleStatsRequestTypesItem EvRegeneratedEnergyMicroWh = new(
        Values.EvRegeneratedEnergyMicroWh
    );

    public static readonly GetVehicleStatsRequestTypesItem EvBatteryVoltageMilliVolt = new(
        Values.EvBatteryVoltageMilliVolt
    );

    public static readonly GetVehicleStatsRequestTypesItem EvBatteryCurrentMilliAmp = new(
        Values.EvBatteryCurrentMilliAmp
    );

    public static readonly GetVehicleStatsRequestTypesItem EvBatteryStateOfHealthMilliPercent = new(
        Values.EvBatteryStateOfHealthMilliPercent
    );

    public static readonly GetVehicleStatsRequestTypesItem EvAverageBatteryTemperatureMilliCelsius =
        new(Values.EvAverageBatteryTemperatureMilliCelsius);

    public static readonly GetVehicleStatsRequestTypesItem EvDistanceDrivenMeters = new(
        Values.EvDistanceDrivenMeters
    );

    public static readonly GetVehicleStatsRequestTypesItem SpreaderLiquidRate = new(
        Values.SpreaderLiquidRate
    );

    public static readonly GetVehicleStatsRequestTypesItem SpreaderGranularRate = new(
        Values.SpreaderGranularRate
    );

    public static readonly GetVehicleStatsRequestTypesItem SpreaderPrewetRate = new(
        Values.SpreaderPrewetRate
    );

    public static readonly GetVehicleStatsRequestTypesItem SpreaderAirTemp = new(
        Values.SpreaderAirTemp
    );

    public static readonly GetVehicleStatsRequestTypesItem SpreaderRoadTemp = new(
        Values.SpreaderRoadTemp
    );

    public static readonly GetVehicleStatsRequestTypesItem SpreaderOnState = new(
        Values.SpreaderOnState
    );

    public static readonly GetVehicleStatsRequestTypesItem SpreaderActive = new(
        Values.SpreaderActive
    );

    public static readonly GetVehicleStatsRequestTypesItem SpreaderBlastState = new(
        Values.SpreaderBlastState
    );

    public static readonly GetVehicleStatsRequestTypesItem SpreaderGranularName = new(
        Values.SpreaderGranularName
    );

    public static readonly GetVehicleStatsRequestTypesItem SpreaderPrewetName = new(
        Values.SpreaderPrewetName
    );

    public static readonly GetVehicleStatsRequestTypesItem SpreaderLiquidName = new(
        Values.SpreaderLiquidName
    );

    public static readonly GetVehicleStatsRequestTypesItem SpreaderPlowStatus = new(
        Values.SpreaderPlowStatus
    );

    public static readonly GetVehicleStatsRequestTypesItem SeatbeltDriver = new(
        Values.SeatbeltDriver
    );

    public static readonly GetVehicleStatsRequestTypesItem TellTales = new(Values.TellTales);

    public static readonly GetVehicleStatsRequestTypesItem EcuDoorStatus = new(
        Values.EcuDoorStatus
    );

    public GetVehicleStatsRequestTypesItem(string value)
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
    public static GetVehicleStatsRequestTypesItem FromCustom(string value)
    {
        return new GetVehicleStatsRequestTypesItem(value);
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

    public static bool operator ==(GetVehicleStatsRequestTypesItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetVehicleStatsRequestTypesItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetVehicleStatsRequestTypesItem value) => value.Value;

    public static explicit operator GetVehicleStatsRequestTypesItem(string value) => new(value);

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
