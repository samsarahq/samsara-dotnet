using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FormsTableCellObjectResponseBodyType>))]
[Serializable]
public readonly record struct FormsTableCellObjectResponseBodyType : IStringEnum
{
    public static readonly FormsTableCellObjectResponseBodyType Number = new(Values.Number);

    public static readonly FormsTableCellObjectResponseBodyType Text = new(Values.Text);

    public static readonly FormsTableCellObjectResponseBodyType MultipleChoice = new(
        Values.MultipleChoice
    );

    public static readonly FormsTableCellObjectResponseBodyType CheckBoxes = new(Values.CheckBoxes);

    public static readonly FormsTableCellObjectResponseBodyType Datetime = new(Values.Datetime);

    public static readonly FormsTableCellObjectResponseBodyType Signature = new(Values.Signature);

    public static readonly FormsTableCellObjectResponseBodyType Media = new(Values.Media);

    public static readonly FormsTableCellObjectResponseBodyType Person = new(Values.Person);

    public FormsTableCellObjectResponseBodyType(string value)
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
    public static FormsTableCellObjectResponseBodyType FromCustom(string value)
    {
        return new FormsTableCellObjectResponseBodyType(value);
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

    public static bool operator ==(FormsTableCellObjectResponseBodyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FormsTableCellObjectResponseBodyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FormsTableCellObjectResponseBodyType value) =>
        value.Value;

    public static explicit operator FormsTableCellObjectResponseBodyType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Number = "number";

        public const string Text = "text";

        public const string MultipleChoice = "multiple_choice";

        public const string CheckBoxes = "check_boxes";

        public const string Datetime = "datetime";

        public const string Signature = "signature";

        public const string Media = "media";

        public const string Person = "person";
    }
}
