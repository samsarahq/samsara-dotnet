using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityListPurchaseOrdersTypeResponseBodyOrderStatus>))]
[Serializable]
public readonly record struct EntityListPurchaseOrdersTypeResponseBodyOrderStatus : IStringEnum
{
    public static readonly EntityListPurchaseOrdersTypeResponseBodyOrderStatus Unknown = new(
        Values.Unknown
    );

    public static readonly EntityListPurchaseOrdersTypeResponseBodyOrderStatus Draft = new(
        Values.Draft
    );

    public static readonly EntityListPurchaseOrdersTypeResponseBodyOrderStatus Open = new(
        Values.Open
    );

    public static readonly EntityListPurchaseOrdersTypeResponseBodyOrderStatus InReview = new(
        Values.InReview
    );

    public static readonly EntityListPurchaseOrdersTypeResponseBodyOrderStatus Approved = new(
        Values.Approved
    );

    public static readonly EntityListPurchaseOrdersTypeResponseBodyOrderStatus Rejected = new(
        Values.Rejected
    );

    public static readonly EntityListPurchaseOrdersTypeResponseBodyOrderStatus SentToVendor = new(
        Values.SentToVendor
    );

    public static readonly EntityListPurchaseOrdersTypeResponseBodyOrderStatus PartiallyReceived =
        new(Values.PartiallyReceived);

    public static readonly EntityListPurchaseOrdersTypeResponseBodyOrderStatus FullyReceived = new(
        Values.FullyReceived
    );

    public static readonly EntityListPurchaseOrdersTypeResponseBodyOrderStatus Returned = new(
        Values.Returned
    );

    public static readonly EntityListPurchaseOrdersTypeResponseBodyOrderStatus Cancelled = new(
        Values.Cancelled
    );

    public static readonly EntityListPurchaseOrdersTypeResponseBodyOrderStatus Closed = new(
        Values.Closed
    );

    public EntityListPurchaseOrdersTypeResponseBodyOrderStatus(string value)
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
    public static EntityListPurchaseOrdersTypeResponseBodyOrderStatus FromCustom(string value)
    {
        return new EntityListPurchaseOrdersTypeResponseBodyOrderStatus(value);
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
        EntityListPurchaseOrdersTypeResponseBodyOrderStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityListPurchaseOrdersTypeResponseBodyOrderStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityListPurchaseOrdersTypeResponseBodyOrderStatus value
    ) => value.Value;

    public static explicit operator EntityListPurchaseOrdersTypeResponseBodyOrderStatus(
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
