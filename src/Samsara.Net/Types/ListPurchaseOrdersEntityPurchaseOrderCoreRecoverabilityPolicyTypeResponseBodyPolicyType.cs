using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<ListPurchaseOrdersEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType>)
)]
[Serializable]
public readonly record struct ListPurchaseOrdersEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType
    : IStringEnum
{
    public static readonly ListPurchaseOrdersEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType Unknown =
        new(Values.Unknown);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType RelativeToReceipt =
        new(Values.RelativeToReceipt);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType FixedDate =
        new(Values.FixedDate);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType NoDeadline =
        new(Values.NoDeadline);

    public ListPurchaseOrdersEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType(
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
    public static ListPurchaseOrdersEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType FromCustom(
        string value
    )
    {
        return new ListPurchaseOrdersEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType(
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
        ListPurchaseOrdersEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListPurchaseOrdersEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListPurchaseOrdersEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType value
    ) => value.Value;

    public static explicit operator ListPurchaseOrdersEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "Unknown";

        public const string RelativeToReceipt = "RelativeToReceipt";

        public const string FixedDate = "FixedDate";

        public const string NoDeadline = "NoDeadline";
    }
}
