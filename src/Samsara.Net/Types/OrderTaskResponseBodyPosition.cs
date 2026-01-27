using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<OrderTaskResponseBodyPosition>))]
[Serializable]
public readonly record struct OrderTaskResponseBodyPosition : IStringEnum
{
    public static readonly OrderTaskResponseBodyPosition First = new(Values.First);

    public static readonly OrderTaskResponseBodyPosition Last = new(Values.Last);

    public static readonly OrderTaskResponseBodyPosition Any = new(Values.Any);

    public OrderTaskResponseBodyPosition(string value)
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
    public static OrderTaskResponseBodyPosition FromCustom(string value)
    {
        return new OrderTaskResponseBodyPosition(value);
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

    public static bool operator ==(OrderTaskResponseBodyPosition value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrderTaskResponseBodyPosition value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrderTaskResponseBodyPosition value) => value.Value;

    public static explicit operator OrderTaskResponseBodyPosition(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string First = "first";

        public const string Last = "last";

        public const string Any = "any";
    }
}
