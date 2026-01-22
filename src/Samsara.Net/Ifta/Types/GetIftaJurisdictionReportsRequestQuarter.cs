using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Ifta;

[JsonConverter(typeof(StringEnumSerializer<GetIftaJurisdictionReportsRequestQuarter>))]
[Serializable]
public readonly record struct GetIftaJurisdictionReportsRequestQuarter : IStringEnum
{
    public static readonly GetIftaJurisdictionReportsRequestQuarter Q1 = new(Values.Q1);

    public static readonly GetIftaJurisdictionReportsRequestQuarter Q2 = new(Values.Q2);

    public static readonly GetIftaJurisdictionReportsRequestQuarter Q3 = new(Values.Q3);

    public static readonly GetIftaJurisdictionReportsRequestQuarter Q4 = new(Values.Q4);

    public GetIftaJurisdictionReportsRequestQuarter(string value)
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
    public static GetIftaJurisdictionReportsRequestQuarter FromCustom(string value)
    {
        return new GetIftaJurisdictionReportsRequestQuarter(value);
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
        GetIftaJurisdictionReportsRequestQuarter value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GetIftaJurisdictionReportsRequestQuarter value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GetIftaJurisdictionReportsRequestQuarter value) =>
        value.Value;

    public static explicit operator GetIftaJurisdictionReportsRequestQuarter(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Q1 = "Q1";

        public const string Q2 = "Q2";

        public const string Q3 = "Q3";

        public const string Q4 = "Q4";
    }
}
