using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleStatsFaultCodesPassengerMonitorStatusValue>))]
[Serializable]
public readonly record struct VehicleStatsFaultCodesPassengerMonitorStatusValue : IStringEnum
{
    public static readonly VehicleStatsFaultCodesPassengerMonitorStatusValue N = new(Values.N);

    public static readonly VehicleStatsFaultCodesPassengerMonitorStatusValue R = new(Values.R);

    public static readonly VehicleStatsFaultCodesPassengerMonitorStatusValue U = new(Values.U);

    public VehicleStatsFaultCodesPassengerMonitorStatusValue(string value)
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
    public static VehicleStatsFaultCodesPassengerMonitorStatusValue FromCustom(string value)
    {
        return new VehicleStatsFaultCodesPassengerMonitorStatusValue(value);
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
        VehicleStatsFaultCodesPassengerMonitorStatusValue value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VehicleStatsFaultCodesPassengerMonitorStatusValue value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        VehicleStatsFaultCodesPassengerMonitorStatusValue value
    ) => value.Value;

    public static explicit operator VehicleStatsFaultCodesPassengerMonitorStatusValue(
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
