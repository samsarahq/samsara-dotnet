using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DriverAssignmentObjectResponseBodyAssignmentType>))]
[Serializable]
public readonly record struct DriverAssignmentObjectResponseBodyAssignmentType : IStringEnum
{
    public static readonly DriverAssignmentObjectResponseBodyAssignmentType DriverApp = new(
        Values.DriverApp
    );

    public DriverAssignmentObjectResponseBodyAssignmentType(string value)
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
    public static DriverAssignmentObjectResponseBodyAssignmentType FromCustom(string value)
    {
        return new DriverAssignmentObjectResponseBodyAssignmentType(value);
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
        DriverAssignmentObjectResponseBodyAssignmentType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DriverAssignmentObjectResponseBodyAssignmentType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DriverAssignmentObjectResponseBodyAssignmentType value
    ) => value.Value;

    public static explicit operator DriverAssignmentObjectResponseBodyAssignmentType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string DriverApp = "driverApp";
    }
}
