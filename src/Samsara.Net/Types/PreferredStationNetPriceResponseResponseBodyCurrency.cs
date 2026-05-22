using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<PreferredStationNetPriceResponseResponseBodyCurrency>))]
[Serializable]
public readonly record struct PreferredStationNetPriceResponseResponseBodyCurrency : IStringEnum
{
    public static readonly PreferredStationNetPriceResponseResponseBodyCurrency Usd = new(
        Values.Usd
    );

    public static readonly PreferredStationNetPriceResponseResponseBodyCurrency Gbp = new(
        Values.Gbp
    );

    public static readonly PreferredStationNetPriceResponseResponseBodyCurrency Cad = new(
        Values.Cad
    );

    public static readonly PreferredStationNetPriceResponseResponseBodyCurrency Eur = new(
        Values.Eur
    );

    public static readonly PreferredStationNetPriceResponseResponseBodyCurrency Chf = new(
        Values.Chf
    );

    public static readonly PreferredStationNetPriceResponseResponseBodyCurrency Mxn = new(
        Values.Mxn
    );

    public PreferredStationNetPriceResponseResponseBodyCurrency(string value)
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
    public static PreferredStationNetPriceResponseResponseBodyCurrency FromCustom(string value)
    {
        return new PreferredStationNetPriceResponseResponseBodyCurrency(value);
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
        PreferredStationNetPriceResponseResponseBodyCurrency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PreferredStationNetPriceResponseResponseBodyCurrency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PreferredStationNetPriceResponseResponseBodyCurrency value
    ) => value.Value;

    public static explicit operator PreferredStationNetPriceResponseResponseBodyCurrency(
        string value
    ) => new(value);

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
