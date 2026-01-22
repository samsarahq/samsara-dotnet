using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Users;

[JsonConverter(typeof(StringEnumSerializer<CreateUserRequestAuthType>))]
[Serializable]
public readonly record struct CreateUserRequestAuthType : IStringEnum
{
    public static readonly CreateUserRequestAuthType Default = new(Values.Default);

    public static readonly CreateUserRequestAuthType Saml = new(Values.Saml);

    public CreateUserRequestAuthType(string value)
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
    public static CreateUserRequestAuthType FromCustom(string value)
    {
        return new CreateUserRequestAuthType(value);
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

    public static bool operator ==(CreateUserRequestAuthType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreateUserRequestAuthType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreateUserRequestAuthType value) => value.Value;

    public static explicit operator CreateUserRequestAuthType(string value) => new(value);

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
