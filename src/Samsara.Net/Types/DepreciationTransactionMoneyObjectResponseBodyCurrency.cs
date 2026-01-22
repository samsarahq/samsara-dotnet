using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<DepreciationTransactionMoneyObjectResponseBodyCurrency>)
)]
[Serializable]
public readonly record struct DepreciationTransactionMoneyObjectResponseBodyCurrency : IStringEnum
{
    public static readonly DepreciationTransactionMoneyObjectResponseBodyCurrency Usd = new(
        Values.Usd
    );

    public static readonly DepreciationTransactionMoneyObjectResponseBodyCurrency Gbp = new(
        Values.Gbp
    );

    public static readonly DepreciationTransactionMoneyObjectResponseBodyCurrency Cad = new(
        Values.Cad
    );

    public static readonly DepreciationTransactionMoneyObjectResponseBodyCurrency Eur = new(
        Values.Eur
    );

    public static readonly DepreciationTransactionMoneyObjectResponseBodyCurrency Chf = new(
        Values.Chf
    );

    public static readonly DepreciationTransactionMoneyObjectResponseBodyCurrency Mxn = new(
        Values.Mxn
    );

    public DepreciationTransactionMoneyObjectResponseBodyCurrency(string value)
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
    public static DepreciationTransactionMoneyObjectResponseBodyCurrency FromCustom(string value)
    {
        return new DepreciationTransactionMoneyObjectResponseBodyCurrency(value);
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
        DepreciationTransactionMoneyObjectResponseBodyCurrency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DepreciationTransactionMoneyObjectResponseBodyCurrency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DepreciationTransactionMoneyObjectResponseBodyCurrency value
    ) => value.Value;

    public static explicit operator DepreciationTransactionMoneyObjectResponseBodyCurrency(
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
