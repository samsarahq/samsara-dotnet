using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DvirGetDvirResponseBodySafetyStatus>))]
[Serializable]
public readonly record struct DvirGetDvirResponseBodySafetyStatus : IStringEnum
{
    public static readonly DvirGetDvirResponseBodySafetyStatus Unknown = new(Values.Unknown);

    public static readonly DvirGetDvirResponseBodySafetyStatus Safe = new(Values.Safe);

    public static readonly DvirGetDvirResponseBodySafetyStatus Unsafe = new(Values.Unsafe);

    public static readonly DvirGetDvirResponseBodySafetyStatus Resolved = new(Values.Resolved);

    public DvirGetDvirResponseBodySafetyStatus(string value)
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
    public static DvirGetDvirResponseBodySafetyStatus FromCustom(string value)
    {
        return new DvirGetDvirResponseBodySafetyStatus(value);
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

    public static bool operator ==(DvirGetDvirResponseBodySafetyStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DvirGetDvirResponseBodySafetyStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DvirGetDvirResponseBodySafetyStatus value) =>
        value.Value;

    public static explicit operator DvirGetDvirResponseBodySafetyStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string Safe = "safe";

        public const string Unsafe = "unsafe";

        public const string Resolved = "resolved";
    }
}
