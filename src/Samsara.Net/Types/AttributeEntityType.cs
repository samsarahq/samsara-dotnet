using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<AttributeEntityType>))]
[Serializable]
public readonly record struct AttributeEntityType : IStringEnum
{
    public static readonly AttributeEntityType Driver = new(Values.Driver);

    public static readonly AttributeEntityType Asset = new(Values.Asset);

    public AttributeEntityType(string value)
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
    public static AttributeEntityType FromCustom(string value)
    {
        return new AttributeEntityType(value);
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

    public static bool operator ==(AttributeEntityType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AttributeEntityType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AttributeEntityType value) => value.Value;

    public static explicit operator AttributeEntityType(string value) => new(value);

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
