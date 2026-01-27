using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<AttributeAttributeType>))]
[Serializable]
public readonly record struct AttributeAttributeType : IStringEnum
{
    public static readonly AttributeAttributeType SingleSelect = new(Values.SingleSelect);

    public static readonly AttributeAttributeType MultiSelect = new(Values.MultiSelect);

    public static readonly AttributeAttributeType Text = new(Values.Text);

    public static readonly AttributeAttributeType FreeformMultiSelect = new(
        Values.FreeformMultiSelect
    );

    public static readonly AttributeAttributeType Number = new(Values.Number);

    public static readonly AttributeAttributeType Date = new(Values.Date);

    public AttributeAttributeType(string value)
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
    public static AttributeAttributeType FromCustom(string value)
    {
        return new AttributeAttributeType(value);
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

    public static bool operator ==(AttributeAttributeType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AttributeAttributeType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AttributeAttributeType value) => value.Value;

    public static explicit operator AttributeAttributeType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string SingleSelect = "single-select";

        public const string MultiSelect = "multi-select";

        public const string Text = "text";

        public const string FreeformMultiSelect = "freeform-multi-select";

        public const string Number = "number";

        public const string Date = "date";
    }
}
