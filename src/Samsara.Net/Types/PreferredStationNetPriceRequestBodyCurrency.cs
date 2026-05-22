using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<PreferredStationNetPriceRequestBodyCurrency>))]
[Serializable]
public readonly record struct PreferredStationNetPriceRequestBodyCurrency : IStringEnum
{
    public static readonly PreferredStationNetPriceRequestBodyCurrency Usd = new(Values.Usd);

    public static readonly PreferredStationNetPriceRequestBodyCurrency Gbp = new(Values.Gbp);

    public static readonly PreferredStationNetPriceRequestBodyCurrency Cad = new(Values.Cad);

    public static readonly PreferredStationNetPriceRequestBodyCurrency Eur = new(Values.Eur);

    public static readonly PreferredStationNetPriceRequestBodyCurrency Chf = new(Values.Chf);

    public static readonly PreferredStationNetPriceRequestBodyCurrency Mxn = new(Values.Mxn);

    public PreferredStationNetPriceRequestBodyCurrency(string value)
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
    public static PreferredStationNetPriceRequestBodyCurrency FromCustom(string value)
    {
        return new PreferredStationNetPriceRequestBodyCurrency(value);
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
        PreferredStationNetPriceRequestBodyCurrency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PreferredStationNetPriceRequestBodyCurrency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PreferredStationNetPriceRequestBodyCurrency value) =>
        value.Value;

    public static explicit operator PreferredStationNetPriceRequestBodyCurrency(string value) =>
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
