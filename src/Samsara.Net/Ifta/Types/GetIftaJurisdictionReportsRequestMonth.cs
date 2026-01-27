using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Ifta;

[JsonConverter(typeof(StringEnumSerializer<GetIftaJurisdictionReportsRequestMonth>))]
[Serializable]
public readonly record struct GetIftaJurisdictionReportsRequestMonth : IStringEnum
{
    public static readonly GetIftaJurisdictionReportsRequestMonth January = new(Values.January);

    public static readonly GetIftaJurisdictionReportsRequestMonth February = new(Values.February);

    public static readonly GetIftaJurisdictionReportsRequestMonth March = new(Values.March);

    public static readonly GetIftaJurisdictionReportsRequestMonth April = new(Values.April);

    public static readonly GetIftaJurisdictionReportsRequestMonth May = new(Values.May);

    public static readonly GetIftaJurisdictionReportsRequestMonth June = new(Values.June);

    public static readonly GetIftaJurisdictionReportsRequestMonth July = new(Values.July);

    public static readonly GetIftaJurisdictionReportsRequestMonth August = new(Values.August);

    public static readonly GetIftaJurisdictionReportsRequestMonth September = new(Values.September);

    public static readonly GetIftaJurisdictionReportsRequestMonth October = new(Values.October);

    public static readonly GetIftaJurisdictionReportsRequestMonth November = new(Values.November);

    public static readonly GetIftaJurisdictionReportsRequestMonth December = new(Values.December);

    public GetIftaJurisdictionReportsRequestMonth(string value)
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
    public static GetIftaJurisdictionReportsRequestMonth FromCustom(string value)
    {
        return new GetIftaJurisdictionReportsRequestMonth(value);
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

    public static bool operator ==(GetIftaJurisdictionReportsRequestMonth value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetIftaJurisdictionReportsRequestMonth value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetIftaJurisdictionReportsRequestMonth value) =>
        value.Value;

    public static explicit operator GetIftaJurisdictionReportsRequestMonth(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string January = "January";

        public const string February = "February";

        public const string March = "March";

        public const string April = "April";

        public const string May = "May";

        public const string June = "June";

        public const string July = "July";

        public const string August = "August";

        public const string September = "September";

        public const string October = "October";

        public const string November = "November";

        public const string December = "December";
    }
}
