using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<CoachingSessionsResponseResponseBodySessionType>))]
[Serializable]
public readonly record struct CoachingSessionsResponseResponseBodySessionType : IStringEnum
{
    public static readonly CoachingSessionsResponseResponseBodySessionType DriverSelfOneOff = new(
        Values.DriverSelfOneOff
    );

    public static readonly CoachingSessionsResponseResponseBodySessionType DriverSelfSession = new(
        Values.DriverSelfSession
    );

    public static readonly CoachingSessionsResponseResponseBodySessionType OneOff = new(
        Values.OneOff
    );

    public static readonly CoachingSessionsResponseResponseBodySessionType Session = new(
        Values.Session
    );

    public static readonly CoachingSessionsResponseResponseBodySessionType Unknown = new(
        Values.Unknown
    );

    public CoachingSessionsResponseResponseBodySessionType(string value)
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
    public static CoachingSessionsResponseResponseBodySessionType FromCustom(string value)
    {
        return new CoachingSessionsResponseResponseBodySessionType(value);
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
        CoachingSessionsResponseResponseBodySessionType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CoachingSessionsResponseResponseBodySessionType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CoachingSessionsResponseResponseBodySessionType value) =>
        value.Value;

    public static explicit operator CoachingSessionsResponseResponseBodySessionType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string DriverSelfOneOff = "driverSelfOneOff";

        public const string DriverSelfSession = "driverSelfSession";

        public const string OneOff = "oneOff";

        public const string Session = "session";

        public const string Unknown = "unknown";
    }
}
