using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<RouteEventResponseResponseBodyEventType>))]
[Serializable]
public readonly record struct RouteEventResponseResponseBodyEventType : IStringEnum
{
    public static readonly RouteEventResponseResponseBodyEventType StopArrived = new(
        Values.StopArrived
    );

    public static readonly RouteEventResponseResponseBodyEventType StopCompleted = new(
        Values.StopCompleted
    );

    public static readonly RouteEventResponseResponseBodyEventType StopEnRoute = new(
        Values.StopEnRoute
    );

    public static readonly RouteEventResponseResponseBodyEventType StopSkipped = new(
        Values.StopSkipped
    );

    public static readonly RouteEventResponseResponseBodyEventType StopTaskCompleted = new(
        Values.StopTaskCompleted
    );

    public static readonly RouteEventResponseResponseBodyEventType StopTaskSkipped = new(
        Values.StopTaskSkipped
    );

    public static readonly RouteEventResponseResponseBodyEventType StopEtaUpdated = new(
        Values.StopEtaUpdated
    );

    public static readonly RouteEventResponseResponseBodyEventType Unspecified = new(
        Values.Unspecified
    );

    public RouteEventResponseResponseBodyEventType(string value)
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
    public static RouteEventResponseResponseBodyEventType FromCustom(string value)
    {
        return new RouteEventResponseResponseBodyEventType(value);
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

    public static bool operator ==(RouteEventResponseResponseBodyEventType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RouteEventResponseResponseBodyEventType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RouteEventResponseResponseBodyEventType value) =>
        value.Value;

    public static explicit operator RouteEventResponseResponseBodyEventType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string StopArrived = "stopArrived";

        public const string StopCompleted = "stopCompleted";

        public const string StopEnRoute = "stopEnRoute";

        public const string StopSkipped = "stopSkipped";

        public const string StopTaskCompleted = "stopTaskCompleted";

        public const string StopTaskSkipped = "stopTaskSkipped";

        public const string StopEtaUpdated = "stopEtaUpdated";

        public const string Unspecified = "unspecified";
    }
}
