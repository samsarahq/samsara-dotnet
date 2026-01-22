using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DvirStreamResponseDataResponseBodySafetyStatus>))]
[Serializable]
public readonly record struct DvirStreamResponseDataResponseBodySafetyStatus : IStringEnum
{
    public static readonly DvirStreamResponseDataResponseBodySafetyStatus Unknown = new(
        Values.Unknown
    );

    public static readonly DvirStreamResponseDataResponseBodySafetyStatus Safe = new(Values.Safe);

    public static readonly DvirStreamResponseDataResponseBodySafetyStatus Unsafe = new(
        Values.Unsafe
    );

    public static readonly DvirStreamResponseDataResponseBodySafetyStatus Resolved = new(
        Values.Resolved
    );

    public DvirStreamResponseDataResponseBodySafetyStatus(string value)
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
    public static DvirStreamResponseDataResponseBodySafetyStatus FromCustom(string value)
    {
        return new DvirStreamResponseDataResponseBodySafetyStatus(value);
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
        DvirStreamResponseDataResponseBodySafetyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DvirStreamResponseDataResponseBodySafetyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DvirStreamResponseDataResponseBodySafetyStatus value) =>
        value.Value;

    public static explicit operator DvirStreamResponseDataResponseBodySafetyStatus(string value) =>
        new(value);

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
