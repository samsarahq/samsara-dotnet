using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleStatsFaultCodesValueObdiiMonitorStatusMisfire>))]
[Serializable]
public readonly record struct VehicleStatsFaultCodesValueObdiiMonitorStatusMisfire : IStringEnum
{
    public static readonly VehicleStatsFaultCodesValueObdiiMonitorStatusMisfire N = new(Values.N);

    public static readonly VehicleStatsFaultCodesValueObdiiMonitorStatusMisfire R = new(Values.R);

    public static readonly VehicleStatsFaultCodesValueObdiiMonitorStatusMisfire U = new(Values.U);

    public VehicleStatsFaultCodesValueObdiiMonitorStatusMisfire(string value)
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
    public static VehicleStatsFaultCodesValueObdiiMonitorStatusMisfire FromCustom(string value)
    {
        return new VehicleStatsFaultCodesValueObdiiMonitorStatusMisfire(value);
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
        VehicleStatsFaultCodesValueObdiiMonitorStatusMisfire value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VehicleStatsFaultCodesValueObdiiMonitorStatusMisfire value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        VehicleStatsFaultCodesValueObdiiMonitorStatusMisfire value
    ) => value.Value;

    public static explicit operator VehicleStatsFaultCodesValueObdiiMonitorStatusMisfire(
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
