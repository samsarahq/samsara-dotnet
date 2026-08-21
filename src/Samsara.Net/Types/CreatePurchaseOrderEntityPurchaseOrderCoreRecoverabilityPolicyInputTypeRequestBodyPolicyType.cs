using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyInputTypeRequestBodyPolicyType>)
)]
[Serializable]
public readonly record struct CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyInputTypeRequestBodyPolicyType
    : IStringEnum
{
    public static readonly CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyInputTypeRequestBodyPolicyType Unknown =
        new(Values.Unknown);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyInputTypeRequestBodyPolicyType RelativeToReceipt =
        new(Values.RelativeToReceipt);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyInputTypeRequestBodyPolicyType FixedDate =
        new(Values.FixedDate);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyInputTypeRequestBodyPolicyType NoDeadline =
        new(Values.NoDeadline);

    public CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyInputTypeRequestBodyPolicyType(
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
    public static CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyInputTypeRequestBodyPolicyType FromCustom(
        string value
    )
    {
        return new CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyInputTypeRequestBodyPolicyType(
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
        CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyInputTypeRequestBodyPolicyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyInputTypeRequestBodyPolicyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyInputTypeRequestBodyPolicyType value
    ) => value.Value;

    public static explicit operator CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyInputTypeRequestBodyPolicyType(
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
