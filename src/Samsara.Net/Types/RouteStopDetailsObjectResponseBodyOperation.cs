using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<RouteStopDetailsObjectResponseBodyOperation>))]
[Serializable]
public readonly record struct RouteStopDetailsObjectResponseBodyOperation : IStringEnum
{
    public static readonly RouteStopDetailsObjectResponseBodyOperation StopArrived = new(
        Values.StopArrived
    );

    public static readonly RouteStopDetailsObjectResponseBodyOperation StopDeparted = new(
        Values.StopDeparted
    );

    public RouteStopDetailsObjectResponseBodyOperation(string value)
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
    public static RouteStopDetailsObjectResponseBodyOperation FromCustom(string value)
    {
        return new RouteStopDetailsObjectResponseBodyOperation(value);
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
        RouteStopDetailsObjectResponseBodyOperation value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RouteStopDetailsObjectResponseBodyOperation value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RouteStopDetailsObjectResponseBodyOperation value) =>
        value.Value;

    public static explicit operator RouteStopDetailsObjectResponseBodyOperation(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string StopArrived = "stop arrived";

        public const string StopDeparted = "stop departed";
    }
}
