using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<ServiceTaskInstanceWithTimeEntriesObjectResponseBodyStatus>)
)]
[Serializable]
public readonly record struct ServiceTaskInstanceWithTimeEntriesObjectResponseBodyStatus
    : IStringEnum
{
    public static readonly ServiceTaskInstanceWithTimeEntriesObjectResponseBodyStatus Unknown = new(
        Values.Unknown
    );

    public static readonly ServiceTaskInstanceWithTimeEntriesObjectResponseBodyStatus Open = new(
        Values.Open
    );

    public static readonly ServiceTaskInstanceWithTimeEntriesObjectResponseBodyStatus InProgress =
        new(Values.InProgress);

    public static readonly ServiceTaskInstanceWithTimeEntriesObjectResponseBodyStatus OnHold = new(
        Values.OnHold
    );

    public static readonly ServiceTaskInstanceWithTimeEntriesObjectResponseBodyStatus Completed =
        new(Values.Completed);

    public ServiceTaskInstanceWithTimeEntriesObjectResponseBodyStatus(string value)
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
    public static ServiceTaskInstanceWithTimeEntriesObjectResponseBodyStatus FromCustom(
        string value
    )
    {
        return new ServiceTaskInstanceWithTimeEntriesObjectResponseBodyStatus(value);
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
        ServiceTaskInstanceWithTimeEntriesObjectResponseBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ServiceTaskInstanceWithTimeEntriesObjectResponseBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ServiceTaskInstanceWithTimeEntriesObjectResponseBodyStatus value
    ) => value.Value;

    public static explicit operator ServiceTaskInstanceWithTimeEntriesObjectResponseBodyStatus(
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
