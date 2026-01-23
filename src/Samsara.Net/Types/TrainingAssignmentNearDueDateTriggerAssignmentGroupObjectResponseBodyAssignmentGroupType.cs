using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectResponseBodyAssignmentGroupType>)
)]
[Serializable]
public readonly record struct TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectResponseBodyAssignmentGroupType
    : IStringEnum
{
    public static readonly TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectResponseBodyAssignmentGroupType Category =
        new(Values.Category);

    public static readonly TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectResponseBodyAssignmentGroupType Course =
        new(Values.Course);

    public TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectResponseBodyAssignmentGroupType(
        string value
    )
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
    public static TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectResponseBodyAssignmentGroupType FromCustom(
        string value
    )
    {
        return new TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectResponseBodyAssignmentGroupType(
            value
        );
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
        TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectResponseBodyAssignmentGroupType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectResponseBodyAssignmentGroupType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectResponseBodyAssignmentGroupType value
    ) => value.Value;

    public static explicit operator TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectResponseBodyAssignmentGroupType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Category = "CATEGORY";

        public const string Course = "COURSE";
    }
}
