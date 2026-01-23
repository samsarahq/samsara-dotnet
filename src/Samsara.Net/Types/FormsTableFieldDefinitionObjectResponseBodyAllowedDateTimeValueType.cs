using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<FormsTableFieldDefinitionObjectResponseBodyAllowedDateTimeValueType>)
)]
[Serializable]
public readonly record struct FormsTableFieldDefinitionObjectResponseBodyAllowedDateTimeValueType
    : IStringEnum
{
    public static readonly FormsTableFieldDefinitionObjectResponseBodyAllowedDateTimeValueType Datetime =
        new(Values.Datetime);

    public static readonly FormsTableFieldDefinitionObjectResponseBodyAllowedDateTimeValueType Date =
        new(Values.Date);

    public static readonly FormsTableFieldDefinitionObjectResponseBodyAllowedDateTimeValueType Time =
        new(Values.Time);

    public FormsTableFieldDefinitionObjectResponseBodyAllowedDateTimeValueType(string value)
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
    public static FormsTableFieldDefinitionObjectResponseBodyAllowedDateTimeValueType FromCustom(
        string value
    )
    {
        return new FormsTableFieldDefinitionObjectResponseBodyAllowedDateTimeValueType(value);
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
        FormsTableFieldDefinitionObjectResponseBodyAllowedDateTimeValueType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FormsTableFieldDefinitionObjectResponseBodyAllowedDateTimeValueType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FormsTableFieldDefinitionObjectResponseBodyAllowedDateTimeValueType value
    ) => value.Value;

    public static explicit operator FormsTableFieldDefinitionObjectResponseBodyAllowedDateTimeValueType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Datetime = "datetime";

        public const string Date = "date";

        public const string Time = "time";
    }
}
