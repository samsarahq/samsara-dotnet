using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<SpeedingSeverityLevelResponseBodySeverityLevel>))]
[Serializable]
public readonly record struct SpeedingSeverityLevelResponseBodySeverityLevel : IStringEnum
{
    public static readonly SpeedingSeverityLevelResponseBodySeverityLevel Light = new(Values.Light);

    public static readonly SpeedingSeverityLevelResponseBodySeverityLevel Moderate = new(
        Values.Moderate
    );

    public static readonly SpeedingSeverityLevelResponseBodySeverityLevel Heavy = new(Values.Heavy);

    public static readonly SpeedingSeverityLevelResponseBodySeverityLevel Severe = new(
        Values.Severe
    );

    public SpeedingSeverityLevelResponseBodySeverityLevel(string value)
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
    public static SpeedingSeverityLevelResponseBodySeverityLevel FromCustom(string value)
    {
        return new SpeedingSeverityLevelResponseBodySeverityLevel(value);
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
        SpeedingSeverityLevelResponseBodySeverityLevel value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SpeedingSeverityLevelResponseBodySeverityLevel value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SpeedingSeverityLevelResponseBodySeverityLevel value) =>
        value.Value;

    public static explicit operator SpeedingSeverityLevelResponseBodySeverityLevel(string value) =>
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
