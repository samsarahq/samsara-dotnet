using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<RouteSettingsRequestBodyRouteCompletionCondition>))]
[Serializable]
public readonly record struct RouteSettingsRequestBodyRouteCompletionCondition : IStringEnum
{
    public static readonly RouteSettingsRequestBodyRouteCompletionCondition ArriveLastStop = new(
        Values.ArriveLastStop
    );

    public static readonly RouteSettingsRequestBodyRouteCompletionCondition DepartLastStop = new(
        Values.DepartLastStop
    );

    public RouteSettingsRequestBodyRouteCompletionCondition(string value)
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
    public static RouteSettingsRequestBodyRouteCompletionCondition FromCustom(string value)
    {
        return new RouteSettingsRequestBodyRouteCompletionCondition(value);
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
        RouteSettingsRequestBodyRouteCompletionCondition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RouteSettingsRequestBodyRouteCompletionCondition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        RouteSettingsRequestBodyRouteCompletionCondition value
    ) => value.Value;

    public static explicit operator RouteSettingsRequestBodyRouteCompletionCondition(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string ArriveLastStop = "arriveLastStop";

        public const string DepartLastStop = "departLastStop";
    }
}
