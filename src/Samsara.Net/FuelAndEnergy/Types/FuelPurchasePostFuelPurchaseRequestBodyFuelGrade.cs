using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.FuelAndEnergy;

[JsonConverter(typeof(StringEnumSerializer<FuelPurchasePostFuelPurchaseRequestBodyFuelGrade>))]
[Serializable]
public readonly record struct FuelPurchasePostFuelPurchaseRequestBodyFuelGrade : IStringEnum
{
    public static readonly FuelPurchasePostFuelPurchaseRequestBodyFuelGrade Unknown = new(
        Values.Unknown
    );

    public static readonly FuelPurchasePostFuelPurchaseRequestBodyFuelGrade Regular = new(
        Values.Regular
    );

    public static readonly FuelPurchasePostFuelPurchaseRequestBodyFuelGrade Premium = new(
        Values.Premium
    );

    public FuelPurchasePostFuelPurchaseRequestBodyFuelGrade(string value)
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
    public static FuelPurchasePostFuelPurchaseRequestBodyFuelGrade FromCustom(string value)
    {
        return new FuelPurchasePostFuelPurchaseRequestBodyFuelGrade(value);
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
        FuelPurchasePostFuelPurchaseRequestBodyFuelGrade value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FuelPurchasePostFuelPurchaseRequestBodyFuelGrade value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FuelPurchasePostFuelPurchaseRequestBodyFuelGrade value
    ) => value.Value;

    public static explicit operator FuelPurchasePostFuelPurchaseRequestBodyFuelGrade(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "Unknown";

        public const string Regular = "Regular";

        public const string Premium = "Premium";
    }
}
