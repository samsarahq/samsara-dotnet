using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Maintenance;

[JsonConverter(typeof(StringEnumSerializer<CreateDvirRequestSafetyStatus>))]
[Serializable]
public readonly record struct CreateDvirRequestSafetyStatus : IStringEnum
{
    public static readonly CreateDvirRequestSafetyStatus Safe = new(Values.Safe);

    public static readonly CreateDvirRequestSafetyStatus Unsafe = new(Values.Unsafe);

    public CreateDvirRequestSafetyStatus(string value)
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
    public static CreateDvirRequestSafetyStatus FromCustom(string value)
    {
        return new CreateDvirRequestSafetyStatus(value);
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

    public static bool operator ==(CreateDvirRequestSafetyStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreateDvirRequestSafetyStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreateDvirRequestSafetyStatus value) => value.Value;

    public static explicit operator CreateDvirRequestSafetyStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Safe = "safe";

        public const string Unsafe = "unsafe";
    }
}
