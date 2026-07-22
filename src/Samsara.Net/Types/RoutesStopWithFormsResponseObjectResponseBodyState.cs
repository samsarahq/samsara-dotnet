using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<RoutesStopWithFormsResponseObjectResponseBodyState>))]
[Serializable]
public readonly record struct RoutesStopWithFormsResponseObjectResponseBodyState : IStringEnum
{
    public static readonly RoutesStopWithFormsResponseObjectResponseBodyState Unassigned = new(
        Values.Unassigned
    );

    public static readonly RoutesStopWithFormsResponseObjectResponseBodyState Scheduled = new(
        Values.Scheduled
    );

    public static readonly RoutesStopWithFormsResponseObjectResponseBodyState EnRoute = new(
        Values.EnRoute
    );

    public static readonly RoutesStopWithFormsResponseObjectResponseBodyState Skipped = new(
        Values.Skipped
    );

    public static readonly RoutesStopWithFormsResponseObjectResponseBodyState Arrived = new(
        Values.Arrived
    );

    public static readonly RoutesStopWithFormsResponseObjectResponseBodyState Departed = new(
        Values.Departed
    );

    public RoutesStopWithFormsResponseObjectResponseBodyState(string value)
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
    public static RoutesStopWithFormsResponseObjectResponseBodyState FromCustom(string value)
    {
        return new RoutesStopWithFormsResponseObjectResponseBodyState(value);
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
        RoutesStopWithFormsResponseObjectResponseBodyState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RoutesStopWithFormsResponseObjectResponseBodyState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        RoutesStopWithFormsResponseObjectResponseBodyState value
    ) => value.Value;

    public static explicit operator RoutesStopWithFormsResponseObjectResponseBodyState(
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
