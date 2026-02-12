using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Attributes;

[JsonConverter(typeof(StringEnumSerializer<DeleteAttributesRequestEntityType>))]
[Serializable]
public readonly record struct DeleteAttributesRequestEntityType : IStringEnum
{
    public static readonly DeleteAttributesRequestEntityType Driver = new(Values.Driver);

    public static readonly DeleteAttributesRequestEntityType Asset = new(Values.Asset);

    public DeleteAttributesRequestEntityType(string value)
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
    public static DeleteAttributesRequestEntityType FromCustom(string value)
    {
        return new DeleteAttributesRequestEntityType(value);
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

    public static bool operator ==(DeleteAttributesRequestEntityType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DeleteAttributesRequestEntityType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DeleteAttributesRequestEntityType value) => value.Value;

    public static explicit operator DeleteAttributesRequestEntityType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Driver = "driver";

        public const string Asset = "asset";
    }
}
