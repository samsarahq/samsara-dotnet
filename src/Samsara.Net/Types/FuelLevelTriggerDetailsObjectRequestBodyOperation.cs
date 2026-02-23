using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FuelLevelTriggerDetailsObjectRequestBodyOperation>))]
[Serializable]
public readonly record struct FuelLevelTriggerDetailsObjectRequestBodyOperation : IStringEnum
{
    public static readonly FuelLevelTriggerDetailsObjectRequestBodyOperation Less = new(
        Values.Less
    );

    public FuelLevelTriggerDetailsObjectRequestBodyOperation(string value)
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
    public static FuelLevelTriggerDetailsObjectRequestBodyOperation FromCustom(string value)
    {
        return new FuelLevelTriggerDetailsObjectRequestBodyOperation(value);
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
        FuelLevelTriggerDetailsObjectRequestBodyOperation value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FuelLevelTriggerDetailsObjectRequestBodyOperation value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FuelLevelTriggerDetailsObjectRequestBodyOperation value
    ) => value.Value;

    public static explicit operator FuelLevelTriggerDetailsObjectRequestBodyOperation(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Less = "LESS";
    }
}
