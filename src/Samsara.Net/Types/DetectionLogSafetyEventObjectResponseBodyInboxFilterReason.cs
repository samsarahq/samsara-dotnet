using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<DetectionLogSafetyEventObjectResponseBodyInboxFilterReason>)
)]
[Serializable]
public readonly record struct DetectionLogSafetyEventObjectResponseBodyInboxFilterReason
    : IStringEnum
{
    public static readonly DetectionLogSafetyEventObjectResponseBodyInboxFilterReason OverDailyLimit =
        new(Values.OverDailyLimit);

    public static readonly DetectionLogSafetyEventObjectResponseBodyInboxFilterReason OverHourlyLimit =
        new(Values.OverHourlyLimit);

    public static readonly DetectionLogSafetyEventObjectResponseBodyInboxFilterReason OverTripLimit =
        new(Values.OverTripLimit);

    public static readonly DetectionLogSafetyEventObjectResponseBodyInboxFilterReason BelowConfidenceThreshold =
        new(Values.BelowConfidenceThreshold);

    public static readonly DetectionLogSafetyEventObjectResponseBodyInboxFilterReason BelowSeverityThreshold =
        new(Values.BelowSeverityThreshold);

    public static readonly DetectionLogSafetyEventObjectResponseBodyInboxFilterReason OverEventRateLimit =
        new(Values.OverEventRateLimit);

    public static readonly DetectionLogSafetyEventObjectResponseBodyInboxFilterReason GeofenceFilter =
        new(Values.GeofenceFilter);

    public static readonly DetectionLogSafetyEventObjectResponseBodyInboxFilterReason BelowNudgeThreshold =
        new(Values.BelowNudgeThreshold);

    public static readonly DetectionLogSafetyEventObjectResponseBodyInboxFilterReason BelowSpeedThreshold =
        new(Values.BelowSpeedThreshold);

    public static readonly DetectionLogSafetyEventObjectResponseBodyInboxFilterReason NighttimeFilter =
        new(Values.NighttimeFilter);

    public static readonly DetectionLogSafetyEventObjectResponseBodyInboxFilterReason SpeedingFilter =
        new(Values.SpeedingFilter);

    public static readonly DetectionLogSafetyEventObjectResponseBodyInboxFilterReason InCabAlertOnly =
        new(Values.InCabAlertOnly);

    public static readonly DetectionLogSafetyEventObjectResponseBodyInboxFilterReason Unknown = new(
        Values.Unknown
    );

    public DetectionLogSafetyEventObjectResponseBodyInboxFilterReason(string value)
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
    public static DetectionLogSafetyEventObjectResponseBodyInboxFilterReason FromCustom(
        string value
    )
    {
        return new DetectionLogSafetyEventObjectResponseBodyInboxFilterReason(value);
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
        DetectionLogSafetyEventObjectResponseBodyInboxFilterReason value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DetectionLogSafetyEventObjectResponseBodyInboxFilterReason value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DetectionLogSafetyEventObjectResponseBodyInboxFilterReason value
    ) => value.Value;

    public static explicit operator DetectionLogSafetyEventObjectResponseBodyInboxFilterReason(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string OverDailyLimit = "overDailyLimit";

        public const string OverHourlyLimit = "overHourlyLimit";

        public const string OverTripLimit = "overTripLimit";

        public const string BelowConfidenceThreshold = "belowConfidenceThreshold";

        public const string BelowSeverityThreshold = "belowSeverityThreshold";

        public const string OverEventRateLimit = "overEventRateLimit";

        public const string GeofenceFilter = "geofenceFilter";

        public const string BelowNudgeThreshold = "belowNudgeThreshold";

        public const string BelowSpeedThreshold = "belowSpeedThreshold";

        public const string NighttimeFilter = "nighttimeFilter";

        public const string SpeedingFilter = "speedingFilter";

        public const string InCabAlertOnly = "inCabAlertOnly";

        public const string Unknown = "unknown";
    }
}
