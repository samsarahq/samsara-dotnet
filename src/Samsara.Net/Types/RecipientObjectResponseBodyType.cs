using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<RecipientObjectResponseBodyType>))]
[Serializable]
public readonly record struct RecipientObjectResponseBodyType : IStringEnum
{
    public static readonly RecipientObjectResponseBodyType User = new(Values.User);

    public static readonly RecipientObjectResponseBodyType Contact = new(Values.Contact);

    public static readonly RecipientObjectResponseBodyType Role = new(Values.Role);

    public RecipientObjectResponseBodyType(string value)
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
    public static RecipientObjectResponseBodyType FromCustom(string value)
    {
        return new RecipientObjectResponseBodyType(value);
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

    public static bool operator ==(RecipientObjectResponseBodyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RecipientObjectResponseBodyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RecipientObjectResponseBodyType value) => value.Value;

    public static explicit operator RecipientObjectResponseBodyType(string value) => new(value);

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
