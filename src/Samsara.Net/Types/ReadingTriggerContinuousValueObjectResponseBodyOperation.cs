using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<ReadingTriggerContinuousValueObjectResponseBodyOperation>)
)]
[Serializable]
public readonly record struct ReadingTriggerContinuousValueObjectResponseBodyOperation : IStringEnum
{
    public static readonly ReadingTriggerContinuousValueObjectResponseBodyOperation Greater = new(
        Values.Greater
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyOperation InsideRange =
        new(Values.InsideRange);

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyOperation Less = new(
        Values.Less
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyOperation OutsideRange =
        new(Values.OutsideRange);

    public ReadingTriggerContinuousValueObjectResponseBodyOperation(string value)
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
    public static ReadingTriggerContinuousValueObjectResponseBodyOperation FromCustom(string value)
    {
        return new ReadingTriggerContinuousValueObjectResponseBodyOperation(value);
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
        ReadingTriggerContinuousValueObjectResponseBodyOperation value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ReadingTriggerContinuousValueObjectResponseBodyOperation value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ReadingTriggerContinuousValueObjectResponseBodyOperation value
    ) => value.Value;

    public static explicit operator ReadingTriggerContinuousValueObjectResponseBodyOperation(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Greater = "GREATER";

        public const string InsideRange = "INSIDE_RANGE";

        public const string Less = "LESS";

        public const string OutsideRange = "OUTSIDE_RANGE";
    }
}
