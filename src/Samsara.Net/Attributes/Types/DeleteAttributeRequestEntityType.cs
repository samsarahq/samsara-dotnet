using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Attributes;

[JsonConverter(typeof(StringEnumSerializer<DeleteAttributeRequestEntityType>))]
[Serializable]
public readonly record struct DeleteAttributeRequestEntityType : IStringEnum
{
    public static readonly DeleteAttributeRequestEntityType Driver = new(Values.Driver);

    public static readonly DeleteAttributeRequestEntityType Asset = new(Values.Asset);

    public DeleteAttributeRequestEntityType(string value)
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
    public static DeleteAttributeRequestEntityType FromCustom(string value)
    {
        return new DeleteAttributeRequestEntityType(value);
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

    public static bool operator ==(DeleteAttributeRequestEntityType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DeleteAttributeRequestEntityType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DeleteAttributeRequestEntityType value) => value.Value;

    public static explicit operator DeleteAttributeRequestEntityType(string value) => new(value);

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
