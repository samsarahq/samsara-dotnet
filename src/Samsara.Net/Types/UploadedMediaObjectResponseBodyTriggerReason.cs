using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<UploadedMediaObjectResponseBodyTriggerReason>))]
[Serializable]
public readonly record struct UploadedMediaObjectResponseBodyTriggerReason : IStringEnum
{
    public static readonly UploadedMediaObjectResponseBodyTriggerReason Api = new(Values.Api);

    public static readonly UploadedMediaObjectResponseBodyTriggerReason PanicButton = new(
        Values.PanicButton
    );

    public static readonly UploadedMediaObjectResponseBodyTriggerReason PeriodicStill = new(
        Values.PeriodicStill
    );

    public static readonly UploadedMediaObjectResponseBodyTriggerReason RfidEvent = new(
        Values.RfidEvent
    );

    public static readonly UploadedMediaObjectResponseBodyTriggerReason SafetyEvent = new(
        Values.SafetyEvent
    );

    public static readonly UploadedMediaObjectResponseBodyTriggerReason TripEndStill = new(
        Values.TripEndStill
    );

    public static readonly UploadedMediaObjectResponseBodyTriggerReason TripStartStill = new(
        Values.TripStartStill
    );

    public static readonly UploadedMediaObjectResponseBodyTriggerReason VideoRetrieval = new(
        Values.VideoRetrieval
    );

    public UploadedMediaObjectResponseBodyTriggerReason(string value)
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
    public static UploadedMediaObjectResponseBodyTriggerReason FromCustom(string value)
    {
        return new UploadedMediaObjectResponseBodyTriggerReason(value);
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
        UploadedMediaObjectResponseBodyTriggerReason value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UploadedMediaObjectResponseBodyTriggerReason value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(UploadedMediaObjectResponseBodyTriggerReason value) =>
        value.Value;

    public static explicit operator UploadedMediaObjectResponseBodyTriggerReason(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Api = "api";

        public const string PanicButton = "panicButton";

        public const string PeriodicStill = "periodicStill";

        public const string RfidEvent = "rfidEvent";

        public const string SafetyEvent = "safetyEvent";

        public const string TripEndStill = "tripEndStill";

        public const string TripStartStill = "tripStartStill";

        public const string VideoRetrieval = "videoRetrieval";
    }
}
