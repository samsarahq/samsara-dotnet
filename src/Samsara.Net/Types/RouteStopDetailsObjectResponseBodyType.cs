using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<RouteStopDetailsObjectResponseBodyType>))]
[Serializable]
public readonly record struct RouteStopDetailsObjectResponseBodyType : IStringEnum
{
    public static readonly RouteStopDetailsObjectResponseBodyType RouteTracking = new(
        Values.RouteTracking
    );

    public RouteStopDetailsObjectResponseBodyType(string value)
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
    public static RouteStopDetailsObjectResponseBodyType FromCustom(string value)
    {
        return new RouteStopDetailsObjectResponseBodyType(value);
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

    public static bool operator ==(RouteStopDetailsObjectResponseBodyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RouteStopDetailsObjectResponseBodyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RouteStopDetailsObjectResponseBodyType value) =>
        value.Value;

    public static explicit operator RouteStopDetailsObjectResponseBodyType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string RouteTracking = "route tracking";
    }
}
