using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<RouteFeedObjectResponseBodyOperation>))]
[Serializable]
public readonly record struct RouteFeedObjectResponseBodyOperation : IStringEnum
{
    public static readonly RouteFeedObjectResponseBodyOperation StopScheduled = new(
        Values.StopScheduled
    );

    public static readonly RouteFeedObjectResponseBodyOperation StopEnRoute = new(
        Values.StopEnRoute
    );

    public static readonly RouteFeedObjectResponseBodyOperation StopSkipped = new(
        Values.StopSkipped
    );

    public static readonly RouteFeedObjectResponseBodyOperation StopArrived = new(
        Values.StopArrived
    );

    public static readonly RouteFeedObjectResponseBodyOperation StopDeparted = new(
        Values.StopDeparted
    );

    public static readonly RouteFeedObjectResponseBodyOperation StopEtaUpdated = new(
        Values.StopEtaUpdated
    );

    public static readonly RouteFeedObjectResponseBodyOperation StopArrivalTimeUpdated = new(
        Values.StopArrivalTimeUpdated
    );

    public static readonly RouteFeedObjectResponseBodyOperation StopCompletionTimeUpdated = new(
        Values.StopCompletionTimeUpdated
    );

    public static readonly RouteFeedObjectResponseBodyOperation StopOrderChanged = new(
        Values.StopOrderChanged
    );

    public static readonly RouteFeedObjectResponseBodyOperation StopArrivalPrevented = new(
        Values.StopArrivalPrevented
    );

    public RouteFeedObjectResponseBodyOperation(string value)
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
    public static RouteFeedObjectResponseBodyOperation FromCustom(string value)
    {
        return new RouteFeedObjectResponseBodyOperation(value);
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

    public static bool operator ==(RouteFeedObjectResponseBodyOperation value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RouteFeedObjectResponseBodyOperation value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RouteFeedObjectResponseBodyOperation value) =>
        value.Value;

    public static explicit operator RouteFeedObjectResponseBodyOperation(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string StopScheduled = "stop scheduled";

        public const string StopEnRoute = "stop en route";

        public const string StopSkipped = "stop skipped";

        public const string StopArrived = "stop arrived";

        public const string StopDeparted = "stop departed";

        public const string StopEtaUpdated = "stop ETA updated";

        public const string StopArrivalTimeUpdated = "stop arrival time updated";

        public const string StopCompletionTimeUpdated = "stop completion time updated";

        public const string StopOrderChanged = "stop order changed";

        public const string StopArrivalPrevented = "stop arrival prevented";
    }
}
