using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<WorkOrderWithTimeEntriesObjectV20261112ResponseBodyPriority>)
)]
[Serializable]
public readonly record struct WorkOrderWithTimeEntriesObjectV20261112ResponseBodyPriority
    : IStringEnum
{
    public static readonly WorkOrderWithTimeEntriesObjectV20261112ResponseBodyPriority High = new(
        Values.High
    );

    public static readonly WorkOrderWithTimeEntriesObjectV20261112ResponseBodyPriority Low = new(
        Values.Low
    );

    public static readonly WorkOrderWithTimeEntriesObjectV20261112ResponseBodyPriority Medium = new(
        Values.Medium
    );

    public static readonly WorkOrderWithTimeEntriesObjectV20261112ResponseBodyPriority Urgent = new(
        Values.Urgent
    );

    public WorkOrderWithTimeEntriesObjectV20261112ResponseBodyPriority(string value)
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
    public static WorkOrderWithTimeEntriesObjectV20261112ResponseBodyPriority FromCustom(
        string value
    )
    {
        return new WorkOrderWithTimeEntriesObjectV20261112ResponseBodyPriority(value);
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
        WorkOrderWithTimeEntriesObjectV20261112ResponseBodyPriority value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        WorkOrderWithTimeEntriesObjectV20261112ResponseBodyPriority value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        WorkOrderWithTimeEntriesObjectV20261112ResponseBodyPriority value
    ) => value.Value;

    public static explicit operator WorkOrderWithTimeEntriesObjectV20261112ResponseBodyPriority(
        string value
    ) => new(value);

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
