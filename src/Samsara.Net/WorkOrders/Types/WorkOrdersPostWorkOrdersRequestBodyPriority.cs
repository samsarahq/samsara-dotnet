using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.WorkOrders;

[JsonConverter(typeof(StringEnumSerializer<WorkOrdersPostWorkOrdersRequestBodyPriority>))]
[Serializable]
public readonly record struct WorkOrdersPostWorkOrdersRequestBodyPriority : IStringEnum
{
    public static readonly WorkOrdersPostWorkOrdersRequestBodyPriority High = new(Values.High);

    public static readonly WorkOrdersPostWorkOrdersRequestBodyPriority Low = new(Values.Low);

    public static readonly WorkOrdersPostWorkOrdersRequestBodyPriority Medium = new(Values.Medium);

    public static readonly WorkOrdersPostWorkOrdersRequestBodyPriority Urgent = new(Values.Urgent);

    public WorkOrdersPostWorkOrdersRequestBodyPriority(string value)
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
    public static WorkOrdersPostWorkOrdersRequestBodyPriority FromCustom(string value)
    {
        return new WorkOrdersPostWorkOrdersRequestBodyPriority(value);
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
        WorkOrdersPostWorkOrdersRequestBodyPriority value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        WorkOrdersPostWorkOrdersRequestBodyPriority value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(WorkOrdersPostWorkOrdersRequestBodyPriority value) =>
        value.Value;

    public static explicit operator WorkOrdersPostWorkOrdersRequestBodyPriority(string value) =>
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
