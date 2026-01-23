using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<QualificationFieldInputObjectResponseBodyType>))]
[Serializable]
public readonly record struct QualificationFieldInputObjectResponseBodyType : IStringEnum
{
    public static readonly QualificationFieldInputObjectResponseBodyType Number = new(
        Values.Number
    );

    public static readonly QualificationFieldInputObjectResponseBodyType Text = new(Values.Text);

    public static readonly QualificationFieldInputObjectResponseBodyType MultipleChoice = new(
        Values.MultipleChoice
    );

    public static readonly QualificationFieldInputObjectResponseBodyType CheckBoxes = new(
        Values.CheckBoxes
    );

    public static readonly QualificationFieldInputObjectResponseBodyType Datetime = new(
        Values.Datetime
    );

    public static readonly QualificationFieldInputObjectResponseBodyType Signature = new(
        Values.Signature
    );

    public static readonly QualificationFieldInputObjectResponseBodyType Media = new(Values.Media);

    public static readonly QualificationFieldInputObjectResponseBodyType Table = new(Values.Table);

    public QualificationFieldInputObjectResponseBodyType(string value)
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
    public static QualificationFieldInputObjectResponseBodyType FromCustom(string value)
    {
        return new QualificationFieldInputObjectResponseBodyType(value);
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
        QualificationFieldInputObjectResponseBodyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        QualificationFieldInputObjectResponseBodyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(QualificationFieldInputObjectResponseBodyType value) =>
        value.Value;

    public static explicit operator QualificationFieldInputObjectResponseBodyType(string value) =>
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

        public const string Table = "table";
    }
}
