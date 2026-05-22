using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<PreferredStationGrossPriceResponseResponseBodyCurrency>)
)]
[Serializable]
public readonly record struct PreferredStationGrossPriceResponseResponseBodyCurrency : IStringEnum
{
    public static readonly PreferredStationGrossPriceResponseResponseBodyCurrency Usd = new(
        Values.Usd
    );

    public static readonly PreferredStationGrossPriceResponseResponseBodyCurrency Gbp = new(
        Values.Gbp
    );

    public static readonly PreferredStationGrossPriceResponseResponseBodyCurrency Cad = new(
        Values.Cad
    );

    public static readonly PreferredStationGrossPriceResponseResponseBodyCurrency Eur = new(
        Values.Eur
    );

    public static readonly PreferredStationGrossPriceResponseResponseBodyCurrency Chf = new(
        Values.Chf
    );

    public static readonly PreferredStationGrossPriceResponseResponseBodyCurrency Mxn = new(
        Values.Mxn
    );

    public PreferredStationGrossPriceResponseResponseBodyCurrency(string value)
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
    public static PreferredStationGrossPriceResponseResponseBodyCurrency FromCustom(string value)
    {
        return new PreferredStationGrossPriceResponseResponseBodyCurrency(value);
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
        PreferredStationGrossPriceResponseResponseBodyCurrency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PreferredStationGrossPriceResponseResponseBodyCurrency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PreferredStationGrossPriceResponseResponseBodyCurrency value
    ) => value.Value;

    public static explicit operator PreferredStationGrossPriceResponseResponseBodyCurrency(
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
