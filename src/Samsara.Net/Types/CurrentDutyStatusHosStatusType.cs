using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<CurrentDutyStatusHosStatusType>))]
[Serializable]
public readonly record struct CurrentDutyStatusHosStatusType : IStringEnum
{
    public static readonly CurrentDutyStatusHosStatusType OffDuty = new(Values.OffDuty);

    public static readonly CurrentDutyStatusHosStatusType SleeperBed = new(Values.SleeperBed);

    public static readonly CurrentDutyStatusHosStatusType Driving = new(Values.Driving);

    public static readonly CurrentDutyStatusHosStatusType OnDuty = new(Values.OnDuty);

    public static readonly CurrentDutyStatusHosStatusType YardMove = new(Values.YardMove);

    public static readonly CurrentDutyStatusHosStatusType PersonalConveyance = new(
        Values.PersonalConveyance
    );

    public CurrentDutyStatusHosStatusType(string value)
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
    public static CurrentDutyStatusHosStatusType FromCustom(string value)
    {
        return new CurrentDutyStatusHosStatusType(value);
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

    public static bool operator ==(CurrentDutyStatusHosStatusType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CurrentDutyStatusHosStatusType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CurrentDutyStatusHosStatusType value) => value.Value;

    public static explicit operator CurrentDutyStatusHosStatusType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string OffDuty = "offDuty";

        public const string SleeperBed = "sleeperBed";

        public const string Driving = "driving";

        public const string OnDuty = "onDuty";

        public const string YardMove = "yardMove";

        public const string PersonalConveyance = "personalConveyance";
    }
}
