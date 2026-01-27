using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<PostFuelPurchaseRequestBodyDiscountRequestBodyCurrency>)
)]
[Serializable]
public readonly record struct PostFuelPurchaseRequestBodyDiscountRequestBodyCurrency : IStringEnum
{
    public static readonly PostFuelPurchaseRequestBodyDiscountRequestBodyCurrency Usd = new(
        Values.Usd
    );

    public static readonly PostFuelPurchaseRequestBodyDiscountRequestBodyCurrency Gbp = new(
        Values.Gbp
    );

    public static readonly PostFuelPurchaseRequestBodyDiscountRequestBodyCurrency Cad = new(
        Values.Cad
    );

    public static readonly PostFuelPurchaseRequestBodyDiscountRequestBodyCurrency Eur = new(
        Values.Eur
    );

    public static readonly PostFuelPurchaseRequestBodyDiscountRequestBodyCurrency Chf = new(
        Values.Chf
    );

    public static readonly PostFuelPurchaseRequestBodyDiscountRequestBodyCurrency Mxn = new(
        Values.Mxn
    );

    public PostFuelPurchaseRequestBodyDiscountRequestBodyCurrency(string value)
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
    public static PostFuelPurchaseRequestBodyDiscountRequestBodyCurrency FromCustom(string value)
    {
        return new PostFuelPurchaseRequestBodyDiscountRequestBodyCurrency(value);
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
        PostFuelPurchaseRequestBodyDiscountRequestBodyCurrency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostFuelPurchaseRequestBodyDiscountRequestBodyCurrency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostFuelPurchaseRequestBodyDiscountRequestBodyCurrency value
    ) => value.Value;

    public static explicit operator PostFuelPurchaseRequestBodyDiscountRequestBodyCurrency(
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
