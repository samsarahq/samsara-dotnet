using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<PostFuelPurchaseRequestBodyPriceRequestBodyCurrency>))]
[Serializable]
public readonly record struct PostFuelPurchaseRequestBodyPriceRequestBodyCurrency : IStringEnum
{
    public static readonly PostFuelPurchaseRequestBodyPriceRequestBodyCurrency Usd = new(
        Values.Usd
    );

    public static readonly PostFuelPurchaseRequestBodyPriceRequestBodyCurrency Gbp = new(
        Values.Gbp
    );

    public static readonly PostFuelPurchaseRequestBodyPriceRequestBodyCurrency Cad = new(
        Values.Cad
    );

    public static readonly PostFuelPurchaseRequestBodyPriceRequestBodyCurrency Eur = new(
        Values.Eur
    );

    public static readonly PostFuelPurchaseRequestBodyPriceRequestBodyCurrency Chf = new(
        Values.Chf
    );

    public static readonly PostFuelPurchaseRequestBodyPriceRequestBodyCurrency Mxn = new(
        Values.Mxn
    );

    public PostFuelPurchaseRequestBodyPriceRequestBodyCurrency(string value)
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
    public static PostFuelPurchaseRequestBodyPriceRequestBodyCurrency FromCustom(string value)
    {
        return new PostFuelPurchaseRequestBodyPriceRequestBodyCurrency(value);
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
        PostFuelPurchaseRequestBodyPriceRequestBodyCurrency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostFuelPurchaseRequestBodyPriceRequestBodyCurrency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostFuelPurchaseRequestBodyPriceRequestBodyCurrency value
    ) => value.Value;

    public static explicit operator PostFuelPurchaseRequestBodyPriceRequestBodyCurrency(
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
