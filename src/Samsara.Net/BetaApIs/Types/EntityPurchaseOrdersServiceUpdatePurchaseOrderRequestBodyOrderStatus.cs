using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(
    typeof(StringEnumSerializer<EntityPurchaseOrdersServiceUpdatePurchaseOrderRequestBodyOrderStatus>)
)]
[Serializable]
public readonly record struct EntityPurchaseOrdersServiceUpdatePurchaseOrderRequestBodyOrderStatus
    : IStringEnum
{
    public static readonly EntityPurchaseOrdersServiceUpdatePurchaseOrderRequestBodyOrderStatus Unknown =
        new(Values.Unknown);

    public static readonly EntityPurchaseOrdersServiceUpdatePurchaseOrderRequestBodyOrderStatus Draft =
        new(Values.Draft);

    public static readonly EntityPurchaseOrdersServiceUpdatePurchaseOrderRequestBodyOrderStatus Open =
        new(Values.Open);

    public static readonly EntityPurchaseOrdersServiceUpdatePurchaseOrderRequestBodyOrderStatus InReview =
        new(Values.InReview);

    public static readonly EntityPurchaseOrdersServiceUpdatePurchaseOrderRequestBodyOrderStatus Approved =
        new(Values.Approved);

    public static readonly EntityPurchaseOrdersServiceUpdatePurchaseOrderRequestBodyOrderStatus Rejected =
        new(Values.Rejected);

    public static readonly EntityPurchaseOrdersServiceUpdatePurchaseOrderRequestBodyOrderStatus SentToVendor =
        new(Values.SentToVendor);

    public static readonly EntityPurchaseOrdersServiceUpdatePurchaseOrderRequestBodyOrderStatus PartiallyReceived =
        new(Values.PartiallyReceived);

    public static readonly EntityPurchaseOrdersServiceUpdatePurchaseOrderRequestBodyOrderStatus FullyReceived =
        new(Values.FullyReceived);

    public static readonly EntityPurchaseOrdersServiceUpdatePurchaseOrderRequestBodyOrderStatus Returned =
        new(Values.Returned);

    public static readonly EntityPurchaseOrdersServiceUpdatePurchaseOrderRequestBodyOrderStatus Cancelled =
        new(Values.Cancelled);

    public static readonly EntityPurchaseOrdersServiceUpdatePurchaseOrderRequestBodyOrderStatus Closed =
        new(Values.Closed);

    public EntityPurchaseOrdersServiceUpdatePurchaseOrderRequestBodyOrderStatus(string value)
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
    public static EntityPurchaseOrdersServiceUpdatePurchaseOrderRequestBodyOrderStatus FromCustom(
        string value
    )
    {
        return new EntityPurchaseOrdersServiceUpdatePurchaseOrderRequestBodyOrderStatus(value);
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
        EntityPurchaseOrdersServiceUpdatePurchaseOrderRequestBodyOrderStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityPurchaseOrdersServiceUpdatePurchaseOrderRequestBodyOrderStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityPurchaseOrdersServiceUpdatePurchaseOrderRequestBodyOrderStatus value
    ) => value.Value;

    public static explicit operator EntityPurchaseOrdersServiceUpdatePurchaseOrderRequestBodyOrderStatus(
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
