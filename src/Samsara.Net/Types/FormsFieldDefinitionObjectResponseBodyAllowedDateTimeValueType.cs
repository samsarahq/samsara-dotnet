using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<FormsFieldDefinitionObjectResponseBodyAllowedDateTimeValueType>)
)]
[Serializable]
public readonly record struct FormsFieldDefinitionObjectResponseBodyAllowedDateTimeValueType
    : IStringEnum
{
    public static readonly FormsFieldDefinitionObjectResponseBodyAllowedDateTimeValueType Datetime =
        new(Values.Datetime);

    public static readonly FormsFieldDefinitionObjectResponseBodyAllowedDateTimeValueType Date =
        new(Values.Date);

    public static readonly FormsFieldDefinitionObjectResponseBodyAllowedDateTimeValueType Time =
        new(Values.Time);

    public FormsFieldDefinitionObjectResponseBodyAllowedDateTimeValueType(string value)
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
    public static FormsFieldDefinitionObjectResponseBodyAllowedDateTimeValueType FromCustom(
        string value
    )
    {
        return new FormsFieldDefinitionObjectResponseBodyAllowedDateTimeValueType(value);
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
        FormsFieldDefinitionObjectResponseBodyAllowedDateTimeValueType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FormsFieldDefinitionObjectResponseBodyAllowedDateTimeValueType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FormsFieldDefinitionObjectResponseBodyAllowedDateTimeValueType value
    ) => value.Value;

    public static explicit operator FormsFieldDefinitionObjectResponseBodyAllowedDateTimeValueType(
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
