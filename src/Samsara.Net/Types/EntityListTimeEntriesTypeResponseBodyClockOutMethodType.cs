using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<EntityListTimeEntriesTypeResponseBodyClockOutMethodType>)
)]
[Serializable]
public readonly record struct EntityListTimeEntriesTypeResponseBodyClockOutMethodType : IStringEnum
{
    public static readonly EntityListTimeEntriesTypeResponseBodyClockOutMethodType Unknown = new(
        Values.Unknown
    );

    public static readonly EntityListTimeEntriesTypeResponseBodyClockOutMethodType Manual = new(
        Values.Manual
    );

    public static readonly EntityListTimeEntriesTypeResponseBodyClockOutMethodType Overwrite = new(
        Values.Overwrite
    );

    public static readonly EntityListTimeEntriesTypeResponseBodyClockOutMethodType ClockIn = new(
        Values.ClockIn
    );

    public static readonly EntityListTimeEntriesTypeResponseBodyClockOutMethodType AutoClockOut =
        new(Values.AutoClockOut);

    public EntityListTimeEntriesTypeResponseBodyClockOutMethodType(string value)
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
    public static EntityListTimeEntriesTypeResponseBodyClockOutMethodType FromCustom(string value)
    {
        return new EntityListTimeEntriesTypeResponseBodyClockOutMethodType(value);
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
        EntityListTimeEntriesTypeResponseBodyClockOutMethodType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityListTimeEntriesTypeResponseBodyClockOutMethodType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityListTimeEntriesTypeResponseBodyClockOutMethodType value
    ) => value.Value;

    public static explicit operator EntityListTimeEntriesTypeResponseBodyClockOutMethodType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string Manual = "manual";

        public const string Overwrite = "overwrite";

        public const string ClockIn = "clockIn";

        public const string AutoClockOut = "autoClockOut";
    }
}
