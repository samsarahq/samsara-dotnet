using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<PostElectricPurchaseResponseBodyDiscountResponseBodyCurrency>)
)]
[Serializable]
public readonly record struct PostElectricPurchaseResponseBodyDiscountResponseBodyCurrency
    : IStringEnum
{
    public static readonly PostElectricPurchaseResponseBodyDiscountResponseBodyCurrency Usd = new(
        Values.Usd
    );

    public static readonly PostElectricPurchaseResponseBodyDiscountResponseBodyCurrency Gbp = new(
        Values.Gbp
    );

    public static readonly PostElectricPurchaseResponseBodyDiscountResponseBodyCurrency Cad = new(
        Values.Cad
    );

    public static readonly PostElectricPurchaseResponseBodyDiscountResponseBodyCurrency Eur = new(
        Values.Eur
    );

    public static readonly PostElectricPurchaseResponseBodyDiscountResponseBodyCurrency Chf = new(
        Values.Chf
    );

    public static readonly PostElectricPurchaseResponseBodyDiscountResponseBodyCurrency Mxn = new(
        Values.Mxn
    );

    public PostElectricPurchaseResponseBodyDiscountResponseBodyCurrency(string value)
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
    public static PostElectricPurchaseResponseBodyDiscountResponseBodyCurrency FromCustom(
        string value
    )
    {
        return new PostElectricPurchaseResponseBodyDiscountResponseBodyCurrency(value);
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
        PostElectricPurchaseResponseBodyDiscountResponseBodyCurrency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostElectricPurchaseResponseBodyDiscountResponseBodyCurrency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostElectricPurchaseResponseBodyDiscountResponseBodyCurrency value
    ) => value.Value;

    public static explicit operator PostElectricPurchaseResponseBodyDiscountResponseBodyCurrency(
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
