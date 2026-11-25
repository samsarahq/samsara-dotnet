using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<PartsRequestResponseObjectResponseBodyFulfillmentMethod>)
)]
[Serializable]
public readonly record struct PartsRequestResponseObjectResponseBodyFulfillmentMethod : IStringEnum
{
    public static readonly PartsRequestResponseObjectResponseBodyFulfillmentMethod Stock = new(
        Values.Stock
    );

    public static readonly PartsRequestResponseObjectResponseBodyFulfillmentMethod Purchase = new(
        Values.Purchase
    );

    public static readonly PartsRequestResponseObjectResponseBodyFulfillmentMethod Transfer = new(
        Values.Transfer
    );

    public static readonly PartsRequestResponseObjectResponseBodyFulfillmentMethod Unknown = new(
        Values.Unknown
    );

    public PartsRequestResponseObjectResponseBodyFulfillmentMethod(string value)
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
    public static PartsRequestResponseObjectResponseBodyFulfillmentMethod FromCustom(string value)
    {
        return new PartsRequestResponseObjectResponseBodyFulfillmentMethod(value);
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
        PartsRequestResponseObjectResponseBodyFulfillmentMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PartsRequestResponseObjectResponseBodyFulfillmentMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PartsRequestResponseObjectResponseBodyFulfillmentMethod value
    ) => value.Value;

    public static explicit operator PartsRequestResponseObjectResponseBodyFulfillmentMethod(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Stock = "stock";

        public const string Purchase = "purchase";

        public const string Transfer = "transfer";

        public const string Unknown = "unknown";
    }
}
