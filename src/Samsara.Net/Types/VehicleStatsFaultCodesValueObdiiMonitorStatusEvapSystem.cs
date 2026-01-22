using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<VehicleStatsFaultCodesValueObdiiMonitorStatusEvapSystem>)
)]
[Serializable]
public readonly record struct VehicleStatsFaultCodesValueObdiiMonitorStatusEvapSystem : IStringEnum
{
    public static readonly VehicleStatsFaultCodesValueObdiiMonitorStatusEvapSystem N = new(
        Values.N
    );

    public static readonly VehicleStatsFaultCodesValueObdiiMonitorStatusEvapSystem R = new(
        Values.R
    );

    public static readonly VehicleStatsFaultCodesValueObdiiMonitorStatusEvapSystem U = new(
        Values.U
    );

    public VehicleStatsFaultCodesValueObdiiMonitorStatusEvapSystem(string value)
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
    public static VehicleStatsFaultCodesValueObdiiMonitorStatusEvapSystem FromCustom(string value)
    {
        return new VehicleStatsFaultCodesValueObdiiMonitorStatusEvapSystem(value);
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
        VehicleStatsFaultCodesValueObdiiMonitorStatusEvapSystem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VehicleStatsFaultCodesValueObdiiMonitorStatusEvapSystem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        VehicleStatsFaultCodesValueObdiiMonitorStatusEvapSystem value
    ) => value.Value;

    public static explicit operator VehicleStatsFaultCodesValueObdiiMonitorStatusEvapSystem(
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
