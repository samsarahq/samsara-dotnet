using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<EntityListPartTransactionsTypeResponseBodyTransactionType>)
)]
[Serializable]
public readonly record struct EntityListPartTransactionsTypeResponseBodyTransactionType
    : IStringEnum
{
    public static readonly EntityListPartTransactionsTypeResponseBodyTransactionType Unknown = new(
        Values.Unknown
    );

    public static readonly EntityListPartTransactionsTypeResponseBodyTransactionType Receive = new(
        Values.Receive
    );

    public static readonly EntityListPartTransactionsTypeResponseBodyTransactionType Transfer = new(
        Values.Transfer
    );

    public static readonly EntityListPartTransactionsTypeResponseBodyTransactionType Scrap = new(
        Values.Scrap
    );

    public static readonly EntityListPartTransactionsTypeResponseBodyTransactionType Adjust = new(
        Values.Adjust
    );

    public static readonly EntityListPartTransactionsTypeResponseBodyTransactionType Reserve = new(
        Values.Reserve
    );

    public static readonly EntityListPartTransactionsTypeResponseBodyTransactionType Issue = new(
        Values.Issue
    );

    public static readonly EntityListPartTransactionsTypeResponseBodyTransactionType Release = new(
        Values.Release
    );

    public static readonly EntityListPartTransactionsTypeResponseBodyTransactionType Return = new(
        Values.Return
    );

    public EntityListPartTransactionsTypeResponseBodyTransactionType(string value)
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
    public static EntityListPartTransactionsTypeResponseBodyTransactionType FromCustom(string value)
    {
        return new EntityListPartTransactionsTypeResponseBodyTransactionType(value);
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
        EntityListPartTransactionsTypeResponseBodyTransactionType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityListPartTransactionsTypeResponseBodyTransactionType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityListPartTransactionsTypeResponseBodyTransactionType value
    ) => value.Value;

    public static explicit operator EntityListPartTransactionsTypeResponseBodyTransactionType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "Unknown";

        public const string Receive = "Receive";

        public const string Transfer = "Transfer";

        public const string Scrap = "Scrap";

        public const string Adjust = "Adjust";

        public const string Reserve = "Reserve";

        public const string Issue = "Issue";

        public const string Release = "Release";

        public const string Return = "Return";
    }
}
