using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<WorkflowAuthorSignatureObjectResponseBodyType>))]
[Serializable]
public readonly record struct WorkflowAuthorSignatureObjectResponseBodyType : IStringEnum
{
    public static readonly WorkflowAuthorSignatureObjectResponseBodyType Driver = new(
        Values.Driver
    );

    public static readonly WorkflowAuthorSignatureObjectResponseBodyType Mechanic = new(
        Values.Mechanic
    );

    public WorkflowAuthorSignatureObjectResponseBodyType(string value)
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
    public static WorkflowAuthorSignatureObjectResponseBodyType FromCustom(string value)
    {
        return new WorkflowAuthorSignatureObjectResponseBodyType(value);
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
        WorkflowAuthorSignatureObjectResponseBodyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        WorkflowAuthorSignatureObjectResponseBodyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(WorkflowAuthorSignatureObjectResponseBodyType value) =>
        value.Value;

    public static explicit operator WorkflowAuthorSignatureObjectResponseBodyType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Driver = "driver";

        public const string Mechanic = "mechanic";
    }
}
