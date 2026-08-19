using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.WorkOrders;

[JsonConverter(typeof(StringEnumSerializer<WorkOrdersPostWorkOrdersRequestBodyStatus>))]
[Serializable]
public readonly record struct WorkOrdersPostWorkOrdersRequestBodyStatus : IStringEnum
{
    public static readonly WorkOrdersPostWorkOrdersRequestBodyStatus Assigned = new(
        Values.Assigned
    );

    public static readonly WorkOrdersPostWorkOrdersRequestBodyStatus Cancelled = new(
        Values.Cancelled
    );

    public static readonly WorkOrdersPostWorkOrdersRequestBodyStatus Closed = new(Values.Closed);

    public static readonly WorkOrdersPostWorkOrdersRequestBodyStatus Completed = new(
        Values.Completed
    );

    public static readonly WorkOrdersPostWorkOrdersRequestBodyStatus Estimate = new(
        Values.Estimate
    );

    public static readonly WorkOrdersPostWorkOrdersRequestBodyStatus InProgress = new(
        Values.InProgress
    );

    public static readonly WorkOrdersPostWorkOrdersRequestBodyStatus OnHold = new(Values.OnHold);

    public static readonly WorkOrdersPostWorkOrdersRequestBodyStatus Open = new(Values.Open);

    public static readonly WorkOrdersPostWorkOrdersRequestBodyStatus PendingApproval = new(
        Values.PendingApproval
    );

    public static readonly WorkOrdersPostWorkOrdersRequestBodyStatus PendingParts = new(
        Values.PendingParts
    );

    public static readonly WorkOrdersPostWorkOrdersRequestBodyStatus Planning = new(
        Values.Planning
    );

    public WorkOrdersPostWorkOrdersRequestBodyStatus(string value)
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
    public static WorkOrdersPostWorkOrdersRequestBodyStatus FromCustom(string value)
    {
        return new WorkOrdersPostWorkOrdersRequestBodyStatus(value);
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
        WorkOrdersPostWorkOrdersRequestBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        WorkOrdersPostWorkOrdersRequestBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(WorkOrdersPostWorkOrdersRequestBodyStatus value) =>
        value.Value;

    public static explicit operator WorkOrdersPostWorkOrdersRequestBodyStatus(string value) =>
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

        public const string Estimate = "Estimate";

        public const string InProgress = "In Progress";

        public const string OnHold = "On Hold";

        public const string Open = "Open";

        public const string PendingApproval = "Pending Approval";

        public const string PendingParts = "Pending Parts";

        public const string Planning = "Planning";
    }
}
