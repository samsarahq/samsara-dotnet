using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FormsTableFieldDefinitionObjectResponseBodyType>))]
[Serializable]
public readonly record struct FormsTableFieldDefinitionObjectResponseBodyType : IStringEnum
{
    public static readonly FormsTableFieldDefinitionObjectResponseBodyType Number = new(
        Values.Number
    );

    public static readonly FormsTableFieldDefinitionObjectResponseBodyType Text = new(Values.Text);

    public static readonly FormsTableFieldDefinitionObjectResponseBodyType MultipleChoice = new(
        Values.MultipleChoice
    );

    public static readonly FormsTableFieldDefinitionObjectResponseBodyType CheckBoxes = new(
        Values.CheckBoxes
    );

    public static readonly FormsTableFieldDefinitionObjectResponseBodyType Media = new(
        Values.Media
    );

    public static readonly FormsTableFieldDefinitionObjectResponseBodyType Datetime = new(
        Values.Datetime
    );

    public static readonly FormsTableFieldDefinitionObjectResponseBodyType Signature = new(
        Values.Signature
    );

    public static readonly FormsTableFieldDefinitionObjectResponseBodyType Person = new(
        Values.Person
    );

    public FormsTableFieldDefinitionObjectResponseBodyType(string value)
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
    public static FormsTableFieldDefinitionObjectResponseBodyType FromCustom(string value)
    {
        return new FormsTableFieldDefinitionObjectResponseBodyType(value);
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
        FormsTableFieldDefinitionObjectResponseBodyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FormsTableFieldDefinitionObjectResponseBodyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(FormsTableFieldDefinitionObjectResponseBodyType value) =>
        value.Value;

    public static explicit operator FormsTableFieldDefinitionObjectResponseBodyType(string value) =>
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

        public const string Media = "media";

        public const string Datetime = "datetime";

        public const string Signature = "signature";

        public const string Person = "person";
    }
}
