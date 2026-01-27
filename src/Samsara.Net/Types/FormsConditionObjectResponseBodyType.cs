using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FormsConditionObjectResponseBodyType>))]
[Serializable]
public readonly record struct FormsConditionObjectResponseBodyType : IStringEnum
{
    public static readonly FormsConditionObjectResponseBodyType MultipleChoiceValueCondition = new(
        Values.MultipleChoiceValueCondition
    );

    public static readonly FormsConditionObjectResponseBodyType CheckBoxesValueCondition = new(
        Values.CheckBoxesValueCondition
    );

    public FormsConditionObjectResponseBodyType(string value)
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
    public static FormsConditionObjectResponseBodyType FromCustom(string value)
    {
        return new FormsConditionObjectResponseBodyType(value);
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

    public static bool operator ==(FormsConditionObjectResponseBodyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FormsConditionObjectResponseBodyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FormsConditionObjectResponseBodyType value) =>
        value.Value;

    public static explicit operator FormsConditionObjectResponseBodyType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string MultipleChoiceValueCondition = "multipleChoiceValueCondition";

        public const string CheckBoxesValueCondition = "checkBoxesValueCondition";
    }
}
