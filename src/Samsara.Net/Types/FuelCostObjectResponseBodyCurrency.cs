using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FuelCostObjectResponseBodyCurrency>))]
[Serializable]
public readonly record struct FuelCostObjectResponseBodyCurrency : IStringEnum
{
    public static readonly FuelCostObjectResponseBodyCurrency Usd = new(Values.Usd);

    public static readonly FuelCostObjectResponseBodyCurrency Gbp = new(Values.Gbp);

    public static readonly FuelCostObjectResponseBodyCurrency Cad = new(Values.Cad);

    public static readonly FuelCostObjectResponseBodyCurrency Eur = new(Values.Eur);

    public static readonly FuelCostObjectResponseBodyCurrency Chf = new(Values.Chf);

    public static readonly FuelCostObjectResponseBodyCurrency Mxn = new(Values.Mxn);

    public FuelCostObjectResponseBodyCurrency(string value)
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
    public static FuelCostObjectResponseBodyCurrency FromCustom(string value)
    {
        return new FuelCostObjectResponseBodyCurrency(value);
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

    public static bool operator ==(FuelCostObjectResponseBodyCurrency value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FuelCostObjectResponseBodyCurrency value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FuelCostObjectResponseBodyCurrency value) => value.Value;

    public static explicit operator FuelCostObjectResponseBodyCurrency(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Usd = "usd";

        public const string Gbp = "gbp";

        public const string Cad = "cad";

        public const string Eur = "eur";

        public const string Chf = "chf";

        public const string Mxn = "mxn";
    }
}
