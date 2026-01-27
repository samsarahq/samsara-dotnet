using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<OrderTaskRequestBodyPosition>))]
[Serializable]
public readonly record struct OrderTaskRequestBodyPosition : IStringEnum
{
    public static readonly OrderTaskRequestBodyPosition First = new(Values.First);

    public static readonly OrderTaskRequestBodyPosition Last = new(Values.Last);

    public static readonly OrderTaskRequestBodyPosition Any = new(Values.Any);

    public OrderTaskRequestBodyPosition(string value)
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
    public static OrderTaskRequestBodyPosition FromCustom(string value)
    {
        return new OrderTaskRequestBodyPosition(value);
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

    public static bool operator ==(OrderTaskRequestBodyPosition value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrderTaskRequestBodyPosition value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrderTaskRequestBodyPosition value) => value.Value;

    public static explicit operator OrderTaskRequestBodyPosition(string value) => new(value);

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
