using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DriverEldRulesetRestart>))]
[Serializable]
public readonly record struct DriverEldRulesetRestart : IStringEnum
{
    public static readonly DriverEldRulesetRestart None = new(Values.None);

    public static readonly DriverEldRulesetRestart ThirtyFourHourRestart = new(
        Values.ThirtyFourHourRestart
    );

    public static readonly DriverEldRulesetRestart TwentyFourHourRestart = new(
        Values.TwentyFourHourRestart
    );

    public static readonly DriverEldRulesetRestart ThirtySixHourRestart = new(
        Values.ThirtySixHourRestart
    );

    public static readonly DriverEldRulesetRestart SeventyTwoHourRestart = new(
        Values.SeventyTwoHourRestart
    );

    public DriverEldRulesetRestart(string value)
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
    public static DriverEldRulesetRestart FromCustom(string value)
    {
        return new DriverEldRulesetRestart(value);
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

    public static bool operator ==(DriverEldRulesetRestart value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DriverEldRulesetRestart value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DriverEldRulesetRestart value) => value.Value;

    public static explicit operator DriverEldRulesetRestart(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string None = "None";

        public const string ThirtyFourHourRestart = "34-hour Restart";

        public const string TwentyFourHourRestart = "24-hour Restart";

        public const string ThirtySixHourRestart = "36-hour Restart";

        public const string SeventyTwoHourRestart = "72-hour Restart";
    }
}
