using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DriverRulesetObjectResponseBodyShift>))]
[Serializable]
public readonly record struct DriverRulesetObjectResponseBodyShift : IStringEnum
{
    public static readonly DriverRulesetObjectResponseBodyShift UsInterstateProperty = new(
        Values.UsInterstateProperty
    );

    public static readonly DriverRulesetObjectResponseBodyShift UsInterstatePassenger = new(
        Values.UsInterstatePassenger
    );

    public DriverRulesetObjectResponseBodyShift(string value)
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
    public static DriverRulesetObjectResponseBodyShift FromCustom(string value)
    {
        return new DriverRulesetObjectResponseBodyShift(value);
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

    public static bool operator ==(DriverRulesetObjectResponseBodyShift value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DriverRulesetObjectResponseBodyShift value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DriverRulesetObjectResponseBodyShift value) =>
        value.Value;

    public static explicit operator DriverRulesetObjectResponseBodyShift(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string UsInterstateProperty = "US Interstate Property";

        public const string UsInterstatePassenger = "US Interstate Passenger";
    }
}
