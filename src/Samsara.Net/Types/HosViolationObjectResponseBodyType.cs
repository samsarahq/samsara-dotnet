using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<HosViolationObjectResponseBodyType>))]
[Serializable]
public readonly record struct HosViolationObjectResponseBodyType : IStringEnum
{
    public static readonly HosViolationObjectResponseBodyType None = new(Values.None);

    public static readonly HosViolationObjectResponseBodyType CaliforniaMealbreakMissed = new(
        Values.CaliforniaMealbreakMissed
    );

    public static readonly HosViolationObjectResponseBodyType CycleHoursOn = new(
        Values.CycleHoursOn
    );

    public static readonly HosViolationObjectResponseBodyType CycleOffHoursAfterOnDutyHours = new(
        Values.CycleOffHoursAfterOnDutyHours
    );

    public static readonly HosViolationObjectResponseBodyType DailyDrivingHours = new(
        Values.DailyDrivingHours
    );

    public static readonly HosViolationObjectResponseBodyType DailyOffDutyDeferralAddToDay2Consecutive =
        new(Values.DailyOffDutyDeferralAddToDay2Consecutive);

    public static readonly HosViolationObjectResponseBodyType DailyOffDutyDeferralNotPartMandatory =
        new(Values.DailyOffDutyDeferralNotPartMandatory);

    public static readonly HosViolationObjectResponseBodyType DailyOffDutyDeferralTwoDayDrivingLimit =
        new(Values.DailyOffDutyDeferralTwoDayDrivingLimit);

    public static readonly HosViolationObjectResponseBodyType DailyOffDutyDeferralTwoDayOffDuty =
        new(Values.DailyOffDutyDeferralTwoDayOffDuty);

    public static readonly HosViolationObjectResponseBodyType DailyOffDutyNonResetHours = new(
        Values.DailyOffDutyNonResetHours
    );

    public static readonly HosViolationObjectResponseBodyType DailyOffDutyTotalHours = new(
        Values.DailyOffDutyTotalHours
    );

    public static readonly HosViolationObjectResponseBodyType DailyOnDutyHours = new(
        Values.DailyOnDutyHours
    );

    public static readonly HosViolationObjectResponseBodyType Mandatory24HoursOffDuty = new(
        Values.Mandatory24HoursOffDuty
    );

    public static readonly HosViolationObjectResponseBodyType RestbreakMissed = new(
        Values.RestbreakMissed
    );

    public static readonly HosViolationObjectResponseBodyType ShiftDrivingHours = new(
        Values.ShiftDrivingHours
    );

    public static readonly HosViolationObjectResponseBodyType ShiftHours = new(Values.ShiftHours);

    public static readonly HosViolationObjectResponseBodyType ShiftOnDutyHours = new(
        Values.ShiftOnDutyHours
    );

    public static readonly HosViolationObjectResponseBodyType UnsubmittedLogs = new(
        Values.UnsubmittedLogs
    );

    public HosViolationObjectResponseBodyType(string value)
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
    public static HosViolationObjectResponseBodyType FromCustom(string value)
    {
        return new HosViolationObjectResponseBodyType(value);
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

    public static bool operator ==(HosViolationObjectResponseBodyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(HosViolationObjectResponseBodyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(HosViolationObjectResponseBodyType value) => value.Value;

    public static explicit operator HosViolationObjectResponseBodyType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string None = "NONE";

        public const string CaliforniaMealbreakMissed = "californiaMealbreakMissed";

        public const string CycleHoursOn = "cycleHoursOn";

        public const string CycleOffHoursAfterOnDutyHours = "cycleOffHoursAfterOnDutyHours";

        public const string DailyDrivingHours = "dailyDrivingHours";

        public const string DailyOffDutyDeferralAddToDay2Consecutive =
            "dailyOffDutyDeferralAddToDay2Consecutive";

        public const string DailyOffDutyDeferralNotPartMandatory =
            "dailyOffDutyDeferralNotPartMandatory";

        public const string DailyOffDutyDeferralTwoDayDrivingLimit =
            "dailyOffDutyDeferralTwoDayDrivingLimit";

        public const string DailyOffDutyDeferralTwoDayOffDuty = "dailyOffDutyDeferralTwoDayOffDuty";

        public const string DailyOffDutyNonResetHours = "dailyOffDutyNonResetHours";

        public const string DailyOffDutyTotalHours = "dailyOffDutyTotalHours";

        public const string DailyOnDutyHours = "dailyOnDutyHours";

        public const string Mandatory24HoursOffDuty = "mandatory24HoursOffDuty";

        public const string RestbreakMissed = "restbreakMissed";

        public const string ShiftDrivingHours = "shiftDrivingHours";

        public const string ShiftHours = "shiftHours";

        public const string ShiftOnDutyHours = "shiftOnDutyHours";

        public const string UnsubmittedLogs = "unsubmittedLogs";
    }
}
