using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<ServiceTaskInstanceWithTimeEntriesObjectV20261112ResponseBodyStatus>)
)]
[Serializable]
public readonly record struct ServiceTaskInstanceWithTimeEntriesObjectV20261112ResponseBodyStatus
    : IStringEnum
{
    public static readonly ServiceTaskInstanceWithTimeEntriesObjectV20261112ResponseBodyStatus Unknown =
        new(Values.Unknown);

    public static readonly ServiceTaskInstanceWithTimeEntriesObjectV20261112ResponseBodyStatus Open =
        new(Values.Open);

    public static readonly ServiceTaskInstanceWithTimeEntriesObjectV20261112ResponseBodyStatus InProgress =
        new(Values.InProgress);

    public static readonly ServiceTaskInstanceWithTimeEntriesObjectV20261112ResponseBodyStatus OnHold =
        new(Values.OnHold);

    public static readonly ServiceTaskInstanceWithTimeEntriesObjectV20261112ResponseBodyStatus Completed =
        new(Values.Completed);

    public ServiceTaskInstanceWithTimeEntriesObjectV20261112ResponseBodyStatus(string value)
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
    public static ServiceTaskInstanceWithTimeEntriesObjectV20261112ResponseBodyStatus FromCustom(
        string value
    )
    {
        return new ServiceTaskInstanceWithTimeEntriesObjectV20261112ResponseBodyStatus(value);
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
        ServiceTaskInstanceWithTimeEntriesObjectV20261112ResponseBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ServiceTaskInstanceWithTimeEntriesObjectV20261112ResponseBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ServiceTaskInstanceWithTimeEntriesObjectV20261112ResponseBodyStatus value
    ) => value.Value;

    public static explicit operator ServiceTaskInstanceWithTimeEntriesObjectV20261112ResponseBodyStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "Unknown";

        public const string Open = "Open";

        public const string InProgress = "In Progress";

        public const string OnHold = "On Hold";

        public const string Completed = "Completed";
    }
}
