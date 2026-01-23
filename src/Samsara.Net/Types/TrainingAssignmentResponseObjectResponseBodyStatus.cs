using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<TrainingAssignmentResponseObjectResponseBodyStatus>))]
[Serializable]
public readonly record struct TrainingAssignmentResponseObjectResponseBodyStatus : IStringEnum
{
    public static readonly TrainingAssignmentResponseObjectResponseBodyStatus NotStarted = new(
        Values.NotStarted
    );

    public static readonly TrainingAssignmentResponseObjectResponseBodyStatus InProgress = new(
        Values.InProgress
    );

    public static readonly TrainingAssignmentResponseObjectResponseBodyStatus Completed = new(
        Values.Completed
    );

    public TrainingAssignmentResponseObjectResponseBodyStatus(string value)
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
    public static TrainingAssignmentResponseObjectResponseBodyStatus FromCustom(string value)
    {
        return new TrainingAssignmentResponseObjectResponseBodyStatus(value);
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
        TrainingAssignmentResponseObjectResponseBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TrainingAssignmentResponseObjectResponseBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        TrainingAssignmentResponseObjectResponseBodyStatus value
    ) => value.Value;

    public static explicit operator TrainingAssignmentResponseObjectResponseBodyStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string NotStarted = "notStarted";

        public const string InProgress = "inProgress";

        public const string Completed = "completed";
    }
}
