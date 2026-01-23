using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<UserAuthType>))]
[Serializable]
public readonly record struct UserAuthType : IStringEnum
{
    public static readonly UserAuthType Default = new(Values.Default);

    public static readonly UserAuthType Saml = new(Values.Saml);

    public UserAuthType(string value)
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
    public static UserAuthType FromCustom(string value)
    {
        return new UserAuthType(value);
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

    public static bool operator ==(UserAuthType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UserAuthType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UserAuthType value) => value.Value;

    public static explicit operator UserAuthType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Default = "default";

        public const string Saml = "saml";
    }
}
