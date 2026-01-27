using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<GaseousFuelCostObjectResponseBodyCurrency>))]
[Serializable]
public readonly record struct GaseousFuelCostObjectResponseBodyCurrency : IStringEnum
{
    public static readonly GaseousFuelCostObjectResponseBodyCurrency Usd = new(Values.Usd);

    public static readonly GaseousFuelCostObjectResponseBodyCurrency Gbp = new(Values.Gbp);

    public static readonly GaseousFuelCostObjectResponseBodyCurrency Cad = new(Values.Cad);

    public static readonly GaseousFuelCostObjectResponseBodyCurrency Eur = new(Values.Eur);

    public static readonly GaseousFuelCostObjectResponseBodyCurrency Chf = new(Values.Chf);

    public static readonly GaseousFuelCostObjectResponseBodyCurrency Mxn = new(Values.Mxn);

    public GaseousFuelCostObjectResponseBodyCurrency(string value)
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
    public static GaseousFuelCostObjectResponseBodyCurrency FromCustom(string value)
    {
        return new GaseousFuelCostObjectResponseBodyCurrency(value);
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
        GaseousFuelCostObjectResponseBodyCurrency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GaseousFuelCostObjectResponseBodyCurrency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GaseousFuelCostObjectResponseBodyCurrency value) =>
        value.Value;

    public static explicit operator GaseousFuelCostObjectResponseBodyCurrency(string value) =>
        new(value);

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
