using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<QualificationRecordRequestFieldInputObjectRequestBodyType>)
)]
[Serializable]
public readonly record struct QualificationRecordRequestFieldInputObjectRequestBodyType
    : IStringEnum
{
    public static readonly QualificationRecordRequestFieldInputObjectRequestBodyType Number = new(
        Values.Number
    );

    public static readonly QualificationRecordRequestFieldInputObjectRequestBodyType Text = new(
        Values.Text
    );

    public static readonly QualificationRecordRequestFieldInputObjectRequestBodyType MultipleChoice =
        new(Values.MultipleChoice);

    public static readonly QualificationRecordRequestFieldInputObjectRequestBodyType CheckBoxes =
        new(Values.CheckBoxes);

    public static readonly QualificationRecordRequestFieldInputObjectRequestBodyType Datetime = new(
        Values.Datetime
    );

    public static readonly QualificationRecordRequestFieldInputObjectRequestBodyType Table = new(
        Values.Table
    );

    public static readonly QualificationRecordRequestFieldInputObjectRequestBodyType Media = new(
        Values.Media
    );

    public static readonly QualificationRecordRequestFieldInputObjectRequestBodyType Signature =
        new(Values.Signature);

    public QualificationRecordRequestFieldInputObjectRequestBodyType(string value)
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
    public static QualificationRecordRequestFieldInputObjectRequestBodyType FromCustom(string value)
    {
        return new QualificationRecordRequestFieldInputObjectRequestBodyType(value);
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
        QualificationRecordRequestFieldInputObjectRequestBodyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        QualificationRecordRequestFieldInputObjectRequestBodyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        QualificationRecordRequestFieldInputObjectRequestBodyType value
    ) => value.Value;

    public static explicit operator QualificationRecordRequestFieldInputObjectRequestBodyType(
        string value
    ) => new(value);

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

        public const string Table = "table";

        public const string Media = "media";

        public const string Signature = "signature";
    }
}
