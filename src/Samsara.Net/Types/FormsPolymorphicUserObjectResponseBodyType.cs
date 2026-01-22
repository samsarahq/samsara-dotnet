using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FormsPolymorphicUserObjectResponseBodyType>))]
[Serializable]
public readonly record struct FormsPolymorphicUserObjectResponseBodyType : IStringEnum
{
    public static readonly FormsPolymorphicUserObjectResponseBodyType Driver = new(Values.Driver);

    public static readonly FormsPolymorphicUserObjectResponseBodyType User = new(Values.User);

    public FormsPolymorphicUserObjectResponseBodyType(string value)
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
    public static FormsPolymorphicUserObjectResponseBodyType FromCustom(string value)
    {
        return new FormsPolymorphicUserObjectResponseBodyType(value);
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
        FormsPolymorphicUserObjectResponseBodyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FormsPolymorphicUserObjectResponseBodyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(FormsPolymorphicUserObjectResponseBodyType value) =>
        value.Value;

    public static explicit operator FormsPolymorphicUserObjectResponseBodyType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Driver = "driver";

        public const string User = "user";
    }
}
