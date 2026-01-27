using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.WorkOrders;

[JsonConverter(typeof(StringEnumSerializer<WorkOrdersPatchWorkOrdersRequestBodyStatus>))]
[Serializable]
public readonly record struct WorkOrdersPatchWorkOrdersRequestBodyStatus : IStringEnum
{
    public static readonly WorkOrdersPatchWorkOrdersRequestBodyStatus Assigned = new(
        Values.Assigned
    );

    public static readonly WorkOrdersPatchWorkOrdersRequestBodyStatus Cancelled = new(
        Values.Cancelled
    );

    public static readonly WorkOrdersPatchWorkOrdersRequestBodyStatus Closed = new(Values.Closed);

    public static readonly WorkOrdersPatchWorkOrdersRequestBodyStatus Completed = new(
        Values.Completed
    );

    public static readonly WorkOrdersPatchWorkOrdersRequestBodyStatus InProgress = new(
        Values.InProgress
    );

    public static readonly WorkOrdersPatchWorkOrdersRequestBodyStatus OnHold = new(Values.OnHold);

    public static readonly WorkOrdersPatchWorkOrdersRequestBodyStatus Open = new(Values.Open);

    public static readonly WorkOrdersPatchWorkOrdersRequestBodyStatus PendingApproval = new(
        Values.PendingApproval
    );

    public static readonly WorkOrdersPatchWorkOrdersRequestBodyStatus PendingParts = new(
        Values.PendingParts
    );

    public WorkOrdersPatchWorkOrdersRequestBodyStatus(string value)
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
    public static WorkOrdersPatchWorkOrdersRequestBodyStatus FromCustom(string value)
    {
        return new WorkOrdersPatchWorkOrdersRequestBodyStatus(value);
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
        WorkOrdersPatchWorkOrdersRequestBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        WorkOrdersPatchWorkOrdersRequestBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(WorkOrdersPatchWorkOrdersRequestBodyStatus value) =>
        value.Value;

    public static explicit operator WorkOrdersPatchWorkOrdersRequestBodyStatus(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Assigned = "Assigned";

        public const string Cancelled = "Cancelled";

        public const string Closed = "Closed";

        public const string Completed = "Completed";

        public const string InProgress = "In Progress";

        public const string OnHold = "On Hold";

        public const string Open = "Open";

        public const string PendingApproval = "Pending Approval";

        public const string PendingParts = "Pending Parts";
    }
}
