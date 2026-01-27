using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<ReportColumnsObjectResponseBodyDataType>))]
[Serializable]
public readonly record struct ReportColumnsObjectResponseBodyDataType : IStringEnum
{
    public static readonly ReportColumnsObjectResponseBodyDataType String = new(Values.String);

    public static readonly ReportColumnsObjectResponseBodyDataType Float = new(Values.Float);

    public static readonly ReportColumnsObjectResponseBodyDataType Integer = new(Values.Integer);

    public static readonly ReportColumnsObjectResponseBodyDataType Timestamp = new(
        Values.Timestamp
    );

    public static readonly ReportColumnsObjectResponseBodyDataType Unknown = new(Values.Unknown);

    public ReportColumnsObjectResponseBodyDataType(string value)
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
    public static ReportColumnsObjectResponseBodyDataType FromCustom(string value)
    {
        return new ReportColumnsObjectResponseBodyDataType(value);
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

    public static bool operator ==(ReportColumnsObjectResponseBodyDataType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ReportColumnsObjectResponseBodyDataType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ReportColumnsObjectResponseBodyDataType value) =>
        value.Value;

    public static explicit operator ReportColumnsObjectResponseBodyDataType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string String = "string";

        public const string Float = "float";

        public const string Integer = "integer";

        public const string Timestamp = "timestamp";

        public const string Unknown = "unknown";
    }
}
