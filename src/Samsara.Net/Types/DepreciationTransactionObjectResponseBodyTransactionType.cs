using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<DepreciationTransactionObjectResponseBodyTransactionType>)
)]
[Serializable]
public readonly record struct DepreciationTransactionObjectResponseBodyTransactionType : IStringEnum
{
    public static readonly DepreciationTransactionObjectResponseBodyTransactionType Depreciation =
        new(Values.Depreciation);

    public static readonly DepreciationTransactionObjectResponseBodyTransactionType Adjustment =
        new(Values.Adjustment);

    public static readonly DepreciationTransactionObjectResponseBodyTransactionType Unknown = new(
        Values.Unknown
    );

    public DepreciationTransactionObjectResponseBodyTransactionType(string value)
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
    public static DepreciationTransactionObjectResponseBodyTransactionType FromCustom(string value)
    {
        return new DepreciationTransactionObjectResponseBodyTransactionType(value);
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
        DepreciationTransactionObjectResponseBodyTransactionType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DepreciationTransactionObjectResponseBodyTransactionType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DepreciationTransactionObjectResponseBodyTransactionType value
    ) => value.Value;

    public static explicit operator DepreciationTransactionObjectResponseBodyTransactionType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Depreciation = "depreciation";

        public const string Adjustment = "adjustment";

        public const string Unknown = "unknown";
    }
}
