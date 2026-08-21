using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBodyCoreChargeStatus>)
)]
[Serializable]
public readonly record struct CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBodyCoreChargeStatus
    : IStringEnum
{
    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBodyCoreChargeStatus Unknown =
        new(Values.Unknown);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBodyCoreChargeStatus Active =
        new(Values.Active);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBodyCoreChargeStatus RemovedOrDisabled =
        new(Values.RemovedOrDisabled);

    public CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBodyCoreChargeStatus(
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
    public static CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBodyCoreChargeStatus FromCustom(
        string value
    )
    {
        return new CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBodyCoreChargeStatus(
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
        CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBodyCoreChargeStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBodyCoreChargeStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBodyCoreChargeStatus value
    ) => value.Value;

    public static explicit operator CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBodyCoreChargeStatus(
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
