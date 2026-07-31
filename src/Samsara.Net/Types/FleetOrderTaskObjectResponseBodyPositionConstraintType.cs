using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<FleetOrderTaskObjectResponseBodyPositionConstraintType>)
)]
[Serializable]
public readonly record struct FleetOrderTaskObjectResponseBodyPositionConstraintType : IStringEnum
{
    public static readonly FleetOrderTaskObjectResponseBodyPositionConstraintType Unknown = new(
        Values.Unknown
    );

    public static readonly FleetOrderTaskObjectResponseBodyPositionConstraintType None = new(
        Values.None
    );

    public static readonly FleetOrderTaskObjectResponseBodyPositionConstraintType First = new(
        Values.First
    );

    public static readonly FleetOrderTaskObjectResponseBodyPositionConstraintType Last = new(
        Values.Last
    );

    public FleetOrderTaskObjectResponseBodyPositionConstraintType(string value)
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
    public static FleetOrderTaskObjectResponseBodyPositionConstraintType FromCustom(string value)
    {
        return new FleetOrderTaskObjectResponseBodyPositionConstraintType(value);
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
        FleetOrderTaskObjectResponseBodyPositionConstraintType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FleetOrderTaskObjectResponseBodyPositionConstraintType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FleetOrderTaskObjectResponseBodyPositionConstraintType value
    ) => value.Value;

    public static explicit operator FleetOrderTaskObjectResponseBodyPositionConstraintType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string None = "none";

        public const string First = "first";

        public const string Last = "last";
    }
}
