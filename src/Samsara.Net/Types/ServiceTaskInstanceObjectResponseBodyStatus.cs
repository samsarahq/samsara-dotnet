using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<ServiceTaskInstanceObjectResponseBodyStatus>))]
[Serializable]
public readonly record struct ServiceTaskInstanceObjectResponseBodyStatus : IStringEnum
{
    public static readonly ServiceTaskInstanceObjectResponseBodyStatus Unknown = new(
        Values.Unknown
    );

    public static readonly ServiceTaskInstanceObjectResponseBodyStatus Open = new(Values.Open);

    public static readonly ServiceTaskInstanceObjectResponseBodyStatus InProgress = new(
        Values.InProgress
    );

    public static readonly ServiceTaskInstanceObjectResponseBodyStatus OnHold = new(Values.OnHold);

    public static readonly ServiceTaskInstanceObjectResponseBodyStatus Completed = new(
        Values.Completed
    );

    public ServiceTaskInstanceObjectResponseBodyStatus(string value)
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
    public static ServiceTaskInstanceObjectResponseBodyStatus FromCustom(string value)
    {
        return new ServiceTaskInstanceObjectResponseBodyStatus(value);
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
        ServiceTaskInstanceObjectResponseBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ServiceTaskInstanceObjectResponseBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ServiceTaskInstanceObjectResponseBodyStatus value) =>
        value.Value;

    public static explicit operator ServiceTaskInstanceObjectResponseBodyStatus(string value) =>
        new(value);

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
