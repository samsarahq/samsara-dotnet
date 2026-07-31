using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<FleetOrderTaskUpsertInputRequestBodyPositionConstraintType>)
)]
[Serializable]
public readonly record struct FleetOrderTaskUpsertInputRequestBodyPositionConstraintType
    : IStringEnum
{
    public static readonly FleetOrderTaskUpsertInputRequestBodyPositionConstraintType None = new(
        Values.None
    );

    public static readonly FleetOrderTaskUpsertInputRequestBodyPositionConstraintType First = new(
        Values.First
    );

    public static readonly FleetOrderTaskUpsertInputRequestBodyPositionConstraintType Last = new(
        Values.Last
    );

    public FleetOrderTaskUpsertInputRequestBodyPositionConstraintType(string value)
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
    public static FleetOrderTaskUpsertInputRequestBodyPositionConstraintType FromCustom(
        string value
    )
    {
        return new FleetOrderTaskUpsertInputRequestBodyPositionConstraintType(value);
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
        FleetOrderTaskUpsertInputRequestBodyPositionConstraintType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FleetOrderTaskUpsertInputRequestBodyPositionConstraintType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FleetOrderTaskUpsertInputRequestBodyPositionConstraintType value
    ) => value.Value;

    public static explicit operator FleetOrderTaskUpsertInputRequestBodyPositionConstraintType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string None = "none";

        public const string First = "first";

        public const string Last = "last";
    }
}
