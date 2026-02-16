using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FuelLevelTriggerDetailsObjectResponseBodyOperation>))]
[Serializable]
public readonly record struct FuelLevelTriggerDetailsObjectResponseBodyOperation : IStringEnum
{
    public static readonly FuelLevelTriggerDetailsObjectResponseBodyOperation Less = new(
        Values.Less
    );

    public FuelLevelTriggerDetailsObjectResponseBodyOperation(string value)
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
    public static FuelLevelTriggerDetailsObjectResponseBodyOperation FromCustom(string value)
    {
        return new FuelLevelTriggerDetailsObjectResponseBodyOperation(value);
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
        FuelLevelTriggerDetailsObjectResponseBodyOperation value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FuelLevelTriggerDetailsObjectResponseBodyOperation value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FuelLevelTriggerDetailsObjectResponseBodyOperation value
    ) => value.Value;

    public static explicit operator FuelLevelTriggerDetailsObjectResponseBodyOperation(
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
