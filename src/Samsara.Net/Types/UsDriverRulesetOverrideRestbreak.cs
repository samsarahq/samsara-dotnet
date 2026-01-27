using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<UsDriverRulesetOverrideRestbreak>))]
[Serializable]
public readonly record struct UsDriverRulesetOverrideRestbreak : IStringEnum
{
    public static readonly UsDriverRulesetOverrideRestbreak PropertyOffDutySleeper = new(
        Values.PropertyOffDutySleeper
    );

    public static readonly UsDriverRulesetOverrideRestbreak CaliforniaMealbreakOffDutySleeper = new(
        Values.CaliforniaMealbreakOffDutySleeper
    );

    public static readonly UsDriverRulesetOverrideRestbreak None = new(Values.None);

    public UsDriverRulesetOverrideRestbreak(string value)
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
    public static UsDriverRulesetOverrideRestbreak FromCustom(string value)
    {
        return new UsDriverRulesetOverrideRestbreak(value);
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

    public static bool operator ==(UsDriverRulesetOverrideRestbreak value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UsDriverRulesetOverrideRestbreak value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UsDriverRulesetOverrideRestbreak value) => value.Value;

    public static explicit operator UsDriverRulesetOverrideRestbreak(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string PropertyOffDutySleeper = "Property (off-duty/sleeper)";

        public const string CaliforniaMealbreakOffDutySleeper =
            "California Mealbreak (off-duty/sleeper)";

        public const string None = "None";
    }
}
