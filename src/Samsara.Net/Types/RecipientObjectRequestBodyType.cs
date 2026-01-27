using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<RecipientObjectRequestBodyType>))]
[Serializable]
public readonly record struct RecipientObjectRequestBodyType : IStringEnum
{
    public static readonly RecipientObjectRequestBodyType User = new(Values.User);

    public static readonly RecipientObjectRequestBodyType Contact = new(Values.Contact);

    public static readonly RecipientObjectRequestBodyType Role = new(Values.Role);

    public RecipientObjectRequestBodyType(string value)
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
    public static RecipientObjectRequestBodyType FromCustom(string value)
    {
        return new RecipientObjectRequestBodyType(value);
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

    public static bool operator ==(RecipientObjectRequestBodyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RecipientObjectRequestBodyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RecipientObjectRequestBodyType value) => value.Value;

    public static explicit operator RecipientObjectRequestBodyType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string User = "user";

        public const string Contact = "contact";

        public const string Role = "role";
    }
}
