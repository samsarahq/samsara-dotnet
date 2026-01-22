using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DvirSafetyStatus>))]
[Serializable]
public readonly record struct DvirSafetyStatus : IStringEnum
{
    public static readonly DvirSafetyStatus Safe = new(Values.Safe);

    public static readonly DvirSafetyStatus Unsafe = new(Values.Unsafe);

    public static readonly DvirSafetyStatus Resolved = new(Values.Resolved);

    public DvirSafetyStatus(string value)
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
    public static DvirSafetyStatus FromCustom(string value)
    {
        return new DvirSafetyStatus(value);
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

    public static bool operator ==(DvirSafetyStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DvirSafetyStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DvirSafetyStatus value) => value.Value;

    public static explicit operator DvirSafetyStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Safe = "safe";

        public const string Unsafe = "unsafe";

        public const string Resolved = "resolved";
    }
}
