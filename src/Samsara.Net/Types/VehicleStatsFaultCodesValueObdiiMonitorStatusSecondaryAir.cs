using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<VehicleStatsFaultCodesValueObdiiMonitorStatusSecondaryAir>)
)]
[Serializable]
public readonly record struct VehicleStatsFaultCodesValueObdiiMonitorStatusSecondaryAir
    : IStringEnum
{
    public static readonly VehicleStatsFaultCodesValueObdiiMonitorStatusSecondaryAir N = new(
        Values.N
    );

    public static readonly VehicleStatsFaultCodesValueObdiiMonitorStatusSecondaryAir R = new(
        Values.R
    );

    public static readonly VehicleStatsFaultCodesValueObdiiMonitorStatusSecondaryAir U = new(
        Values.U
    );

    public VehicleStatsFaultCodesValueObdiiMonitorStatusSecondaryAir(string value)
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
    public static VehicleStatsFaultCodesValueObdiiMonitorStatusSecondaryAir FromCustom(string value)
    {
        return new VehicleStatsFaultCodesValueObdiiMonitorStatusSecondaryAir(value);
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
        VehicleStatsFaultCodesValueObdiiMonitorStatusSecondaryAir value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VehicleStatsFaultCodesValueObdiiMonitorStatusSecondaryAir value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        VehicleStatsFaultCodesValueObdiiMonitorStatusSecondaryAir value
    ) => value.Value;

    public static explicit operator VehicleStatsFaultCodesValueObdiiMonitorStatusSecondaryAir(
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
