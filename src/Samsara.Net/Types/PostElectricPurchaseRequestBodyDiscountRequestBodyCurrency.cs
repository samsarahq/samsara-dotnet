using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<PostElectricPurchaseRequestBodyDiscountRequestBodyCurrency>)
)]
[Serializable]
public readonly record struct PostElectricPurchaseRequestBodyDiscountRequestBodyCurrency
    : IStringEnum
{
    public static readonly PostElectricPurchaseRequestBodyDiscountRequestBodyCurrency Usd = new(
        Values.Usd
    );

    public static readonly PostElectricPurchaseRequestBodyDiscountRequestBodyCurrency Gbp = new(
        Values.Gbp
    );

    public static readonly PostElectricPurchaseRequestBodyDiscountRequestBodyCurrency Cad = new(
        Values.Cad
    );

    public static readonly PostElectricPurchaseRequestBodyDiscountRequestBodyCurrency Eur = new(
        Values.Eur
    );

    public static readonly PostElectricPurchaseRequestBodyDiscountRequestBodyCurrency Chf = new(
        Values.Chf
    );

    public static readonly PostElectricPurchaseRequestBodyDiscountRequestBodyCurrency Mxn = new(
        Values.Mxn
    );

    public PostElectricPurchaseRequestBodyDiscountRequestBodyCurrency(string value)
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
    public static PostElectricPurchaseRequestBodyDiscountRequestBodyCurrency FromCustom(
        string value
    )
    {
        return new PostElectricPurchaseRequestBodyDiscountRequestBodyCurrency(value);
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
        PostElectricPurchaseRequestBodyDiscountRequestBodyCurrency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostElectricPurchaseRequestBodyDiscountRequestBodyCurrency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostElectricPurchaseRequestBodyDiscountRequestBodyCurrency value
    ) => value.Value;

    public static explicit operator PostElectricPurchaseRequestBodyDiscountRequestBodyCurrency(
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
