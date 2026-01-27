using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<MinimalRouteStopAuditLogsResponseBodyState>))]
[Serializable]
public readonly record struct MinimalRouteStopAuditLogsResponseBodyState : IStringEnum
{
    public static readonly MinimalRouteStopAuditLogsResponseBodyState Unassigned = new(
        Values.Unassigned
    );

    public static readonly MinimalRouteStopAuditLogsResponseBodyState Scheduled = new(
        Values.Scheduled
    );

    public static readonly MinimalRouteStopAuditLogsResponseBodyState EnRoute = new(Values.EnRoute);

    public static readonly MinimalRouteStopAuditLogsResponseBodyState Skipped = new(Values.Skipped);

    public static readonly MinimalRouteStopAuditLogsResponseBodyState Arrived = new(Values.Arrived);

    public static readonly MinimalRouteStopAuditLogsResponseBodyState Departed = new(
        Values.Departed
    );

    public MinimalRouteStopAuditLogsResponseBodyState(string value)
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
    public static MinimalRouteStopAuditLogsResponseBodyState FromCustom(string value)
    {
        return new MinimalRouteStopAuditLogsResponseBodyState(value);
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
        MinimalRouteStopAuditLogsResponseBodyState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        MinimalRouteStopAuditLogsResponseBodyState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(MinimalRouteStopAuditLogsResponseBodyState value) =>
        value.Value;

    public static explicit operator MinimalRouteStopAuditLogsResponseBodyState(string value) =>
        new(value);

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
