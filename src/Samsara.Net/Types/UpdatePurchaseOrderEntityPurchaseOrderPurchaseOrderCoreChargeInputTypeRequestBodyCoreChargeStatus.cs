using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBodyCoreChargeStatus>)
)]
[Serializable]
public readonly record struct UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBodyCoreChargeStatus
    : IStringEnum
{
    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBodyCoreChargeStatus Unknown =
        new(Values.Unknown);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBodyCoreChargeStatus Active =
        new(Values.Active);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBodyCoreChargeStatus RemovedOrDisabled =
        new(Values.RemovedOrDisabled);

    public UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBodyCoreChargeStatus(
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
    public static UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBodyCoreChargeStatus FromCustom(
        string value
    )
    {
        return new UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBodyCoreChargeStatus(
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
        UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBodyCoreChargeStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBodyCoreChargeStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBodyCoreChargeStatus value
    ) => value.Value;

    public static explicit operator UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBodyCoreChargeStatus(
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
