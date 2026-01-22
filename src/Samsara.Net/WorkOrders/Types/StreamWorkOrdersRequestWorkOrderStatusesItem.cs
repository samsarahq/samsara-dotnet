using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.WorkOrders;

[JsonConverter(typeof(StringEnumSerializer<StreamWorkOrdersRequestWorkOrderStatusesItem>))]
[Serializable]
public readonly record struct StreamWorkOrdersRequestWorkOrderStatusesItem : IStringEnum
{
    public static readonly StreamWorkOrdersRequestWorkOrderStatusesItem Assigned = new(
        Values.Assigned
    );

    public static readonly StreamWorkOrdersRequestWorkOrderStatusesItem Cancelled = new(
        Values.Cancelled
    );

    public static readonly StreamWorkOrdersRequestWorkOrderStatusesItem Closed = new(Values.Closed);

    public static readonly StreamWorkOrdersRequestWorkOrderStatusesItem Completed = new(
        Values.Completed
    );

    public static readonly StreamWorkOrdersRequestWorkOrderStatusesItem InProgress = new(
        Values.InProgress
    );

    public static readonly StreamWorkOrdersRequestWorkOrderStatusesItem OnHold = new(Values.OnHold);

    public static readonly StreamWorkOrdersRequestWorkOrderStatusesItem Open = new(Values.Open);

    public static readonly StreamWorkOrdersRequestWorkOrderStatusesItem PendingApproval = new(
        Values.PendingApproval
    );

    public static readonly StreamWorkOrdersRequestWorkOrderStatusesItem PendingParts = new(
        Values.PendingParts
    );

    public StreamWorkOrdersRequestWorkOrderStatusesItem(string value)
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
    public static StreamWorkOrdersRequestWorkOrderStatusesItem FromCustom(string value)
    {
        return new StreamWorkOrdersRequestWorkOrderStatusesItem(value);
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
        StreamWorkOrdersRequestWorkOrderStatusesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        StreamWorkOrdersRequestWorkOrderStatusesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(StreamWorkOrdersRequestWorkOrderStatusesItem value) =>
        value.Value;

    public static explicit operator StreamWorkOrdersRequestWorkOrderStatusesItem(string value) =>
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
