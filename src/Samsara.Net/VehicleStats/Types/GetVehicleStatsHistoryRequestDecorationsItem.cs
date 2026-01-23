using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.VehicleStats;

[JsonConverter(typeof(StringEnumSerializer<GetVehicleStatsHistoryRequestDecorationsItem>))]
[Serializable]
public readonly record struct GetVehicleStatsHistoryRequestDecorationsItem : IStringEnum
{
    public static readonly GetVehicleStatsHistoryRequestDecorationsItem AmbientAirTemperatureMilliC =
        new(Values.AmbientAirTemperatureMilliC);

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem AuxInput1 = new(
        Values.AuxInput1
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem AuxInput2 = new(
        Values.AuxInput2
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem AuxInput3 = new(
        Values.AuxInput3
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem AuxInput4 = new(
        Values.AuxInput4
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem AuxInput5 = new(
        Values.AuxInput5
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem AuxInput6 = new(
        Values.AuxInput6
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem AuxInput7 = new(
        Values.AuxInput7
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem AuxInput8 = new(
        Values.AuxInput8
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem AuxInput9 = new(
        Values.AuxInput9
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem AuxInput10 = new(
        Values.AuxInput10
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem AuxInput11 = new(
        Values.AuxInput11
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem AuxInput12 = new(
        Values.AuxInput12
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem AuxInput13 = new(
        Values.AuxInput13
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem BatteryMilliVolts = new(
        Values.BatteryMilliVolts
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem BarometricPressurePa = new(
        Values.BarometricPressurePa
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem DefLevelMilliPercent = new(
        Values.DefLevelMilliPercent
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem EcuSpeedMph = new(
        Values.EcuSpeedMph
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem EngineCoolantTemperatureMilliC =
        new(Values.EngineCoolantTemperatureMilliC);

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem EngineImmobilizer = new(
        Values.EngineImmobilizer
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem EngineLoadPercent = new(
        Values.EngineLoadPercent
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem EngineOilPressureKPa = new(
        Values.EngineOilPressureKPa
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem EngineRpm = new(
        Values.EngineRpm
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem EngineStates = new(
        Values.EngineStates
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem FaultCodes = new(
        Values.FaultCodes
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem FuelPercents = new(
        Values.FuelPercents
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem FuelConsumedMilliliters =
        new(Values.FuelConsumedMilliliters);

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem Gps = new(Values.Gps);

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem GpsDistanceMeters = new(
        Values.GpsDistanceMeters
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem IdlingDurationMilliseconds =
        new(Values.IdlingDurationMilliseconds);

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem IntakeManifoldTemperatureMilliC =
        new(Values.IntakeManifoldTemperatureMilliC);

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem NfcCardScans = new(
        Values.NfcCardScans
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem ObdEngineSeconds = new(
        Values.ObdEngineSeconds
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem ObdOdometerMeters = new(
        Values.ObdOdometerMeters
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem SpreaderLiquidRate = new(
        Values.SpreaderLiquidRate
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem SpreaderGranularRate = new(
        Values.SpreaderGranularRate
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem SpreaderPrewetRate = new(
        Values.SpreaderPrewetRate
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem SpreaderAirTemp = new(
        Values.SpreaderAirTemp
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem SpreaderRoadTemp = new(
        Values.SpreaderRoadTemp
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem SpreaderOnState = new(
        Values.SpreaderOnState
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem SpreaderActive = new(
        Values.SpreaderActive
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem SpreaderBlastState = new(
        Values.SpreaderBlastState
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem SpreaderGranularName = new(
        Values.SpreaderGranularName
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem SpreaderPrewetName = new(
        Values.SpreaderPrewetName
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem SpreaderLiquidName = new(
        Values.SpreaderLiquidName
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem SpreaderPlowStatus = new(
        Values.SpreaderPlowStatus
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem SeatbeltDriver = new(
        Values.SeatbeltDriver
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem TellTales = new(
        Values.TellTales
    );

    public static readonly GetVehicleStatsHistoryRequestDecorationsItem EcuDoorStatus = new(
        Values.EcuDoorStatus
    );

    public GetVehicleStatsHistoryRequestDecorationsItem(string value)
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
    public static GetVehicleStatsHistoryRequestDecorationsItem FromCustom(string value)
    {
        return new GetVehicleStatsHistoryRequestDecorationsItem(value);
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

    public static bool operator ==(
        GetVehicleStatsHistoryRequestDecorationsItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GetVehicleStatsHistoryRequestDecorationsItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GetVehicleStatsHistoryRequestDecorationsItem value) =>
        value.Value;

    public static explicit operator GetVehicleStatsHistoryRequestDecorationsItem(string value) =>
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

        public const string BatteryMilliVolts = "batteryMilliVolts";

        public const string BarometricPressurePa = "barometricPressurePa";

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

        public const string IdlingDurationMilliseconds = "idlingDurationMilliseconds";

        public const string IntakeManifoldTemperatureMilliC = "intakeManifoldTemperatureMilliC";

        public const string NfcCardScans = "nfcCardScans";

        public const string ObdEngineSeconds = "obdEngineSeconds";

        public const string ObdOdometerMeters = "obdOdometerMeters";

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
