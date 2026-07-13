using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DefectsResponseDataResponseBodyDefectSafetyStatus>))]
[Serializable]
public readonly record struct DefectsResponseDataResponseBodyDefectSafetyStatus : IStringEnum
{
    public static readonly DefectsResponseDataResponseBodyDefectSafetyStatus Safe = new(
        Values.Safe
    );

    public static readonly DefectsResponseDataResponseBodyDefectSafetyStatus Unsafe = new(
        Values.Unsafe
    );

    public DefectsResponseDataResponseBodyDefectSafetyStatus(string value)
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
    public static DefectsResponseDataResponseBodyDefectSafetyStatus FromCustom(string value)
    {
        return new DefectsResponseDataResponseBodyDefectSafetyStatus(value);
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
        DefectsResponseDataResponseBodyDefectSafetyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DefectsResponseDataResponseBodyDefectSafetyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DefectsResponseDataResponseBodyDefectSafetyStatus value
    ) => value.Value;

    public static explicit operator DefectsResponseDataResponseBodyDefectSafetyStatus(
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
