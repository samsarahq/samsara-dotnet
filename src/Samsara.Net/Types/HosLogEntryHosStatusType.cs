using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<HosLogEntryHosStatusType>))]
[Serializable]
public readonly record struct HosLogEntryHosStatusType : IStringEnum
{
    public static readonly HosLogEntryHosStatusType OffDuty = new(Values.OffDuty);

    public static readonly HosLogEntryHosStatusType SleeperBed = new(Values.SleeperBed);

    public static readonly HosLogEntryHosStatusType Driving = new(Values.Driving);

    public static readonly HosLogEntryHosStatusType OnDuty = new(Values.OnDuty);

    public static readonly HosLogEntryHosStatusType YardMove = new(Values.YardMove);

    public static readonly HosLogEntryHosStatusType PersonalConveyance = new(
        Values.PersonalConveyance
    );

    public HosLogEntryHosStatusType(string value)
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
    public static HosLogEntryHosStatusType FromCustom(string value)
    {
        return new HosLogEntryHosStatusType(value);
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

    public static bool operator ==(HosLogEntryHosStatusType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(HosLogEntryHosStatusType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(HosLogEntryHosStatusType value) => value.Value;

    public static explicit operator HosLogEntryHosStatusType(string value) => new(value);

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
