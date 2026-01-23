using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Ifta;

[JsonConverter(typeof(StringEnumSerializer<GetIftaJurisdictionReportsRequestFuelType>))]
[Serializable]
public readonly record struct GetIftaJurisdictionReportsRequestFuelType : IStringEnum
{
    public static readonly GetIftaJurisdictionReportsRequestFuelType Unspecified = new(
        Values.Unspecified
    );

    public static readonly GetIftaJurisdictionReportsRequestFuelType A55 = new(Values.A55);

    public static readonly GetIftaJurisdictionReportsRequestFuelType Biodiesel = new(
        Values.Biodiesel
    );

    public static readonly GetIftaJurisdictionReportsRequestFuelType CompressedNaturalGas = new(
        Values.CompressedNaturalGas
    );

    public static readonly GetIftaJurisdictionReportsRequestFuelType Diesel = new(Values.Diesel);

    public static readonly GetIftaJurisdictionReportsRequestFuelType E85 = new(Values.E85);

    public static readonly GetIftaJurisdictionReportsRequestFuelType Electricity = new(
        Values.Electricity
    );

    public static readonly GetIftaJurisdictionReportsRequestFuelType Ethanol = new(Values.Ethanol);

    public static readonly GetIftaJurisdictionReportsRequestFuelType Gasohol = new(Values.Gasohol);

    public static readonly GetIftaJurisdictionReportsRequestFuelType Gasoline = new(
        Values.Gasoline
    );

    public static readonly GetIftaJurisdictionReportsRequestFuelType Hydrogen = new(
        Values.Hydrogen
    );

    public static readonly GetIftaJurisdictionReportsRequestFuelType LiquifiedNaturalGas = new(
        Values.LiquifiedNaturalGas
    );

    public static readonly GetIftaJurisdictionReportsRequestFuelType M85 = new(Values.M85);

    public static readonly GetIftaJurisdictionReportsRequestFuelType Methanol = new(
        Values.Methanol
    );

    public static readonly GetIftaJurisdictionReportsRequestFuelType Propane = new(Values.Propane);

    public static readonly GetIftaJurisdictionReportsRequestFuelType Other = new(Values.Other);

    public GetIftaJurisdictionReportsRequestFuelType(string value)
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
    public static GetIftaJurisdictionReportsRequestFuelType FromCustom(string value)
    {
        return new GetIftaJurisdictionReportsRequestFuelType(value);
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
        GetIftaJurisdictionReportsRequestFuelType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GetIftaJurisdictionReportsRequestFuelType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GetIftaJurisdictionReportsRequestFuelType value) =>
        value.Value;

    public static explicit operator GetIftaJurisdictionReportsRequestFuelType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unspecified = "Unspecified";

        public const string A55 = "A55";

        public const string Biodiesel = "Biodiesel";

        public const string CompressedNaturalGas = "CompressedNaturalGas";

        public const string Diesel = "Diesel";

        public const string E85 = "E85";

        public const string Electricity = "Electricity";

        public const string Ethanol = "Ethanol";

        public const string Gasohol = "Gasohol";

        public const string Gasoline = "Gasoline";

        public const string Hydrogen = "Hydrogen";

        public const string LiquifiedNaturalGas = "LiquifiedNaturalGas";

        public const string M85 = "M85";

        public const string Methanol = "Methanol";

        public const string Propane = "Propane";

        public const string Other = "Other";
    }
}
