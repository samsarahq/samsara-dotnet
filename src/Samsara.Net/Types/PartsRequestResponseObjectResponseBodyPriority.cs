using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<PartsRequestResponseObjectResponseBodyPriority>))]
[Serializable]
public readonly record struct PartsRequestResponseObjectResponseBodyPriority : IStringEnum
{
    public static readonly PartsRequestResponseObjectResponseBodyPriority Low = new(Values.Low);

    public static readonly PartsRequestResponseObjectResponseBodyPriority Medium = new(
        Values.Medium
    );

    public static readonly PartsRequestResponseObjectResponseBodyPriority High = new(Values.High);

    public static readonly PartsRequestResponseObjectResponseBodyPriority Critical = new(
        Values.Critical
    );

    public static readonly PartsRequestResponseObjectResponseBodyPriority Unknown = new(
        Values.Unknown
    );

    public PartsRequestResponseObjectResponseBodyPriority(string value)
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
    public static PartsRequestResponseObjectResponseBodyPriority FromCustom(string value)
    {
        return new PartsRequestResponseObjectResponseBodyPriority(value);
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
        PartsRequestResponseObjectResponseBodyPriority value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PartsRequestResponseObjectResponseBodyPriority value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PartsRequestResponseObjectResponseBodyPriority value) =>
        value.Value;

    public static explicit operator PartsRequestResponseObjectResponseBodyPriority(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Low = "low";

        public const string Medium = "medium";

        public const string High = "high";

        public const string Critical = "critical";

        public const string Unknown = "unknown";
    }
}
