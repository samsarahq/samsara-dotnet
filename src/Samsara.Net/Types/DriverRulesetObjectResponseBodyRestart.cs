using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DriverRulesetObjectResponseBodyRestart>))]
[Serializable]
public readonly record struct DriverRulesetObjectResponseBodyRestart : IStringEnum
{
    public static readonly DriverRulesetObjectResponseBodyRestart ThirtyFourHourRestart = new(
        Values.ThirtyFourHourRestart
    );

    public static readonly DriverRulesetObjectResponseBodyRestart TwentyFourHourRestart = new(
        Values.TwentyFourHourRestart
    );

    public static readonly DriverRulesetObjectResponseBodyRestart ThirtySixHourRestart = new(
        Values.ThirtySixHourRestart
    );

    public static readonly DriverRulesetObjectResponseBodyRestart SeventyTwoHourRestart = new(
        Values.SeventyTwoHourRestart
    );

    public DriverRulesetObjectResponseBodyRestart(string value)
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
    public static DriverRulesetObjectResponseBodyRestart FromCustom(string value)
    {
        return new DriverRulesetObjectResponseBodyRestart(value);
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

    public static bool operator ==(DriverRulesetObjectResponseBodyRestart value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DriverRulesetObjectResponseBodyRestart value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DriverRulesetObjectResponseBodyRestart value) =>
        value.Value;

    public static explicit operator DriverRulesetObjectResponseBodyRestart(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string ThirtyFourHourRestart = "34-hour Restart";

        public const string TwentyFourHourRestart = "24-hour Restart";

        public const string ThirtySixHourRestart = "36-hour Restart";

        public const string SeventyTwoHourRestart = "72-hour Restart";
    }
}
