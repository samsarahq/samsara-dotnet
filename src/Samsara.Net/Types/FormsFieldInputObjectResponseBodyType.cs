using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FormsFieldInputObjectResponseBodyType>))]
[Serializable]
public readonly record struct FormsFieldInputObjectResponseBodyType : IStringEnum
{
    public static readonly FormsFieldInputObjectResponseBodyType Number = new(Values.Number);

    public static readonly FormsFieldInputObjectResponseBodyType Text = new(Values.Text);

    public static readonly FormsFieldInputObjectResponseBodyType MultipleChoice = new(
        Values.MultipleChoice
    );

    public static readonly FormsFieldInputObjectResponseBodyType CheckBoxes = new(
        Values.CheckBoxes
    );

    public static readonly FormsFieldInputObjectResponseBodyType Datetime = new(Values.Datetime);

    public static readonly FormsFieldInputObjectResponseBodyType Signature = new(Values.Signature);

    public static readonly FormsFieldInputObjectResponseBodyType Media = new(Values.Media);

    public static readonly FormsFieldInputObjectResponseBodyType Asset = new(Values.Asset);

    public static readonly FormsFieldInputObjectResponseBodyType Table = new(Values.Table);

    public static readonly FormsFieldInputObjectResponseBodyType Person = new(Values.Person);

    public static readonly FormsFieldInputObjectResponseBodyType Geofence = new(Values.Geofence);

    public FormsFieldInputObjectResponseBodyType(string value)
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
    public static FormsFieldInputObjectResponseBodyType FromCustom(string value)
    {
        return new FormsFieldInputObjectResponseBodyType(value);
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

    public static bool operator ==(FormsFieldInputObjectResponseBodyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FormsFieldInputObjectResponseBodyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FormsFieldInputObjectResponseBodyType value) =>
        value.Value;

    public static explicit operator FormsFieldInputObjectResponseBodyType(string value) =>
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

        public const string Asset = "asset";

        public const string Table = "table";

        public const string Person = "person";

        public const string Geofence = "geofence";
    }
}
