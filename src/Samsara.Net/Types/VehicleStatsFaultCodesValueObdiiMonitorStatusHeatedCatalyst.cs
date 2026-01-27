using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedCatalyst>)
)]
[Serializable]
public readonly record struct VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedCatalyst
    : IStringEnum
{
    public static readonly VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedCatalyst N = new(
        Values.N
    );

    public static readonly VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedCatalyst R = new(
        Values.R
    );

    public static readonly VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedCatalyst U = new(
        Values.U
    );

    public VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedCatalyst(string value)
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
    public static VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedCatalyst FromCustom(
        string value
    )
    {
        return new VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedCatalyst(value);
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
        VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedCatalyst value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedCatalyst value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedCatalyst value
    ) => value.Value;

    public static explicit operator VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedCatalyst(
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
