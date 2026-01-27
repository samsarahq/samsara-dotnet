using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<TrainingAssignmentNearDueDateTriggerDetailsObjectResponseBodyConditionUnits>)
)]
[Serializable]
public readonly record struct TrainingAssignmentNearDueDateTriggerDetailsObjectResponseBodyConditionUnits
    : IStringEnum
{
    public static readonly TrainingAssignmentNearDueDateTriggerDetailsObjectResponseBodyConditionUnits Days =
        new(Values.Days);

    public static readonly TrainingAssignmentNearDueDateTriggerDetailsObjectResponseBodyConditionUnits Weeks =
        new(Values.Weeks);

    public TrainingAssignmentNearDueDateTriggerDetailsObjectResponseBodyConditionUnits(string value)
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
    public static TrainingAssignmentNearDueDateTriggerDetailsObjectResponseBodyConditionUnits FromCustom(
        string value
    )
    {
        return new TrainingAssignmentNearDueDateTriggerDetailsObjectResponseBodyConditionUnits(
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
        TrainingAssignmentNearDueDateTriggerDetailsObjectResponseBodyConditionUnits value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TrainingAssignmentNearDueDateTriggerDetailsObjectResponseBodyConditionUnits value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        TrainingAssignmentNearDueDateTriggerDetailsObjectResponseBodyConditionUnits value
    ) => value.Value;

    public static explicit operator TrainingAssignmentNearDueDateTriggerDetailsObjectResponseBodyConditionUnits(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Days = "DAYS";

        public const string Weeks = "WEEKS";
    }
}
