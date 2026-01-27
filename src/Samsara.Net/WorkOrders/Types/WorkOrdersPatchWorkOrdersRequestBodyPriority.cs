using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.WorkOrders;

[JsonConverter(typeof(StringEnumSerializer<WorkOrdersPatchWorkOrdersRequestBodyPriority>))]
[Serializable]
public readonly record struct WorkOrdersPatchWorkOrdersRequestBodyPriority : IStringEnum
{
    public static readonly WorkOrdersPatchWorkOrdersRequestBodyPriority High = new(Values.High);

    public static readonly WorkOrdersPatchWorkOrdersRequestBodyPriority Low = new(Values.Low);

    public static readonly WorkOrdersPatchWorkOrdersRequestBodyPriority Medium = new(Values.Medium);

    public static readonly WorkOrdersPatchWorkOrdersRequestBodyPriority Urgent = new(Values.Urgent);

    public WorkOrdersPatchWorkOrdersRequestBodyPriority(string value)
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
    public static WorkOrdersPatchWorkOrdersRequestBodyPriority FromCustom(string value)
    {
        return new WorkOrdersPatchWorkOrdersRequestBodyPriority(value);
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
        WorkOrdersPatchWorkOrdersRequestBodyPriority value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        WorkOrdersPatchWorkOrdersRequestBodyPriority value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(WorkOrdersPatchWorkOrdersRequestBodyPriority value) =>
        value.Value;

    public static explicit operator WorkOrdersPatchWorkOrdersRequestBodyPriority(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string High = "High";

        public const string Low = "Low";

        public const string Medium = "Medium";

        public const string Urgent = "Urgent";
    }
}
