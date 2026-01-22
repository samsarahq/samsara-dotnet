using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleStatsFaultCodesValueObdiiMonitorStatusFuel>))]
[Serializable]
public readonly record struct VehicleStatsFaultCodesValueObdiiMonitorStatusFuel : IStringEnum
{
    public static readonly VehicleStatsFaultCodesValueObdiiMonitorStatusFuel N = new(Values.N);

    public static readonly VehicleStatsFaultCodesValueObdiiMonitorStatusFuel R = new(Values.R);

    public static readonly VehicleStatsFaultCodesValueObdiiMonitorStatusFuel U = new(Values.U);

    public VehicleStatsFaultCodesValueObdiiMonitorStatusFuel(string value)
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
    public static VehicleStatsFaultCodesValueObdiiMonitorStatusFuel FromCustom(string value)
    {
        return new VehicleStatsFaultCodesValueObdiiMonitorStatusFuel(value);
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
        VehicleStatsFaultCodesValueObdiiMonitorStatusFuel value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VehicleStatsFaultCodesValueObdiiMonitorStatusFuel value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        VehicleStatsFaultCodesValueObdiiMonitorStatusFuel value
    ) => value.Value;

    public static explicit operator VehicleStatsFaultCodesValueObdiiMonitorStatusFuel(
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
