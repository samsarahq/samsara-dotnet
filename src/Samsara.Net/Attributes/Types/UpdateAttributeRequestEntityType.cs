using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Attributes;

[JsonConverter(typeof(StringEnumSerializer<UpdateAttributeRequestEntityType>))]
[Serializable]
public readonly record struct UpdateAttributeRequestEntityType : IStringEnum
{
    public static readonly UpdateAttributeRequestEntityType Driver = new(Values.Driver);

    public static readonly UpdateAttributeRequestEntityType Asset = new(Values.Asset);

    public UpdateAttributeRequestEntityType(string value)
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
    public static UpdateAttributeRequestEntityType FromCustom(string value)
    {
        return new UpdateAttributeRequestEntityType(value);
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

    public static bool operator ==(UpdateAttributeRequestEntityType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpdateAttributeRequestEntityType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpdateAttributeRequestEntityType value) => value.Value;

    public static explicit operator UpdateAttributeRequestEntityType(string value) => new(value);

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
