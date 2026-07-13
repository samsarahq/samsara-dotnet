using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DvirDefectGetDefectResponseBodyDefectSafetyStatus>))]
[Serializable]
public readonly record struct DvirDefectGetDefectResponseBodyDefectSafetyStatus : IStringEnum
{
    public static readonly DvirDefectGetDefectResponseBodyDefectSafetyStatus Safe = new(
        Values.Safe
    );

    public static readonly DvirDefectGetDefectResponseBodyDefectSafetyStatus Unsafe = new(
        Values.Unsafe
    );

    public DvirDefectGetDefectResponseBodyDefectSafetyStatus(string value)
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
    public static DvirDefectGetDefectResponseBodyDefectSafetyStatus FromCustom(string value)
    {
        return new DvirDefectGetDefectResponseBodyDefectSafetyStatus(value);
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
        DvirDefectGetDefectResponseBodyDefectSafetyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DvirDefectGetDefectResponseBodyDefectSafetyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DvirDefectGetDefectResponseBodyDefectSafetyStatus value
    ) => value.Value;

    public static explicit operator DvirDefectGetDefectResponseBodyDefectSafetyStatus(
        string value
    ) => new(value);

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
