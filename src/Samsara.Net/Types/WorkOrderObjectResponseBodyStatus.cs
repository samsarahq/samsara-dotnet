using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<WorkOrderObjectResponseBodyStatus>))]
[Serializable]
public readonly record struct WorkOrderObjectResponseBodyStatus : IStringEnum
{
    public static readonly WorkOrderObjectResponseBodyStatus Assigned = new(Values.Assigned);

    public static readonly WorkOrderObjectResponseBodyStatus Cancelled = new(Values.Cancelled);

    public static readonly WorkOrderObjectResponseBodyStatus Closed = new(Values.Closed);

    public static readonly WorkOrderObjectResponseBodyStatus Completed = new(Values.Completed);

    public static readonly WorkOrderObjectResponseBodyStatus InProgress = new(Values.InProgress);

    public static readonly WorkOrderObjectResponseBodyStatus OnHold = new(Values.OnHold);

    public static readonly WorkOrderObjectResponseBodyStatus Open = new(Values.Open);

    public static readonly WorkOrderObjectResponseBodyStatus PendingApproval = new(
        Values.PendingApproval
    );

    public static readonly WorkOrderObjectResponseBodyStatus PendingParts = new(
        Values.PendingParts
    );

    public WorkOrderObjectResponseBodyStatus(string value)
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
    public static WorkOrderObjectResponseBodyStatus FromCustom(string value)
    {
        return new WorkOrderObjectResponseBodyStatus(value);
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

    public static bool operator ==(WorkOrderObjectResponseBodyStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WorkOrderObjectResponseBodyStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WorkOrderObjectResponseBodyStatus value) => value.Value;

    public static explicit operator WorkOrderObjectResponseBodyStatus(string value) => new(value);

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
