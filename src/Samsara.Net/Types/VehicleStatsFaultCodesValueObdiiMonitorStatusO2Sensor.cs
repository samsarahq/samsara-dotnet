using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleStatsFaultCodesValueObdiiMonitorStatusO2Sensor>))]
[Serializable]
public readonly record struct VehicleStatsFaultCodesValueObdiiMonitorStatusO2Sensor : IStringEnum
{
    public static readonly VehicleStatsFaultCodesValueObdiiMonitorStatusO2Sensor N = new(Values.N);

    public static readonly VehicleStatsFaultCodesValueObdiiMonitorStatusO2Sensor R = new(Values.R);

    public static readonly VehicleStatsFaultCodesValueObdiiMonitorStatusO2Sensor U = new(Values.U);

    public VehicleStatsFaultCodesValueObdiiMonitorStatusO2Sensor(string value)
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
    public static VehicleStatsFaultCodesValueObdiiMonitorStatusO2Sensor FromCustom(string value)
    {
        return new VehicleStatsFaultCodesValueObdiiMonitorStatusO2Sensor(value);
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
        VehicleStatsFaultCodesValueObdiiMonitorStatusO2Sensor value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VehicleStatsFaultCodesValueObdiiMonitorStatusO2Sensor value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        VehicleStatsFaultCodesValueObdiiMonitorStatusO2Sensor value
    ) => value.Value;

    public static explicit operator VehicleStatsFaultCodesValueObdiiMonitorStatusO2Sensor(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string N = "N";

        public const string R = "R";

        public const string U = "U";
    }
}
