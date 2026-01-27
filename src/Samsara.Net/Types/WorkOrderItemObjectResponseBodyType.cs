using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<WorkOrderItemObjectResponseBodyType>))]
[Serializable]
public readonly record struct WorkOrderItemObjectResponseBodyType : IStringEnum
{
    public static readonly WorkOrderItemObjectResponseBodyType Dvir = new(Values.Dvir);

    public static readonly WorkOrderItemObjectResponseBodyType Fault = new(Values.Fault);

    public static readonly WorkOrderItemObjectResponseBodyType Form = new(Values.Form);

    public static readonly WorkOrderItemObjectResponseBodyType Issue = new(Values.Issue);

    public static readonly WorkOrderItemObjectResponseBodyType ItemTypeUnspecified = new(
        Values.ItemTypeUnspecified
    );

    public static readonly WorkOrderItemObjectResponseBodyType MaintenancePredictionEvent = new(
        Values.MaintenancePredictionEvent
    );

    public static readonly WorkOrderItemObjectResponseBodyType ScheduledMaintenance = new(
        Values.ScheduledMaintenance
    );

    public WorkOrderItemObjectResponseBodyType(string value)
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
    public static WorkOrderItemObjectResponseBodyType FromCustom(string value)
    {
        return new WorkOrderItemObjectResponseBodyType(value);
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

    public static bool operator ==(WorkOrderItemObjectResponseBodyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WorkOrderItemObjectResponseBodyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WorkOrderItemObjectResponseBodyType value) =>
        value.Value;

    public static explicit operator WorkOrderItemObjectResponseBodyType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Dvir = "DVIR";

        public const string Fault = "FAULT";

        public const string Form = "FORM";

        public const string Issue = "ISSUE";

        public const string ItemTypeUnspecified = "ITEM_TYPE_UNSPECIFIED";

        public const string MaintenancePredictionEvent = "MAINTENANCE_PREDICTION_EVENT";

        public const string ScheduledMaintenance = "SCHEDULED_MAINTENANCE";
    }
}
