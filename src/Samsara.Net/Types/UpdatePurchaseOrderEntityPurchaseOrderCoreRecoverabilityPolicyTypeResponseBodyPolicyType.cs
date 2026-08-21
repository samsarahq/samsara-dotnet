using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<UpdatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType>)
)]
[Serializable]
public readonly record struct UpdatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType
    : IStringEnum
{
    public static readonly UpdatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType Unknown =
        new(Values.Unknown);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType RelativeToReceipt =
        new(Values.RelativeToReceipt);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType FixedDate =
        new(Values.FixedDate);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType NoDeadline =
        new(Values.NoDeadline);

    public UpdatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType(
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
    public static UpdatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType FromCustom(
        string value
    )
    {
        return new UpdatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType(
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
        UpdatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        UpdatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType value
    ) => value.Value;

    public static explicit operator UpdatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType(
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
