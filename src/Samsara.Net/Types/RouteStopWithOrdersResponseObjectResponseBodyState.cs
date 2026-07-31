using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<RouteStopWithOrdersResponseObjectResponseBodyState>))]
[Serializable]
public readonly record struct RouteStopWithOrdersResponseObjectResponseBodyState : IStringEnum
{
    public static readonly RouteStopWithOrdersResponseObjectResponseBodyState Unassigned = new(
        Values.Unassigned
    );

    public static readonly RouteStopWithOrdersResponseObjectResponseBodyState Scheduled = new(
        Values.Scheduled
    );

    public static readonly RouteStopWithOrdersResponseObjectResponseBodyState EnRoute = new(
        Values.EnRoute
    );

    public static readonly RouteStopWithOrdersResponseObjectResponseBodyState Skipped = new(
        Values.Skipped
    );

    public static readonly RouteStopWithOrdersResponseObjectResponseBodyState Arrived = new(
        Values.Arrived
    );

    public static readonly RouteStopWithOrdersResponseObjectResponseBodyState Departed = new(
        Values.Departed
    );

    public RouteStopWithOrdersResponseObjectResponseBodyState(string value)
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
    public static RouteStopWithOrdersResponseObjectResponseBodyState FromCustom(string value)
    {
        return new RouteStopWithOrdersResponseObjectResponseBodyState(value);
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
        RouteStopWithOrdersResponseObjectResponseBodyState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RouteStopWithOrdersResponseObjectResponseBodyState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        RouteStopWithOrdersResponseObjectResponseBodyState value
    ) => value.Value;

    public static explicit operator RouteStopWithOrdersResponseObjectResponseBodyState(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unassigned = "unassigned";

        public const string Scheduled = "scheduled";

        public const string EnRoute = "en route";

        public const string Skipped = "skipped";

        public const string Arrived = "arrived";

        public const string Departed = "departed";
    }
}
