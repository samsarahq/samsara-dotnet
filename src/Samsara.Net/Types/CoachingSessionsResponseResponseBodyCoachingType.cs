using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<CoachingSessionsResponseResponseBodyCoachingType>))]
[Serializable]
public readonly record struct CoachingSessionsResponseResponseBodyCoachingType : IStringEnum
{
    public static readonly CoachingSessionsResponseResponseBodyCoachingType FullySharedWithManager =
        new(Values.FullySharedWithManager);

    public static readonly CoachingSessionsResponseResponseBodyCoachingType SelfCoaching = new(
        Values.SelfCoaching
    );

    public static readonly CoachingSessionsResponseResponseBodyCoachingType Unknown = new(
        Values.Unknown
    );

    public static readonly CoachingSessionsResponseResponseBodyCoachingType Unshared = new(
        Values.Unshared
    );

    public static readonly CoachingSessionsResponseResponseBodyCoachingType WithManager = new(
        Values.WithManager
    );

    public CoachingSessionsResponseResponseBodyCoachingType(string value)
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
    public static CoachingSessionsResponseResponseBodyCoachingType FromCustom(string value)
    {
        return new CoachingSessionsResponseResponseBodyCoachingType(value);
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
        CoachingSessionsResponseResponseBodyCoachingType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CoachingSessionsResponseResponseBodyCoachingType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CoachingSessionsResponseResponseBodyCoachingType value
    ) => value.Value;

    public static explicit operator CoachingSessionsResponseResponseBodyCoachingType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string FullySharedWithManager = "fullySharedWithManager";

        public const string SelfCoaching = "selfCoaching";

        public const string Unknown = "unknown";

        public const string Unshared = "unshared";

        public const string WithManager = "withManager";
    }
}
