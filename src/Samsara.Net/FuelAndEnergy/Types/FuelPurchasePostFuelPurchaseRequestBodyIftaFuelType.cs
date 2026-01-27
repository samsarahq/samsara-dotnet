using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.FuelAndEnergy;

[JsonConverter(typeof(StringEnumSerializer<FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType>))]
[Serializable]
public readonly record struct FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType : IStringEnum
{
    public static readonly FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType Unspecified = new(
        Values.Unspecified
    );

    public static readonly FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType A55 = new(
        Values.A55
    );

    public static readonly FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType Biodiesel = new(
        Values.Biodiesel
    );

    public static readonly FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType CompressedNaturalGas =
        new(Values.CompressedNaturalGas);

    public static readonly FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType Diesel = new(
        Values.Diesel
    );

    public static readonly FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType E85 = new(
        Values.E85
    );

    public static readonly FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType Electricity = new(
        Values.Electricity
    );

    public static readonly FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType Ethanol = new(
        Values.Ethanol
    );

    public static readonly FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType Gasohol = new(
        Values.Gasohol
    );

    public static readonly FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType Gasoline = new(
        Values.Gasoline
    );

    public static readonly FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType Hydrogen = new(
        Values.Hydrogen
    );

    public static readonly FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType LiquifiedNaturalGas =
        new(Values.LiquifiedNaturalGas);

    public static readonly FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType M85 = new(
        Values.M85
    );

    public static readonly FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType Methanol = new(
        Values.Methanol
    );

    public static readonly FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType Propane = new(
        Values.Propane
    );

    public static readonly FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType Other = new(
        Values.Other
    );

    public FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType(string value)
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
    public static FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType FromCustom(string value)
    {
        return new FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType(value);
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
        FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType value
    ) => value.Value;

    public static explicit operator FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType(
        string value
    ) => new(value);

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
