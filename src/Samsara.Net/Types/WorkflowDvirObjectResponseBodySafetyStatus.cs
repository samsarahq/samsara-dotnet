using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<WorkflowDvirObjectResponseBodySafetyStatus>))]
[Serializable]
public readonly record struct WorkflowDvirObjectResponseBodySafetyStatus : IStringEnum
{
    public static readonly WorkflowDvirObjectResponseBodySafetyStatus Safe = new(Values.Safe);

    public static readonly WorkflowDvirObjectResponseBodySafetyStatus Unsafe = new(Values.Unsafe);

    public static readonly WorkflowDvirObjectResponseBodySafetyStatus Resolved = new(
        Values.Resolved
    );

    public WorkflowDvirObjectResponseBodySafetyStatus(string value)
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
    public static WorkflowDvirObjectResponseBodySafetyStatus FromCustom(string value)
    {
        return new WorkflowDvirObjectResponseBodySafetyStatus(value);
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
        WorkflowDvirObjectResponseBodySafetyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        WorkflowDvirObjectResponseBodySafetyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(WorkflowDvirObjectResponseBodySafetyStatus value) =>
        value.Value;

    public static explicit operator WorkflowDvirObjectResponseBodySafetyStatus(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Safe = "safe";

        public const string Unsafe = "unsafe";

        public const string Resolved = "resolved";
    }
}
