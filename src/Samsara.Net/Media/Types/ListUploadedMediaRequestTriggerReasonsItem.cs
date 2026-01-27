using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Media;

[JsonConverter(typeof(StringEnumSerializer<ListUploadedMediaRequestTriggerReasonsItem>))]
[Serializable]
public readonly record struct ListUploadedMediaRequestTriggerReasonsItem : IStringEnum
{
    public static readonly ListUploadedMediaRequestTriggerReasonsItem Api = new(Values.Api);

    public static readonly ListUploadedMediaRequestTriggerReasonsItem PanicButton = new(
        Values.PanicButton
    );

    public static readonly ListUploadedMediaRequestTriggerReasonsItem PeriodicStill = new(
        Values.PeriodicStill
    );

    public static readonly ListUploadedMediaRequestTriggerReasonsItem RfidEvent = new(
        Values.RfidEvent
    );

    public static readonly ListUploadedMediaRequestTriggerReasonsItem SafetyEvent = new(
        Values.SafetyEvent
    );

    public static readonly ListUploadedMediaRequestTriggerReasonsItem TripEndStill = new(
        Values.TripEndStill
    );

    public static readonly ListUploadedMediaRequestTriggerReasonsItem TripStartStill = new(
        Values.TripStartStill
    );

    public static readonly ListUploadedMediaRequestTriggerReasonsItem VideoRetrieval = new(
        Values.VideoRetrieval
    );

    public ListUploadedMediaRequestTriggerReasonsItem(string value)
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
    public static ListUploadedMediaRequestTriggerReasonsItem FromCustom(string value)
    {
        return new ListUploadedMediaRequestTriggerReasonsItem(value);
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
        ListUploadedMediaRequestTriggerReasonsItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListUploadedMediaRequestTriggerReasonsItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListUploadedMediaRequestTriggerReasonsItem value) =>
        value.Value;

    public static explicit operator ListUploadedMediaRequestTriggerReasonsItem(string value) =>
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
