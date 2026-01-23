using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<SpeedingSettingsObjectResponseBodyUnit>))]
[Serializable]
public readonly record struct SpeedingSettingsObjectResponseBodyUnit : IStringEnum
{
    public static readonly SpeedingSettingsObjectResponseBodyUnit MilesPerHour = new(
        Values.MilesPerHour
    );

    public static readonly SpeedingSettingsObjectResponseBodyUnit KilometersPerHour = new(
        Values.KilometersPerHour
    );

    public static readonly SpeedingSettingsObjectResponseBodyUnit Percentage = new(
        Values.Percentage
    );

    public SpeedingSettingsObjectResponseBodyUnit(string value)
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
    public static SpeedingSettingsObjectResponseBodyUnit FromCustom(string value)
    {
        return new SpeedingSettingsObjectResponseBodyUnit(value);
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

    public static bool operator ==(SpeedingSettingsObjectResponseBodyUnit value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SpeedingSettingsObjectResponseBodyUnit value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SpeedingSettingsObjectResponseBodyUnit value) =>
        value.Value;

    public static explicit operator SpeedingSettingsObjectResponseBodyUnit(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string MilesPerHour = "milesPerHour";

        public const string KilometersPerHour = "kilometersPerHour";

        public const string Percentage = "percentage";
    }
}
