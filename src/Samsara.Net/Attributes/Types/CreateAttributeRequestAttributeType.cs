using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Attributes;

[JsonConverter(typeof(StringEnumSerializer<CreateAttributeRequestAttributeType>))]
[Serializable]
public readonly record struct CreateAttributeRequestAttributeType : IStringEnum
{
    public static readonly CreateAttributeRequestAttributeType SingleSelect = new(
        Values.SingleSelect
    );

    public static readonly CreateAttributeRequestAttributeType MultiSelect = new(
        Values.MultiSelect
    );

    public static readonly CreateAttributeRequestAttributeType Text = new(Values.Text);

    public static readonly CreateAttributeRequestAttributeType FreeformMultiSelect = new(
        Values.FreeformMultiSelect
    );

    public static readonly CreateAttributeRequestAttributeType Number = new(Values.Number);

    public static readonly CreateAttributeRequestAttributeType Date = new(Values.Date);

    public CreateAttributeRequestAttributeType(string value)
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
    public static CreateAttributeRequestAttributeType FromCustom(string value)
    {
        return new CreateAttributeRequestAttributeType(value);
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

    public static bool operator ==(CreateAttributeRequestAttributeType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreateAttributeRequestAttributeType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreateAttributeRequestAttributeType value) =>
        value.Value;

    public static explicit operator CreateAttributeRequestAttributeType(string value) => new(value);

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
