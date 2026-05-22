using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<PreferredStationDiscountResponseMoneyResponseBodyCurrency>)
)]
[Serializable]
public readonly record struct PreferredStationDiscountResponseMoneyResponseBodyCurrency
    : IStringEnum
{
    public static readonly PreferredStationDiscountResponseMoneyResponseBodyCurrency Usd = new(
        Values.Usd
    );

    public static readonly PreferredStationDiscountResponseMoneyResponseBodyCurrency Gbp = new(
        Values.Gbp
    );

    public static readonly PreferredStationDiscountResponseMoneyResponseBodyCurrency Cad = new(
        Values.Cad
    );

    public static readonly PreferredStationDiscountResponseMoneyResponseBodyCurrency Eur = new(
        Values.Eur
    );

    public static readonly PreferredStationDiscountResponseMoneyResponseBodyCurrency Chf = new(
        Values.Chf
    );

    public static readonly PreferredStationDiscountResponseMoneyResponseBodyCurrency Mxn = new(
        Values.Mxn
    );

    public PreferredStationDiscountResponseMoneyResponseBodyCurrency(string value)
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
    public static PreferredStationDiscountResponseMoneyResponseBodyCurrency FromCustom(string value)
    {
        return new PreferredStationDiscountResponseMoneyResponseBodyCurrency(value);
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
        PreferredStationDiscountResponseMoneyResponseBodyCurrency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PreferredStationDiscountResponseMoneyResponseBodyCurrency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PreferredStationDiscountResponseMoneyResponseBodyCurrency value
    ) => value.Value;

    public static explicit operator PreferredStationDiscountResponseMoneyResponseBodyCurrency(
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
