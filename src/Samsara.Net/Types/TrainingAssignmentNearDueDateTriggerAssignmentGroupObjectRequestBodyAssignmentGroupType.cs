using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectRequestBodyAssignmentGroupType>)
)]
[Serializable]
public readonly record struct TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectRequestBodyAssignmentGroupType
    : IStringEnum
{
    public static readonly TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectRequestBodyAssignmentGroupType Category =
        new(Values.Category);

    public static readonly TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectRequestBodyAssignmentGroupType Course =
        new(Values.Course);

    public TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectRequestBodyAssignmentGroupType(
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
    public static TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectRequestBodyAssignmentGroupType FromCustom(
        string value
    )
    {
        return new TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectRequestBodyAssignmentGroupType(
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
        TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectRequestBodyAssignmentGroupType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectRequestBodyAssignmentGroupType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectRequestBodyAssignmentGroupType value
    ) => value.Value;

    public static explicit operator TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectRequestBodyAssignmentGroupType(
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
