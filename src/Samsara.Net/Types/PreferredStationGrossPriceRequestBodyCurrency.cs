using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<PreferredStationGrossPriceRequestBodyCurrency>))]
[Serializable]
public readonly record struct PreferredStationGrossPriceRequestBodyCurrency : IStringEnum
{
    public static readonly PreferredStationGrossPriceRequestBodyCurrency Usd = new(Values.Usd);

    public static readonly PreferredStationGrossPriceRequestBodyCurrency Gbp = new(Values.Gbp);

    public static readonly PreferredStationGrossPriceRequestBodyCurrency Cad = new(Values.Cad);

    public static readonly PreferredStationGrossPriceRequestBodyCurrency Eur = new(Values.Eur);

    public static readonly PreferredStationGrossPriceRequestBodyCurrency Chf = new(Values.Chf);

    public static readonly PreferredStationGrossPriceRequestBodyCurrency Mxn = new(Values.Mxn);

    public PreferredStationGrossPriceRequestBodyCurrency(string value)
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
    public static PreferredStationGrossPriceRequestBodyCurrency FromCustom(string value)
    {
        return new PreferredStationGrossPriceRequestBodyCurrency(value);
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
        PreferredStationGrossPriceRequestBodyCurrency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PreferredStationGrossPriceRequestBodyCurrency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PreferredStationGrossPriceRequestBodyCurrency value) =>
        value.Value;

    public static explicit operator PreferredStationGrossPriceRequestBodyCurrency(string value) =>
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
