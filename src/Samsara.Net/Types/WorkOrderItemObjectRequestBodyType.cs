using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<WorkOrderItemObjectRequestBodyType>))]
[Serializable]
public readonly record struct WorkOrderItemObjectRequestBodyType : IStringEnum
{
    public static readonly WorkOrderItemObjectRequestBodyType Dvir = new(Values.Dvir);

    public static readonly WorkOrderItemObjectRequestBodyType Fault = new(Values.Fault);

    public static readonly WorkOrderItemObjectRequestBodyType Form = new(Values.Form);

    public static readonly WorkOrderItemObjectRequestBodyType Issue = new(Values.Issue);

    public static readonly WorkOrderItemObjectRequestBodyType ItemTypeUnspecified = new(
        Values.ItemTypeUnspecified
    );

    public static readonly WorkOrderItemObjectRequestBodyType MaintenancePredictionEvent = new(
        Values.MaintenancePredictionEvent
    );

    public static readonly WorkOrderItemObjectRequestBodyType ScheduledMaintenance = new(
        Values.ScheduledMaintenance
    );

    public WorkOrderItemObjectRequestBodyType(string value)
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
    public static WorkOrderItemObjectRequestBodyType FromCustom(string value)
    {
        return new WorkOrderItemObjectRequestBodyType(value);
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

    public static bool operator ==(WorkOrderItemObjectRequestBodyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WorkOrderItemObjectRequestBodyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WorkOrderItemObjectRequestBodyType value) => value.Value;

    public static explicit operator WorkOrderItemObjectRequestBodyType(string value) => new(value);

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
