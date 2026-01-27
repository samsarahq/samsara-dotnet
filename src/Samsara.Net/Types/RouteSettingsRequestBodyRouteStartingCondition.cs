using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<RouteSettingsRequestBodyRouteStartingCondition>))]
[Serializable]
public readonly record struct RouteSettingsRequestBodyRouteStartingCondition : IStringEnum
{
    public static readonly RouteSettingsRequestBodyRouteStartingCondition DepartFirstStop = new(
        Values.DepartFirstStop
    );

    public static readonly RouteSettingsRequestBodyRouteStartingCondition ArriveFirstStop = new(
        Values.ArriveFirstStop
    );

    public RouteSettingsRequestBodyRouteStartingCondition(string value)
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
    public static RouteSettingsRequestBodyRouteStartingCondition FromCustom(string value)
    {
        return new RouteSettingsRequestBodyRouteStartingCondition(value);
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
        RouteSettingsRequestBodyRouteStartingCondition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RouteSettingsRequestBodyRouteStartingCondition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RouteSettingsRequestBodyRouteStartingCondition value) =>
        value.Value;

    public static explicit operator RouteSettingsRequestBodyRouteStartingCondition(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string DepartFirstStop = "departFirstStop";

        public const string ArriveFirstStop = "arriveFirstStop";
    }
}
