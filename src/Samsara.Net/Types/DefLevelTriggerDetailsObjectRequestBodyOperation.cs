using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DefLevelTriggerDetailsObjectRequestBodyOperation>))]
[Serializable]
public readonly record struct DefLevelTriggerDetailsObjectRequestBodyOperation : IStringEnum
{
    public static readonly DefLevelTriggerDetailsObjectRequestBodyOperation Greater = new(
        Values.Greater
    );

    public static readonly DefLevelTriggerDetailsObjectRequestBodyOperation Less = new(Values.Less);

    public DefLevelTriggerDetailsObjectRequestBodyOperation(string value)
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
    public static DefLevelTriggerDetailsObjectRequestBodyOperation FromCustom(string value)
    {
        return new DefLevelTriggerDetailsObjectRequestBodyOperation(value);
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
        DefLevelTriggerDetailsObjectRequestBodyOperation value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DefLevelTriggerDetailsObjectRequestBodyOperation value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DefLevelTriggerDetailsObjectRequestBodyOperation value
    ) => value.Value;

    public static explicit operator DefLevelTriggerDetailsObjectRequestBodyOperation(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Greater = "GREATER";

        public const string Less = "LESS";
    }
}
