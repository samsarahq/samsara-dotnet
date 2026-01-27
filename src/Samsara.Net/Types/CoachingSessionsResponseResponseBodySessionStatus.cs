using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<CoachingSessionsResponseResponseBodySessionStatus>))]
[Serializable]
public readonly record struct CoachingSessionsResponseResponseBodySessionStatus : IStringEnum
{
    public static readonly CoachingSessionsResponseResponseBodySessionStatus Unknown = new(
        Values.Unknown
    );

    public static readonly CoachingSessionsResponseResponseBodySessionStatus Upcoming = new(
        Values.Upcoming
    );

    public static readonly CoachingSessionsResponseResponseBodySessionStatus Completed = new(
        Values.Completed
    );

    public static readonly CoachingSessionsResponseResponseBodySessionStatus Deleted = new(
        Values.Deleted
    );

    public CoachingSessionsResponseResponseBodySessionStatus(string value)
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
    public static CoachingSessionsResponseResponseBodySessionStatus FromCustom(string value)
    {
        return new CoachingSessionsResponseResponseBodySessionStatus(value);
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
        CoachingSessionsResponseResponseBodySessionStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CoachingSessionsResponseResponseBodySessionStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CoachingSessionsResponseResponseBodySessionStatus value
    ) => value.Value;

    public static explicit operator CoachingSessionsResponseResponseBodySessionStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string Upcoming = "upcoming";

        public const string Completed = "completed";

        public const string Deleted = "deleted";
    }
}
