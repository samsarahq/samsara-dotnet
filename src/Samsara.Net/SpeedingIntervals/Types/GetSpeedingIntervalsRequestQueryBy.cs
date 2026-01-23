using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.SpeedingIntervals;

[JsonConverter(typeof(StringEnumSerializer<GetSpeedingIntervalsRequestQueryBy>))]
[Serializable]
public readonly record struct GetSpeedingIntervalsRequestQueryBy : IStringEnum
{
    public static readonly GetSpeedingIntervalsRequestQueryBy UpdatedAtTime = new(
        Values.UpdatedAtTime
    );

    public static readonly GetSpeedingIntervalsRequestQueryBy TripStartTime = new(
        Values.TripStartTime
    );

    public GetSpeedingIntervalsRequestQueryBy(string value)
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
    public static GetSpeedingIntervalsRequestQueryBy FromCustom(string value)
    {
        return new GetSpeedingIntervalsRequestQueryBy(value);
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

    public static bool operator ==(GetSpeedingIntervalsRequestQueryBy value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetSpeedingIntervalsRequestQueryBy value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetSpeedingIntervalsRequestQueryBy value) => value.Value;

    public static explicit operator GetSpeedingIntervalsRequestQueryBy(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string UpdatedAtTime = "updatedAtTime";

        public const string TripStartTime = "tripStartTime";
    }
}
