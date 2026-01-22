using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<WorkOrderObjectResponseBodyPriority>))]
[Serializable]
public readonly record struct WorkOrderObjectResponseBodyPriority : IStringEnum
{
    public static readonly WorkOrderObjectResponseBodyPriority High = new(Values.High);

    public static readonly WorkOrderObjectResponseBodyPriority Low = new(Values.Low);

    public static readonly WorkOrderObjectResponseBodyPriority Medium = new(Values.Medium);

    public static readonly WorkOrderObjectResponseBodyPriority Urgent = new(Values.Urgent);

    public WorkOrderObjectResponseBodyPriority(string value)
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
    public static WorkOrderObjectResponseBodyPriority FromCustom(string value)
    {
        return new WorkOrderObjectResponseBodyPriority(value);
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

    public static bool operator ==(WorkOrderObjectResponseBodyPriority value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WorkOrderObjectResponseBodyPriority value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WorkOrderObjectResponseBodyPriority value) =>
        value.Value;

    public static explicit operator WorkOrderObjectResponseBodyPriority(string value) => new(value);

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
