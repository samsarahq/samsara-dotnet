using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityUpdatePurchaseOrderTypeResponseBodyOrderStatus>))]
[Serializable]
public readonly record struct EntityUpdatePurchaseOrderTypeResponseBodyOrderStatus : IStringEnum
{
    public static readonly EntityUpdatePurchaseOrderTypeResponseBodyOrderStatus Unknown = new(
        Values.Unknown
    );

    public static readonly EntityUpdatePurchaseOrderTypeResponseBodyOrderStatus Draft = new(
        Values.Draft
    );

    public static readonly EntityUpdatePurchaseOrderTypeResponseBodyOrderStatus Open = new(
        Values.Open
    );

    public static readonly EntityUpdatePurchaseOrderTypeResponseBodyOrderStatus InReview = new(
        Values.InReview
    );

    public static readonly EntityUpdatePurchaseOrderTypeResponseBodyOrderStatus Approved = new(
        Values.Approved
    );

    public static readonly EntityUpdatePurchaseOrderTypeResponseBodyOrderStatus Rejected = new(
        Values.Rejected
    );

    public static readonly EntityUpdatePurchaseOrderTypeResponseBodyOrderStatus SentToVendor = new(
        Values.SentToVendor
    );

    public static readonly EntityUpdatePurchaseOrderTypeResponseBodyOrderStatus PartiallyReceived =
        new(Values.PartiallyReceived);

    public static readonly EntityUpdatePurchaseOrderTypeResponseBodyOrderStatus FullyReceived = new(
        Values.FullyReceived
    );

    public static readonly EntityUpdatePurchaseOrderTypeResponseBodyOrderStatus Returned = new(
        Values.Returned
    );

    public static readonly EntityUpdatePurchaseOrderTypeResponseBodyOrderStatus Cancelled = new(
        Values.Cancelled
    );

    public static readonly EntityUpdatePurchaseOrderTypeResponseBodyOrderStatus Closed = new(
        Values.Closed
    );

    public EntityUpdatePurchaseOrderTypeResponseBodyOrderStatus(string value)
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
    public static EntityUpdatePurchaseOrderTypeResponseBodyOrderStatus FromCustom(string value)
    {
        return new EntityUpdatePurchaseOrderTypeResponseBodyOrderStatus(value);
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
        EntityUpdatePurchaseOrderTypeResponseBodyOrderStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityUpdatePurchaseOrderTypeResponseBodyOrderStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityUpdatePurchaseOrderTypeResponseBodyOrderStatus value
    ) => value.Value;

    public static explicit operator EntityUpdatePurchaseOrderTypeResponseBodyOrderStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "Unknown";

        public const string Draft = "Draft";

        public const string Open = "Open";

        public const string InReview = "InReview";

        public const string Approved = "Approved";

        public const string Rejected = "Rejected";

        public const string SentToVendor = "SentToVendor";

        public const string PartiallyReceived = "PartiallyReceived";

        public const string FullyReceived = "FullyReceived";

        public const string Returned = "Returned";

        public const string Cancelled = "Cancelled";

        public const string Closed = "Closed";
    }
}
