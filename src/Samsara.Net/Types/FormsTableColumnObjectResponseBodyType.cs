using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FormsTableColumnObjectResponseBodyType>))]
[Serializable]
public readonly record struct FormsTableColumnObjectResponseBodyType : IStringEnum
{
    public static readonly FormsTableColumnObjectResponseBodyType Text = new(Values.Text);

    public static readonly FormsTableColumnObjectResponseBodyType Number = new(Values.Number);

    public static readonly FormsTableColumnObjectResponseBodyType Datetime = new(Values.Datetime);

    public static readonly FormsTableColumnObjectResponseBodyType CheckBoxes = new(
        Values.CheckBoxes
    );

    public static readonly FormsTableColumnObjectResponseBodyType MultipleChoice = new(
        Values.MultipleChoice
    );

    public static readonly FormsTableColumnObjectResponseBodyType Signature = new(Values.Signature);

    public static readonly FormsTableColumnObjectResponseBodyType Media = new(Values.Media);

    public static readonly FormsTableColumnObjectResponseBodyType Person = new(Values.Person);

    public FormsTableColumnObjectResponseBodyType(string value)
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
    public static FormsTableColumnObjectResponseBodyType FromCustom(string value)
    {
        return new FormsTableColumnObjectResponseBodyType(value);
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

    public static bool operator ==(FormsTableColumnObjectResponseBodyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FormsTableColumnObjectResponseBodyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FormsTableColumnObjectResponseBodyType value) =>
        value.Value;

    public static explicit operator FormsTableColumnObjectResponseBodyType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Text = "text";

        public const string Number = "number";

        public const string Datetime = "datetime";

        public const string CheckBoxes = "check_boxes";

        public const string MultipleChoice = "multiple_choice";

        public const string Signature = "signature";

        public const string Media = "media";

        public const string Person = "person";
    }
}
