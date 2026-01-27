using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<WorkOrderMoneyObjectResponseBodyCurrency>))]
[Serializable]
public readonly record struct WorkOrderMoneyObjectResponseBodyCurrency : IStringEnum
{
    public static readonly WorkOrderMoneyObjectResponseBodyCurrency Usd = new(Values.Usd);

    public WorkOrderMoneyObjectResponseBodyCurrency(string value)
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
    public static WorkOrderMoneyObjectResponseBodyCurrency FromCustom(string value)
    {
        return new WorkOrderMoneyObjectResponseBodyCurrency(value);
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
        WorkOrderMoneyObjectResponseBodyCurrency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        WorkOrderMoneyObjectResponseBodyCurrency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(WorkOrderMoneyObjectResponseBodyCurrency value) =>
        value.Value;

    public static explicit operator WorkOrderMoneyObjectResponseBodyCurrency(string value) =>
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
