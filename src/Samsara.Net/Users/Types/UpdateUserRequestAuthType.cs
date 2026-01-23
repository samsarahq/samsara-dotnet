using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Users;

[JsonConverter(typeof(StringEnumSerializer<UpdateUserRequestAuthType>))]
[Serializable]
public readonly record struct UpdateUserRequestAuthType : IStringEnum
{
    public static readonly UpdateUserRequestAuthType Default = new(Values.Default);

    public static readonly UpdateUserRequestAuthType Saml = new(Values.Saml);

    public UpdateUserRequestAuthType(string value)
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
    public static UpdateUserRequestAuthType FromCustom(string value)
    {
        return new UpdateUserRequestAuthType(value);
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

    public static bool operator ==(UpdateUserRequestAuthType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpdateUserRequestAuthType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpdateUserRequestAuthType value) => value.Value;

    public static explicit operator UpdateUserRequestAuthType(string value) => new(value);

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
