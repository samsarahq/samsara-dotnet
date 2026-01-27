using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<ColumnResponseBodyDataType>))]
[Serializable]
public readonly record struct ColumnResponseBodyDataType : IStringEnum
{
    public static readonly ColumnResponseBodyDataType String = new(Values.String);

    public static readonly ColumnResponseBodyDataType Integer = new(Values.Integer);

    public static readonly ColumnResponseBodyDataType Float = new(Values.Float);

    public static readonly ColumnResponseBodyDataType Timestamp = new(Values.Timestamp);

    public static readonly ColumnResponseBodyDataType Unknown = new(Values.Unknown);

    public ColumnResponseBodyDataType(string value)
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
    public static ColumnResponseBodyDataType FromCustom(string value)
    {
        return new ColumnResponseBodyDataType(value);
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

    public static bool operator ==(ColumnResponseBodyDataType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ColumnResponseBodyDataType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ColumnResponseBodyDataType value) => value.Value;

    public static explicit operator ColumnResponseBodyDataType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string String = "string";

        public const string Integer = "integer";

        public const string Float = "float";

        public const string Timestamp = "timestamp";

        public const string Unknown = "unknown";
    }
}
