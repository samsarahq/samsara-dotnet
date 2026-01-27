using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<HosViolationTriggerDetailsObjectResponseBodyViolation>))]
[Serializable]
public readonly record struct HosViolationTriggerDetailsObjectResponseBodyViolation : IStringEnum
{
    public static readonly HosViolationTriggerDetailsObjectResponseBodyViolation CaliforniaMealbreakMissed =
        new(Values.CaliforniaMealbreakMissed);

    public static readonly HosViolationTriggerDetailsObjectResponseBodyViolation CycleHoursOn = new(
        Values.CycleHoursOn
    );

    public static readonly HosViolationTriggerDetailsObjectResponseBodyViolation DailyDrivingHours =
        new(Values.DailyDrivingHours);

    public static readonly HosViolationTriggerDetailsObjectResponseBodyViolation DailyOnDutyHours =
        new(Values.DailyOnDutyHours);

    public static readonly HosViolationTriggerDetailsObjectResponseBodyViolation Invalid = new(
        Values.Invalid
    );

    public static readonly HosViolationTriggerDetailsObjectResponseBodyViolation RestbreakMissed =
        new(Values.RestbreakMissed);

    public static readonly HosViolationTriggerDetailsObjectResponseBodyViolation ShiftDrivingHours =
        new(Values.ShiftDrivingHours);

    public static readonly HosViolationTriggerDetailsObjectResponseBodyViolation ShiftHours = new(
        Values.ShiftHours
    );

    public static readonly HosViolationTriggerDetailsObjectResponseBodyViolation ShiftOnDutyHours =
        new(Values.ShiftOnDutyHours);

    public static readonly HosViolationTriggerDetailsObjectResponseBodyViolation UnsubmittedLogs =
        new(Values.UnsubmittedLogs);

    public HosViolationTriggerDetailsObjectResponseBodyViolation(string value)
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
    public static HosViolationTriggerDetailsObjectResponseBodyViolation FromCustom(string value)
    {
        return new HosViolationTriggerDetailsObjectResponseBodyViolation(value);
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
        HosViolationTriggerDetailsObjectResponseBodyViolation value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        HosViolationTriggerDetailsObjectResponseBodyViolation value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        HosViolationTriggerDetailsObjectResponseBodyViolation value
    ) => value.Value;

    public static explicit operator HosViolationTriggerDetailsObjectResponseBodyViolation(
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
