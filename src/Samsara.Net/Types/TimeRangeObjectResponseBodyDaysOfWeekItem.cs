using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<TimeRangeObjectResponseBodyDaysOfWeekItem>))]
[Serializable]
public readonly record struct TimeRangeObjectResponseBodyDaysOfWeekItem : IStringEnum
{
    public static readonly TimeRangeObjectResponseBodyDaysOfWeekItem Friday = new(Values.Friday);

    public static readonly TimeRangeObjectResponseBodyDaysOfWeekItem Monday = new(Values.Monday);

    public static readonly TimeRangeObjectResponseBodyDaysOfWeekItem Saturday = new(
        Values.Saturday
    );

    public static readonly TimeRangeObjectResponseBodyDaysOfWeekItem Sunday = new(Values.Sunday);

    public static readonly TimeRangeObjectResponseBodyDaysOfWeekItem Thursday = new(
        Values.Thursday
    );

    public static readonly TimeRangeObjectResponseBodyDaysOfWeekItem Tuesday = new(Values.Tuesday);

    public static readonly TimeRangeObjectResponseBodyDaysOfWeekItem Wednesday = new(
        Values.Wednesday
    );

    public TimeRangeObjectResponseBodyDaysOfWeekItem(string value)
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
    public static TimeRangeObjectResponseBodyDaysOfWeekItem FromCustom(string value)
    {
        return new TimeRangeObjectResponseBodyDaysOfWeekItem(value);
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
        TimeRangeObjectResponseBodyDaysOfWeekItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TimeRangeObjectResponseBodyDaysOfWeekItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(TimeRangeObjectResponseBodyDaysOfWeekItem value) =>
        value.Value;

    public static explicit operator TimeRangeObjectResponseBodyDaysOfWeekItem(string value) =>
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
