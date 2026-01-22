using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<MinimalRouteStopResponseBodyState>))]
[Serializable]
public readonly record struct MinimalRouteStopResponseBodyState : IStringEnum
{
    public static readonly MinimalRouteStopResponseBodyState Unassigned = new(Values.Unassigned);

    public static readonly MinimalRouteStopResponseBodyState Scheduled = new(Values.Scheduled);

    public static readonly MinimalRouteStopResponseBodyState EnRoute = new(Values.EnRoute);

    public static readonly MinimalRouteStopResponseBodyState Skipped = new(Values.Skipped);

    public static readonly MinimalRouteStopResponseBodyState Arrived = new(Values.Arrived);

    public static readonly MinimalRouteStopResponseBodyState Departed = new(Values.Departed);

    public MinimalRouteStopResponseBodyState(string value)
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
    public static MinimalRouteStopResponseBodyState FromCustom(string value)
    {
        return new MinimalRouteStopResponseBodyState(value);
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

    public static bool operator ==(MinimalRouteStopResponseBodyState value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MinimalRouteStopResponseBodyState value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MinimalRouteStopResponseBodyState value) => value.Value;

    public static explicit operator MinimalRouteStopResponseBodyState(string value) => new(value);

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
