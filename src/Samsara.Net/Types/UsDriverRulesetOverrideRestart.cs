using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<UsDriverRulesetOverrideRestart>))]
[Serializable]
public readonly record struct UsDriverRulesetOverrideRestart : IStringEnum
{
    public static readonly UsDriverRulesetOverrideRestart ThirtyFourHourRestart = new(
        Values.ThirtyFourHourRestart
    );

    public static readonly UsDriverRulesetOverrideRestart TwentyFourHourRestart = new(
        Values.TwentyFourHourRestart
    );

    public static readonly UsDriverRulesetOverrideRestart ThirtySixHourRestart = new(
        Values.ThirtySixHourRestart
    );

    public static readonly UsDriverRulesetOverrideRestart SeventyTwoHourRestart = new(
        Values.SeventyTwoHourRestart
    );

    public static readonly UsDriverRulesetOverrideRestart None = new(Values.None);

    public UsDriverRulesetOverrideRestart(string value)
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
    public static UsDriverRulesetOverrideRestart FromCustom(string value)
    {
        return new UsDriverRulesetOverrideRestart(value);
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

    public static bool operator ==(UsDriverRulesetOverrideRestart value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UsDriverRulesetOverrideRestart value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UsDriverRulesetOverrideRestart value) => value.Value;

    public static explicit operator UsDriverRulesetOverrideRestart(string value) => new(value);

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

        public const string None = "None";
    }
}
