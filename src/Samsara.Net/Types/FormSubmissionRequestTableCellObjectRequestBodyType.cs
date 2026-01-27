using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FormSubmissionRequestTableCellObjectRequestBodyType>))]
[Serializable]
public readonly record struct FormSubmissionRequestTableCellObjectRequestBodyType : IStringEnum
{
    public static readonly FormSubmissionRequestTableCellObjectRequestBodyType Number = new(
        Values.Number
    );

    public static readonly FormSubmissionRequestTableCellObjectRequestBodyType Text = new(
        Values.Text
    );

    public static readonly FormSubmissionRequestTableCellObjectRequestBodyType MultipleChoice = new(
        Values.MultipleChoice
    );

    public static readonly FormSubmissionRequestTableCellObjectRequestBodyType CheckBoxes = new(
        Values.CheckBoxes
    );

    public static readonly FormSubmissionRequestTableCellObjectRequestBodyType Datetime = new(
        Values.Datetime
    );

    public static readonly FormSubmissionRequestTableCellObjectRequestBodyType Person = new(
        Values.Person
    );

    public FormSubmissionRequestTableCellObjectRequestBodyType(string value)
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
    public static FormSubmissionRequestTableCellObjectRequestBodyType FromCustom(string value)
    {
        return new FormSubmissionRequestTableCellObjectRequestBodyType(value);
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
        FormSubmissionRequestTableCellObjectRequestBodyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FormSubmissionRequestTableCellObjectRequestBodyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FormSubmissionRequestTableCellObjectRequestBodyType value
    ) => value.Value;

    public static explicit operator FormSubmissionRequestTableCellObjectRequestBodyType(
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

        public const string Person = "person";
    }
}
