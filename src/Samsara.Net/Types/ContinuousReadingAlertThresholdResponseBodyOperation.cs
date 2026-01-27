using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<ContinuousReadingAlertThresholdResponseBodyOperation>))]
[Serializable]
public readonly record struct ContinuousReadingAlertThresholdResponseBodyOperation : IStringEnum
{
    public static readonly ContinuousReadingAlertThresholdResponseBodyOperation Greater = new(
        Values.Greater
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyOperation InsideRange = new(
        Values.InsideRange
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyOperation Less = new(
        Values.Less
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyOperation OutsideRange = new(
        Values.OutsideRange
    );

    public ContinuousReadingAlertThresholdResponseBodyOperation(string value)
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
    public static ContinuousReadingAlertThresholdResponseBodyOperation FromCustom(string value)
    {
        return new ContinuousReadingAlertThresholdResponseBodyOperation(value);
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
        ContinuousReadingAlertThresholdResponseBodyOperation value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ContinuousReadingAlertThresholdResponseBodyOperation value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ContinuousReadingAlertThresholdResponseBodyOperation value
    ) => value.Value;

    public static explicit operator ContinuousReadingAlertThresholdResponseBodyOperation(
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
