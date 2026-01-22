using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<RouteSettingsResponseBodySequencingMethod>))]
[Serializable]
public readonly record struct RouteSettingsResponseBodySequencingMethod : IStringEnum
{
    public static readonly RouteSettingsResponseBodySequencingMethod Unknown = new(Values.Unknown);

    public static readonly RouteSettingsResponseBodySequencingMethod ScheduledArrivalTime = new(
        Values.ScheduledArrivalTime
    );

    public static readonly RouteSettingsResponseBodySequencingMethod Manual = new(Values.Manual);

    public RouteSettingsResponseBodySequencingMethod(string value)
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
    public static RouteSettingsResponseBodySequencingMethod FromCustom(string value)
    {
        return new RouteSettingsResponseBodySequencingMethod(value);
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
        RouteSettingsResponseBodySequencingMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RouteSettingsResponseBodySequencingMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RouteSettingsResponseBodySequencingMethod value) =>
        value.Value;

    public static explicit operator RouteSettingsResponseBodySequencingMethod(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string ScheduledArrivalTime = "scheduledArrivalTime";

        public const string Manual = "manual";
    }
}
