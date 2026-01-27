using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<SpeedTriggerDetailsObjectResponseBodyOperation>))]
[Serializable]
public readonly record struct SpeedTriggerDetailsObjectResponseBodyOperation : IStringEnum
{
    public static readonly SpeedTriggerDetailsObjectResponseBodyOperation Greater = new(
        Values.Greater
    );

    public static readonly SpeedTriggerDetailsObjectResponseBodyOperation Less = new(Values.Less);

    public SpeedTriggerDetailsObjectResponseBodyOperation(string value)
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
    public static SpeedTriggerDetailsObjectResponseBodyOperation FromCustom(string value)
    {
        return new SpeedTriggerDetailsObjectResponseBodyOperation(value);
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
        SpeedTriggerDetailsObjectResponseBodyOperation value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SpeedTriggerDetailsObjectResponseBodyOperation value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SpeedTriggerDetailsObjectResponseBodyOperation value) =>
        value.Value;

    public static explicit operator SpeedTriggerDetailsObjectResponseBodyOperation(string value) =>
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
