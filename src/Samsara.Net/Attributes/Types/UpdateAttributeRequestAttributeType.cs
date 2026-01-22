using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Attributes;

[JsonConverter(typeof(StringEnumSerializer<UpdateAttributeRequestAttributeType>))]
[Serializable]
public readonly record struct UpdateAttributeRequestAttributeType : IStringEnum
{
    public static readonly UpdateAttributeRequestAttributeType SingleSelect = new(
        Values.SingleSelect
    );

    public static readonly UpdateAttributeRequestAttributeType MultiSelect = new(
        Values.MultiSelect
    );

    public static readonly UpdateAttributeRequestAttributeType Text = new(Values.Text);

    public static readonly UpdateAttributeRequestAttributeType FreeformMultiSelect = new(
        Values.FreeformMultiSelect
    );

    public static readonly UpdateAttributeRequestAttributeType Number = new(Values.Number);

    public static readonly UpdateAttributeRequestAttributeType Date = new(Values.Date);

    public UpdateAttributeRequestAttributeType(string value)
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
    public static UpdateAttributeRequestAttributeType FromCustom(string value)
    {
        return new UpdateAttributeRequestAttributeType(value);
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

    public static bool operator ==(UpdateAttributeRequestAttributeType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpdateAttributeRequestAttributeType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpdateAttributeRequestAttributeType value) =>
        value.Value;

    public static explicit operator UpdateAttributeRequestAttributeType(string value) => new(value);

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
