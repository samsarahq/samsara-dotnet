using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<SpeedTriggerDetailsObjectRequestBodyOperation>))]
[Serializable]
public readonly record struct SpeedTriggerDetailsObjectRequestBodyOperation : IStringEnum
{
    public static readonly SpeedTriggerDetailsObjectRequestBodyOperation Greater = new(
        Values.Greater
    );

    public static readonly SpeedTriggerDetailsObjectRequestBodyOperation Less = new(Values.Less);

    public SpeedTriggerDetailsObjectRequestBodyOperation(string value)
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
    public static SpeedTriggerDetailsObjectRequestBodyOperation FromCustom(string value)
    {
        return new SpeedTriggerDetailsObjectRequestBodyOperation(value);
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
        SpeedTriggerDetailsObjectRequestBodyOperation value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SpeedTriggerDetailsObjectRequestBodyOperation value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SpeedTriggerDetailsObjectRequestBodyOperation value) =>
        value.Value;

    public static explicit operator SpeedTriggerDetailsObjectRequestBodyOperation(string value) =>
        new(value);

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
