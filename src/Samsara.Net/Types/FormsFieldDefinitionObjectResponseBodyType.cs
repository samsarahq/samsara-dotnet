using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FormsFieldDefinitionObjectResponseBodyType>))]
[Serializable]
public readonly record struct FormsFieldDefinitionObjectResponseBodyType : IStringEnum
{
    public static readonly FormsFieldDefinitionObjectResponseBodyType Number = new(Values.Number);

    public static readonly FormsFieldDefinitionObjectResponseBodyType Text = new(Values.Text);

    public static readonly FormsFieldDefinitionObjectResponseBodyType MultipleChoice = new(
        Values.MultipleChoice
    );

    public static readonly FormsFieldDefinitionObjectResponseBodyType CheckBoxes = new(
        Values.CheckBoxes
    );

    public static readonly FormsFieldDefinitionObjectResponseBodyType Media = new(Values.Media);

    public static readonly FormsFieldDefinitionObjectResponseBodyType Datetime = new(
        Values.Datetime
    );

    public static readonly FormsFieldDefinitionObjectResponseBodyType Signature = new(
        Values.Signature
    );

    public static readonly FormsFieldDefinitionObjectResponseBodyType Asset = new(Values.Asset);

    public static readonly FormsFieldDefinitionObjectResponseBodyType Person = new(Values.Person);

    public static readonly FormsFieldDefinitionObjectResponseBodyType Geofence = new(
        Values.Geofence
    );

    public static readonly FormsFieldDefinitionObjectResponseBodyType Instruction = new(
        Values.Instruction
    );

    public static readonly FormsFieldDefinitionObjectResponseBodyType MediaInstruction = new(
        Values.MediaInstruction
    );

    public static readonly FormsFieldDefinitionObjectResponseBodyType Table = new(Values.Table);

    public FormsFieldDefinitionObjectResponseBodyType(string value)
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
    public static FormsFieldDefinitionObjectResponseBodyType FromCustom(string value)
    {
        return new FormsFieldDefinitionObjectResponseBodyType(value);
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
        FormsFieldDefinitionObjectResponseBodyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FormsFieldDefinitionObjectResponseBodyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(FormsFieldDefinitionObjectResponseBodyType value) =>
        value.Value;

    public static explicit operator FormsFieldDefinitionObjectResponseBodyType(string value) =>
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

        public const string Asset = "asset";

        public const string Person = "person";

        public const string Geofence = "geofence";

        public const string Instruction = "instruction";

        public const string MediaInstruction = "media_instruction";

        public const string Table = "table";
    }
}
