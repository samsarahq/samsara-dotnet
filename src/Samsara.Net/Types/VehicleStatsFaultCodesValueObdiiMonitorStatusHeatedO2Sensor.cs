using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedO2Sensor>)
)]
[Serializable]
public readonly record struct VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedO2Sensor
    : IStringEnum
{
    public static readonly VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedO2Sensor N = new(
        Values.N
    );

    public static readonly VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedO2Sensor R = new(
        Values.R
    );

    public static readonly VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedO2Sensor U = new(
        Values.U
    );

    public VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedO2Sensor(string value)
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
    public static VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedO2Sensor FromCustom(
        string value
    )
    {
        return new VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedO2Sensor(value);
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
        VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedO2Sensor value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedO2Sensor value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedO2Sensor value
    ) => value.Value;

    public static explicit operator VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedO2Sensor(
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
