using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<WorkOrderMoneyObjectRequestBodyCurrency>))]
[Serializable]
public readonly record struct WorkOrderMoneyObjectRequestBodyCurrency : IStringEnum
{
    public static readonly WorkOrderMoneyObjectRequestBodyCurrency Usd = new(Values.Usd);

    public WorkOrderMoneyObjectRequestBodyCurrency(string value)
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
    public static WorkOrderMoneyObjectRequestBodyCurrency FromCustom(string value)
    {
        return new WorkOrderMoneyObjectRequestBodyCurrency(value);
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

    public static bool operator ==(WorkOrderMoneyObjectRequestBodyCurrency value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WorkOrderMoneyObjectRequestBodyCurrency value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WorkOrderMoneyObjectRequestBodyCurrency value) =>
        value.Value;

    public static explicit operator WorkOrderMoneyObjectRequestBodyCurrency(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Usd = "usd";
    }
}
