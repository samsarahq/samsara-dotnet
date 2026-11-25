using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<PostElectricPurchaseRequestBodyPriceRequestBodyCurrency>)
)]
[Serializable]
public readonly record struct PostElectricPurchaseRequestBodyPriceRequestBodyCurrency : IStringEnum
{
    public static readonly PostElectricPurchaseRequestBodyPriceRequestBodyCurrency Usd = new(
        Values.Usd
    );

    public static readonly PostElectricPurchaseRequestBodyPriceRequestBodyCurrency Gbp = new(
        Values.Gbp
    );

    public static readonly PostElectricPurchaseRequestBodyPriceRequestBodyCurrency Cad = new(
        Values.Cad
    );

    public static readonly PostElectricPurchaseRequestBodyPriceRequestBodyCurrency Eur = new(
        Values.Eur
    );

    public static readonly PostElectricPurchaseRequestBodyPriceRequestBodyCurrency Chf = new(
        Values.Chf
    );

    public static readonly PostElectricPurchaseRequestBodyPriceRequestBodyCurrency Mxn = new(
        Values.Mxn
    );

    public PostElectricPurchaseRequestBodyPriceRequestBodyCurrency(string value)
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
    public static PostElectricPurchaseRequestBodyPriceRequestBodyCurrency FromCustom(string value)
    {
        return new PostElectricPurchaseRequestBodyPriceRequestBodyCurrency(value);
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
        PostElectricPurchaseRequestBodyPriceRequestBodyCurrency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostElectricPurchaseRequestBodyPriceRequestBodyCurrency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostElectricPurchaseRequestBodyPriceRequestBodyCurrency value
    ) => value.Value;

    public static explicit operator PostElectricPurchaseRequestBodyPriceRequestBodyCurrency(
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
