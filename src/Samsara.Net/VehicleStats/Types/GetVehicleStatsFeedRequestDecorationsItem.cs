using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.VehicleStats;

[JsonConverter(typeof(StringEnumSerializer<GetVehicleStatsFeedRequestDecorationsItem>))]
[Serializable]
public readonly record struct GetVehicleStatsFeedRequestDecorationsItem : IStringEnum
{
    public static readonly GetVehicleStatsFeedRequestDecorationsItem AmbientAirTemperatureMilliC =
        new(Values.AmbientAirTemperatureMilliC);

    public static readonly GetVehicleStatsFeedRequestDecorationsItem AuxInput1 = new(
        Values.AuxInput1
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem AuxInput2 = new(
        Values.AuxInput2
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem AuxInput3 = new(
        Values.AuxInput3
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem AuxInput4 = new(
        Values.AuxInput4
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem AuxInput5 = new(
        Values.AuxInput5
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem AuxInput6 = new(
        Values.AuxInput6
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem AuxInput7 = new(
        Values.AuxInput7
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem AuxInput8 = new(
        Values.AuxInput8
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem AuxInput9 = new(
        Values.AuxInput9
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem AuxInput10 = new(
        Values.AuxInput10
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem AuxInput11 = new(
        Values.AuxInput11
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem AuxInput12 = new(
        Values.AuxInput12
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem AuxInput13 = new(
        Values.AuxInput13
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem BatteryMilliVolts = new(
        Values.BatteryMilliVolts
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem BarometricPressurePa = new(
        Values.BarometricPressurePa
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem DefLevelMilliPercent = new(
        Values.DefLevelMilliPercent
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem EcuSpeedMph = new(
        Values.EcuSpeedMph
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem EngineCoolantTemperatureMilliC =
        new(Values.EngineCoolantTemperatureMilliC);

    public static readonly GetVehicleStatsFeedRequestDecorationsItem EngineImmobilizer = new(
        Values.EngineImmobilizer
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem EngineLoadPercent = new(
        Values.EngineLoadPercent
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem EngineOilPressureKPa = new(
        Values.EngineOilPressureKPa
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem EngineRpm = new(
        Values.EngineRpm
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem EngineStates = new(
        Values.EngineStates
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem FaultCodes = new(
        Values.FaultCodes
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem FuelPercents = new(
        Values.FuelPercents
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem FuelConsumedMilliliters = new(
        Values.FuelConsumedMilliliters
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem Gps = new(Values.Gps);

    public static readonly GetVehicleStatsFeedRequestDecorationsItem GpsDistanceMeters = new(
        Values.GpsDistanceMeters
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem IdlingDurationMilliseconds =
        new(Values.IdlingDurationMilliseconds);

    public static readonly GetVehicleStatsFeedRequestDecorationsItem IntakeManifoldTemperatureMilliC =
        new(Values.IntakeManifoldTemperatureMilliC);

    public static readonly GetVehicleStatsFeedRequestDecorationsItem NfcCardScans = new(
        Values.NfcCardScans
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem ObdEngineSeconds = new(
        Values.ObdEngineSeconds
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem ObdOdometerMeters = new(
        Values.ObdOdometerMeters
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem SpreaderLiquidRate = new(
        Values.SpreaderLiquidRate
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem SpreaderGranularRate = new(
        Values.SpreaderGranularRate
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem SpreaderPrewetRate = new(
        Values.SpreaderPrewetRate
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem SpreaderAirTemp = new(
        Values.SpreaderAirTemp
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem SpreaderRoadTemp = new(
        Values.SpreaderRoadTemp
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem SpreaderOnState = new(
        Values.SpreaderOnState
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem SpreaderActive = new(
        Values.SpreaderActive
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem SpreaderBlastState = new(
        Values.SpreaderBlastState
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem SpreaderGranularName = new(
        Values.SpreaderGranularName
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem SpreaderPrewetName = new(
        Values.SpreaderPrewetName
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem SpreaderLiquidName = new(
        Values.SpreaderLiquidName
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem SpreaderPlowStatus = new(
        Values.SpreaderPlowStatus
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem SeatbeltDriver = new(
        Values.SeatbeltDriver
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem TellTales = new(
        Values.TellTales
    );

    public static readonly GetVehicleStatsFeedRequestDecorationsItem EcuDoorStatus = new(
        Values.EcuDoorStatus
    );

    public GetVehicleStatsFeedRequestDecorationsItem(string value)
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
    public static GetVehicleStatsFeedRequestDecorationsItem FromCustom(string value)
    {
        return new GetVehicleStatsFeedRequestDecorationsItem(value);
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
        GetVehicleStatsFeedRequestDecorationsItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GetVehicleStatsFeedRequestDecorationsItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GetVehicleStatsFeedRequestDecorationsItem value) =>
        value.Value;

    public static explicit operator GetVehicleStatsFeedRequestDecorationsItem(string value) =>
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
