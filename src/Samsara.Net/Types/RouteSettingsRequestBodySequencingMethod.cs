using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<RouteSettingsRequestBodySequencingMethod>))]
[Serializable]
public readonly record struct RouteSettingsRequestBodySequencingMethod : IStringEnum
{
    public static readonly RouteSettingsRequestBodySequencingMethod Unknown = new(Values.Unknown);

    public static readonly RouteSettingsRequestBodySequencingMethod ScheduledArrivalTime = new(
        Values.ScheduledArrivalTime
    );

    public static readonly RouteSettingsRequestBodySequencingMethod Manual = new(Values.Manual);

    public RouteSettingsRequestBodySequencingMethod(string value)
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
    public static RouteSettingsRequestBodySequencingMethod FromCustom(string value)
    {
        return new RouteSettingsRequestBodySequencingMethod(value);
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
        RouteSettingsRequestBodySequencingMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RouteSettingsRequestBodySequencingMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RouteSettingsRequestBodySequencingMethod value) =>
        value.Value;

    public static explicit operator RouteSettingsRequestBodySequencingMethod(string value) =>
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
