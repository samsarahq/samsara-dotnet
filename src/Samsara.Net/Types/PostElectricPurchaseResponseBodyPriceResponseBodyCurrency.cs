using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<PostElectricPurchaseResponseBodyPriceResponseBodyCurrency>)
)]
[Serializable]
public readonly record struct PostElectricPurchaseResponseBodyPriceResponseBodyCurrency
    : IStringEnum
{
    public static readonly PostElectricPurchaseResponseBodyPriceResponseBodyCurrency Usd = new(
        Values.Usd
    );

    public static readonly PostElectricPurchaseResponseBodyPriceResponseBodyCurrency Gbp = new(
        Values.Gbp
    );

    public static readonly PostElectricPurchaseResponseBodyPriceResponseBodyCurrency Cad = new(
        Values.Cad
    );

    public static readonly PostElectricPurchaseResponseBodyPriceResponseBodyCurrency Eur = new(
        Values.Eur
    );

    public static readonly PostElectricPurchaseResponseBodyPriceResponseBodyCurrency Chf = new(
        Values.Chf
    );

    public static readonly PostElectricPurchaseResponseBodyPriceResponseBodyCurrency Mxn = new(
        Values.Mxn
    );

    public PostElectricPurchaseResponseBodyPriceResponseBodyCurrency(string value)
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
    public static PostElectricPurchaseResponseBodyPriceResponseBodyCurrency FromCustom(string value)
    {
        return new PostElectricPurchaseResponseBodyPriceResponseBodyCurrency(value);
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
        PostElectricPurchaseResponseBodyPriceResponseBodyCurrency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostElectricPurchaseResponseBodyPriceResponseBodyCurrency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostElectricPurchaseResponseBodyPriceResponseBodyCurrency value
    ) => value.Value;

    public static explicit operator PostElectricPurchaseResponseBodyPriceResponseBodyCurrency(
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
