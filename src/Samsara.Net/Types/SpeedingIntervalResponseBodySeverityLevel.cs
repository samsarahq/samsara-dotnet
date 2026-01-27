using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<SpeedingIntervalResponseBodySeverityLevel>))]
[Serializable]
public readonly record struct SpeedingIntervalResponseBodySeverityLevel : IStringEnum
{
    public static readonly SpeedingIntervalResponseBodySeverityLevel Light = new(Values.Light);

    public static readonly SpeedingIntervalResponseBodySeverityLevel Moderate = new(
        Values.Moderate
    );

    public static readonly SpeedingIntervalResponseBodySeverityLevel Heavy = new(Values.Heavy);

    public static readonly SpeedingIntervalResponseBodySeverityLevel Severe = new(Values.Severe);

    public SpeedingIntervalResponseBodySeverityLevel(string value)
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
    public static SpeedingIntervalResponseBodySeverityLevel FromCustom(string value)
    {
        return new SpeedingIntervalResponseBodySeverityLevel(value);
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
        SpeedingIntervalResponseBodySeverityLevel value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SpeedingIntervalResponseBodySeverityLevel value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SpeedingIntervalResponseBodySeverityLevel value) =>
        value.Value;

    public static explicit operator SpeedingIntervalResponseBodySeverityLevel(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Light = "light";

        public const string Moderate = "moderate";

        public const string Heavy = "heavy";

        public const string Severe = "severe";
    }
}
