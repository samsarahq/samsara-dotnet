using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(
    typeof(StringEnumSerializer<EntityPurchaseOrdersServiceCreatePurchaseOrderRequestBodyOrderStatus>)
)]
[Serializable]
public readonly record struct EntityPurchaseOrdersServiceCreatePurchaseOrderRequestBodyOrderStatus
    : IStringEnum
{
    public static readonly EntityPurchaseOrdersServiceCreatePurchaseOrderRequestBodyOrderStatus Unknown =
        new(Values.Unknown);

    public static readonly EntityPurchaseOrdersServiceCreatePurchaseOrderRequestBodyOrderStatus Draft =
        new(Values.Draft);

    public static readonly EntityPurchaseOrdersServiceCreatePurchaseOrderRequestBodyOrderStatus Open =
        new(Values.Open);

    public static readonly EntityPurchaseOrdersServiceCreatePurchaseOrderRequestBodyOrderStatus InReview =
        new(Values.InReview);

    public static readonly EntityPurchaseOrdersServiceCreatePurchaseOrderRequestBodyOrderStatus Approved =
        new(Values.Approved);

    public static readonly EntityPurchaseOrdersServiceCreatePurchaseOrderRequestBodyOrderStatus Rejected =
        new(Values.Rejected);

    public static readonly EntityPurchaseOrdersServiceCreatePurchaseOrderRequestBodyOrderStatus SentToVendor =
        new(Values.SentToVendor);

    public static readonly EntityPurchaseOrdersServiceCreatePurchaseOrderRequestBodyOrderStatus PartiallyReceived =
        new(Values.PartiallyReceived);

    public static readonly EntityPurchaseOrdersServiceCreatePurchaseOrderRequestBodyOrderStatus FullyReceived =
        new(Values.FullyReceived);

    public static readonly EntityPurchaseOrdersServiceCreatePurchaseOrderRequestBodyOrderStatus Returned =
        new(Values.Returned);

    public static readonly EntityPurchaseOrdersServiceCreatePurchaseOrderRequestBodyOrderStatus Cancelled =
        new(Values.Cancelled);

    public static readonly EntityPurchaseOrdersServiceCreatePurchaseOrderRequestBodyOrderStatus Closed =
        new(Values.Closed);

    public EntityPurchaseOrdersServiceCreatePurchaseOrderRequestBodyOrderStatus(string value)
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
    public static EntityPurchaseOrdersServiceCreatePurchaseOrderRequestBodyOrderStatus FromCustom(
        string value
    )
    {
        return new EntityPurchaseOrdersServiceCreatePurchaseOrderRequestBodyOrderStatus(value);
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
        EntityPurchaseOrdersServiceCreatePurchaseOrderRequestBodyOrderStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityPurchaseOrdersServiceCreatePurchaseOrderRequestBodyOrderStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityPurchaseOrdersServiceCreatePurchaseOrderRequestBodyOrderStatus value
    ) => value.Value;

    public static explicit operator EntityPurchaseOrdersServiceCreatePurchaseOrderRequestBodyOrderStatus(
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
