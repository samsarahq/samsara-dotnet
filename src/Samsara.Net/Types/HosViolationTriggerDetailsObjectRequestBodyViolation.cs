using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<HosViolationTriggerDetailsObjectRequestBodyViolation>))]
[Serializable]
public readonly record struct HosViolationTriggerDetailsObjectRequestBodyViolation : IStringEnum
{
    public static readonly HosViolationTriggerDetailsObjectRequestBodyViolation CaliforniaMealbreakMissed =
        new(Values.CaliforniaMealbreakMissed);

    public static readonly HosViolationTriggerDetailsObjectRequestBodyViolation CycleHoursOn = new(
        Values.CycleHoursOn
    );

    public static readonly HosViolationTriggerDetailsObjectRequestBodyViolation DailyDrivingHours =
        new(Values.DailyDrivingHours);

    public static readonly HosViolationTriggerDetailsObjectRequestBodyViolation DailyOnDutyHours =
        new(Values.DailyOnDutyHours);

    public static readonly HosViolationTriggerDetailsObjectRequestBodyViolation Invalid = new(
        Values.Invalid
    );

    public static readonly HosViolationTriggerDetailsObjectRequestBodyViolation RestbreakMissed =
        new(Values.RestbreakMissed);

    public static readonly HosViolationTriggerDetailsObjectRequestBodyViolation ShiftDrivingHours =
        new(Values.ShiftDrivingHours);

    public static readonly HosViolationTriggerDetailsObjectRequestBodyViolation ShiftHours = new(
        Values.ShiftHours
    );

    public static readonly HosViolationTriggerDetailsObjectRequestBodyViolation ShiftOnDutyHours =
        new(Values.ShiftOnDutyHours);

    public static readonly HosViolationTriggerDetailsObjectRequestBodyViolation UnsubmittedLogs =
        new(Values.UnsubmittedLogs);

    public HosViolationTriggerDetailsObjectRequestBodyViolation(string value)
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
    public static HosViolationTriggerDetailsObjectRequestBodyViolation FromCustom(string value)
    {
        return new HosViolationTriggerDetailsObjectRequestBodyViolation(value);
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
        HosViolationTriggerDetailsObjectRequestBodyViolation value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        HosViolationTriggerDetailsObjectRequestBodyViolation value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        HosViolationTriggerDetailsObjectRequestBodyViolation value
    ) => value.Value;

    public static explicit operator HosViolationTriggerDetailsObjectRequestBodyViolation(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string CaliforniaMealbreakMissed = "CaliforniaMealbreakMissed";

        public const string CycleHoursOn = "CycleHoursOn";

        public const string DailyDrivingHours = "DailyDrivingHours";

        public const string DailyOnDutyHours = "DailyOnDutyHours";

        public const string Invalid = "Invalid";

        public const string RestbreakMissed = "RestbreakMissed";

        public const string ShiftDrivingHours = "ShiftDrivingHours";

        public const string ShiftHours = "ShiftHours";

        public const string ShiftOnDutyHours = "ShiftOnDutyHours";

        public const string UnsubmittedLogs = "UnsubmittedLogs";
    }
}
