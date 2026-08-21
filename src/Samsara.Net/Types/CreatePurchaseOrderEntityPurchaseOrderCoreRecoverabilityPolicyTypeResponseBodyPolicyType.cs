using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType>)
)]
[Serializable]
public readonly record struct CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType
    : IStringEnum
{
    public static readonly CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType Unknown =
        new(Values.Unknown);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType RelativeToReceipt =
        new(Values.RelativeToReceipt);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType FixedDate =
        new(Values.FixedDate);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType NoDeadline =
        new(Values.NoDeadline);

    public CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType(
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
    public static CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType FromCustom(
        string value
    )
    {
        return new CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType(
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
        CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType value
    ) => value.Value;

    public static explicit operator CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBodyPolicyType(
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
