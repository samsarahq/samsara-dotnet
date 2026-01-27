using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<SafetyScoreSpeedingObjectResponseBodySpeedingType>))]
[Serializable]
public readonly record struct SafetyScoreSpeedingObjectResponseBodySpeedingType : IStringEnum
{
    public static readonly SafetyScoreSpeedingObjectResponseBodySpeedingType Light = new(
        Values.Light
    );

    public static readonly SafetyScoreSpeedingObjectResponseBodySpeedingType Moderate = new(
        Values.Moderate
    );

    public static readonly SafetyScoreSpeedingObjectResponseBodySpeedingType Heavy = new(
        Values.Heavy
    );

    public static readonly SafetyScoreSpeedingObjectResponseBodySpeedingType Severe = new(
        Values.Severe
    );

    public static readonly SafetyScoreSpeedingObjectResponseBodySpeedingType MaxSpeed = new(
        Values.MaxSpeed
    );

    public static readonly SafetyScoreSpeedingObjectResponseBodySpeedingType Unknown = new(
        Values.Unknown
    );

    public SafetyScoreSpeedingObjectResponseBodySpeedingType(string value)
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
    public static SafetyScoreSpeedingObjectResponseBodySpeedingType FromCustom(string value)
    {
        return new SafetyScoreSpeedingObjectResponseBodySpeedingType(value);
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
        SafetyScoreSpeedingObjectResponseBodySpeedingType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SafetyScoreSpeedingObjectResponseBodySpeedingType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SafetyScoreSpeedingObjectResponseBodySpeedingType value
    ) => value.Value;

    public static explicit operator SafetyScoreSpeedingObjectResponseBodySpeedingType(
        string value
    ) => new(value);

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

        public const string MaxSpeed = "maxSpeed";

        public const string Unknown = "unknown";
    }
}
