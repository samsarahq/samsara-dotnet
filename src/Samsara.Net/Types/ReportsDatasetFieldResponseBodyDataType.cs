using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<ReportsDatasetFieldResponseBodyDataType>))]
[Serializable]
public readonly record struct ReportsDatasetFieldResponseBodyDataType : IStringEnum
{
    public static readonly ReportsDatasetFieldResponseBodyDataType String = new(Values.String);

    public static readonly ReportsDatasetFieldResponseBodyDataType Integer = new(Values.Integer);

    public static readonly ReportsDatasetFieldResponseBodyDataType Float = new(Values.Float);

    public static readonly ReportsDatasetFieldResponseBodyDataType Timestamp = new(
        Values.Timestamp
    );

    public static readonly ReportsDatasetFieldResponseBodyDataType Unknown = new(Values.Unknown);

    public ReportsDatasetFieldResponseBodyDataType(string value)
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
    public static ReportsDatasetFieldResponseBodyDataType FromCustom(string value)
    {
        return new ReportsDatasetFieldResponseBodyDataType(value);
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

    public static bool operator ==(ReportsDatasetFieldResponseBodyDataType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ReportsDatasetFieldResponseBodyDataType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ReportsDatasetFieldResponseBodyDataType value) =>
        value.Value;

    public static explicit operator ReportsDatasetFieldResponseBodyDataType(string value) =>
        new(value);

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
