using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FormSubmissionRequestFieldInputObjectRequestBodyType>))]
[Serializable]
public readonly record struct FormSubmissionRequestFieldInputObjectRequestBodyType : IStringEnum
{
    public static readonly FormSubmissionRequestFieldInputObjectRequestBodyType Number = new(
        Values.Number
    );

    public static readonly FormSubmissionRequestFieldInputObjectRequestBodyType Text = new(
        Values.Text
    );

    public static readonly FormSubmissionRequestFieldInputObjectRequestBodyType MultipleChoice =
        new(Values.MultipleChoice);

    public static readonly FormSubmissionRequestFieldInputObjectRequestBodyType CheckBoxes = new(
        Values.CheckBoxes
    );

    public static readonly FormSubmissionRequestFieldInputObjectRequestBodyType Datetime = new(
        Values.Datetime
    );

    public static readonly FormSubmissionRequestFieldInputObjectRequestBodyType Asset = new(
        Values.Asset
    );

    public static readonly FormSubmissionRequestFieldInputObjectRequestBodyType Person = new(
        Values.Person
    );

    public static readonly FormSubmissionRequestFieldInputObjectRequestBodyType Table = new(
        Values.Table
    );

    public static readonly FormSubmissionRequestFieldInputObjectRequestBodyType Geofence = new(
        Values.Geofence
    );

    public FormSubmissionRequestFieldInputObjectRequestBodyType(string value)
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
    public static FormSubmissionRequestFieldInputObjectRequestBodyType FromCustom(string value)
    {
        return new FormSubmissionRequestFieldInputObjectRequestBodyType(value);
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
        FormSubmissionRequestFieldInputObjectRequestBodyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FormSubmissionRequestFieldInputObjectRequestBodyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FormSubmissionRequestFieldInputObjectRequestBodyType value
    ) => value.Value;

    public static explicit operator FormSubmissionRequestFieldInputObjectRequestBodyType(
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

        public const string Asset = "asset";

        public const string Person = "person";

        public const string Table = "table";

        public const string Geofence = "geofence";
    }
}
