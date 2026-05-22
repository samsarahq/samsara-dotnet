using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<PreferredStationDiscountMoneyRequestBodyCurrency>))]
[Serializable]
public readonly record struct PreferredStationDiscountMoneyRequestBodyCurrency : IStringEnum
{
    public static readonly PreferredStationDiscountMoneyRequestBodyCurrency Usd = new(Values.Usd);

    public static readonly PreferredStationDiscountMoneyRequestBodyCurrency Gbp = new(Values.Gbp);

    public static readonly PreferredStationDiscountMoneyRequestBodyCurrency Cad = new(Values.Cad);

    public static readonly PreferredStationDiscountMoneyRequestBodyCurrency Eur = new(Values.Eur);

    public static readonly PreferredStationDiscountMoneyRequestBodyCurrency Chf = new(Values.Chf);

    public static readonly PreferredStationDiscountMoneyRequestBodyCurrency Mxn = new(Values.Mxn);

    public PreferredStationDiscountMoneyRequestBodyCurrency(string value)
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
    public static PreferredStationDiscountMoneyRequestBodyCurrency FromCustom(string value)
    {
        return new PreferredStationDiscountMoneyRequestBodyCurrency(value);
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
        PreferredStationDiscountMoneyRequestBodyCurrency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PreferredStationDiscountMoneyRequestBodyCurrency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PreferredStationDiscountMoneyRequestBodyCurrency value
    ) => value.Value;

    public static explicit operator PreferredStationDiscountMoneyRequestBodyCurrency(
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
