using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<TimeRangeObjectRequestBodyDaysOfWeekItem>))]
[Serializable]
public readonly record struct TimeRangeObjectRequestBodyDaysOfWeekItem : IStringEnum
{
    public static readonly TimeRangeObjectRequestBodyDaysOfWeekItem Friday = new(Values.Friday);

    public static readonly TimeRangeObjectRequestBodyDaysOfWeekItem Monday = new(Values.Monday);

    public static readonly TimeRangeObjectRequestBodyDaysOfWeekItem Saturday = new(Values.Saturday);

    public static readonly TimeRangeObjectRequestBodyDaysOfWeekItem Sunday = new(Values.Sunday);

    public static readonly TimeRangeObjectRequestBodyDaysOfWeekItem Thursday = new(Values.Thursday);

    public static readonly TimeRangeObjectRequestBodyDaysOfWeekItem Tuesday = new(Values.Tuesday);

    public static readonly TimeRangeObjectRequestBodyDaysOfWeekItem Wednesday = new(
        Values.Wednesday
    );

    public TimeRangeObjectRequestBodyDaysOfWeekItem(string value)
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
    public static TimeRangeObjectRequestBodyDaysOfWeekItem FromCustom(string value)
    {
        return new TimeRangeObjectRequestBodyDaysOfWeekItem(value);
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
        TimeRangeObjectRequestBodyDaysOfWeekItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TimeRangeObjectRequestBodyDaysOfWeekItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(TimeRangeObjectRequestBodyDaysOfWeekItem value) =>
        value.Value;

    public static explicit operator TimeRangeObjectRequestBodyDaysOfWeekItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Friday = "FRIDAY";

        public const string Monday = "MONDAY";

        public const string Saturday = "SATURDAY";

        public const string Sunday = "SUNDAY";

        public const string Thursday = "THURSDAY";

        public const string Tuesday = "TUESDAY";

        public const string Wednesday = "WEDNESDAY";
    }
}
