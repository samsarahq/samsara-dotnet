using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Attributes;

[JsonConverter(typeof(StringEnumSerializer<GetAttributesByEntityTypeRequestEntityType>))]
[Serializable]
public readonly record struct GetAttributesByEntityTypeRequestEntityType : IStringEnum
{
    public static readonly GetAttributesByEntityTypeRequestEntityType Driver = new(Values.Driver);

    public static readonly GetAttributesByEntityTypeRequestEntityType Asset = new(Values.Asset);

    public GetAttributesByEntityTypeRequestEntityType(string value)
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
    public static GetAttributesByEntityTypeRequestEntityType FromCustom(string value)
    {
        return new GetAttributesByEntityTypeRequestEntityType(value);
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
        GetAttributesByEntityTypeRequestEntityType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GetAttributesByEntityTypeRequestEntityType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GetAttributesByEntityTypeRequestEntityType value) =>
        value.Value;

    public static explicit operator GetAttributesByEntityTypeRequestEntityType(string value) =>
        new(value);

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
