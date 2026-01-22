using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Ifta;

[JsonConverter(typeof(StringEnumSerializer<GetIftaVehicleReportsRequestMonth>))]
[Serializable]
public readonly record struct GetIftaVehicleReportsRequestMonth : IStringEnum
{
    public static readonly GetIftaVehicleReportsRequestMonth January = new(Values.January);

    public static readonly GetIftaVehicleReportsRequestMonth February = new(Values.February);

    public static readonly GetIftaVehicleReportsRequestMonth March = new(Values.March);

    public static readonly GetIftaVehicleReportsRequestMonth April = new(Values.April);

    public static readonly GetIftaVehicleReportsRequestMonth May = new(Values.May);

    public static readonly GetIftaVehicleReportsRequestMonth June = new(Values.June);

    public static readonly GetIftaVehicleReportsRequestMonth July = new(Values.July);

    public static readonly GetIftaVehicleReportsRequestMonth August = new(Values.August);

    public static readonly GetIftaVehicleReportsRequestMonth September = new(Values.September);

    public static readonly GetIftaVehicleReportsRequestMonth October = new(Values.October);

    public static readonly GetIftaVehicleReportsRequestMonth November = new(Values.November);

    public static readonly GetIftaVehicleReportsRequestMonth December = new(Values.December);

    public GetIftaVehicleReportsRequestMonth(string value)
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
    public static GetIftaVehicleReportsRequestMonth FromCustom(string value)
    {
        return new GetIftaVehicleReportsRequestMonth(value);
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

    public static bool operator ==(GetIftaVehicleReportsRequestMonth value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetIftaVehicleReportsRequestMonth value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetIftaVehicleReportsRequestMonth value) => value.Value;

    public static explicit operator GetIftaVehicleReportsRequestMonth(string value) => new(value);

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
