using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderCoreChargeTypeResponseBodyCoreChargeStatus>)
)]
[Serializable]
public readonly record struct ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderCoreChargeTypeResponseBodyCoreChargeStatus
    : IStringEnum
{
    public static readonly ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderCoreChargeTypeResponseBodyCoreChargeStatus Unknown =
        new(Values.Unknown);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderCoreChargeTypeResponseBodyCoreChargeStatus Active =
        new(Values.Active);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderCoreChargeTypeResponseBodyCoreChargeStatus RemovedOrDisabled =
        new(Values.RemovedOrDisabled);

    public ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderCoreChargeTypeResponseBodyCoreChargeStatus(
        string value
    )
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
    public static ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderCoreChargeTypeResponseBodyCoreChargeStatus FromCustom(
        string value
    )
    {
        return new ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderCoreChargeTypeResponseBodyCoreChargeStatus(
            value
        );
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
        ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderCoreChargeTypeResponseBodyCoreChargeStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderCoreChargeTypeResponseBodyCoreChargeStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderCoreChargeTypeResponseBodyCoreChargeStatus value
    ) => value.Value;

    public static explicit operator ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderCoreChargeTypeResponseBodyCoreChargeStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "Unknown";

        public const string Active = "Active";

        public const string RemovedOrDisabled = "RemovedOrDisabled";
    }
}
