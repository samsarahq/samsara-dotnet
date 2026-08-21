using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityCreatePurchaseOrderTypeResponseBodyOrderStatus>))]
[Serializable]
public readonly record struct EntityCreatePurchaseOrderTypeResponseBodyOrderStatus : IStringEnum
{
    public static readonly EntityCreatePurchaseOrderTypeResponseBodyOrderStatus Unknown = new(
        Values.Unknown
    );

    public static readonly EntityCreatePurchaseOrderTypeResponseBodyOrderStatus Draft = new(
        Values.Draft
    );

    public static readonly EntityCreatePurchaseOrderTypeResponseBodyOrderStatus Open = new(
        Values.Open
    );

    public static readonly EntityCreatePurchaseOrderTypeResponseBodyOrderStatus InReview = new(
        Values.InReview
    );

    public static readonly EntityCreatePurchaseOrderTypeResponseBodyOrderStatus Approved = new(
        Values.Approved
    );

    public static readonly EntityCreatePurchaseOrderTypeResponseBodyOrderStatus Rejected = new(
        Values.Rejected
    );

    public static readonly EntityCreatePurchaseOrderTypeResponseBodyOrderStatus SentToVendor = new(
        Values.SentToVendor
    );

    public static readonly EntityCreatePurchaseOrderTypeResponseBodyOrderStatus PartiallyReceived =
        new(Values.PartiallyReceived);

    public static readonly EntityCreatePurchaseOrderTypeResponseBodyOrderStatus FullyReceived = new(
        Values.FullyReceived
    );

    public static readonly EntityCreatePurchaseOrderTypeResponseBodyOrderStatus Returned = new(
        Values.Returned
    );

    public static readonly EntityCreatePurchaseOrderTypeResponseBodyOrderStatus Cancelled = new(
        Values.Cancelled
    );

    public static readonly EntityCreatePurchaseOrderTypeResponseBodyOrderStatus Closed = new(
        Values.Closed
    );

    public EntityCreatePurchaseOrderTypeResponseBodyOrderStatus(string value)
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
    public static EntityCreatePurchaseOrderTypeResponseBodyOrderStatus FromCustom(string value)
    {
        return new EntityCreatePurchaseOrderTypeResponseBodyOrderStatus(value);
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
        EntityCreatePurchaseOrderTypeResponseBodyOrderStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityCreatePurchaseOrderTypeResponseBodyOrderStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityCreatePurchaseOrderTypeResponseBodyOrderStatus value
    ) => value.Value;

    public static explicit operator EntityCreatePurchaseOrderTypeResponseBodyOrderStatus(
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
