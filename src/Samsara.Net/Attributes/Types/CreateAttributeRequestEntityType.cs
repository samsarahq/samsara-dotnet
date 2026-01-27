using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Attributes;

[JsonConverter(typeof(StringEnumSerializer<CreateAttributeRequestEntityType>))]
[Serializable]
public readonly record struct CreateAttributeRequestEntityType : IStringEnum
{
    public static readonly CreateAttributeRequestEntityType Driver = new(Values.Driver);

    public static readonly CreateAttributeRequestEntityType Asset = new(Values.Asset);

    public CreateAttributeRequestEntityType(string value)
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
    public static CreateAttributeRequestEntityType FromCustom(string value)
    {
        return new CreateAttributeRequestEntityType(value);
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

    public static bool operator ==(CreateAttributeRequestEntityType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreateAttributeRequestEntityType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreateAttributeRequestEntityType value) => value.Value;

    public static explicit operator CreateAttributeRequestEntityType(string value) => new(value);

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
