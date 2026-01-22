using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<UsDriverRulesetOverrideUsStateToOverride>))]
[Serializable]
public readonly record struct UsDriverRulesetOverrideUsStateToOverride : IStringEnum
{
    public static readonly UsDriverRulesetOverrideUsStateToOverride Empty = new(Values.Empty);

    public static readonly UsDriverRulesetOverrideUsStateToOverride Ak = new(Values.Ak);

    public static readonly UsDriverRulesetOverrideUsStateToOverride Ca = new(Values.Ca);

    public static readonly UsDriverRulesetOverrideUsStateToOverride Fl = new(Values.Fl);

    public static readonly UsDriverRulesetOverrideUsStateToOverride Ne = new(Values.Ne);

    public static readonly UsDriverRulesetOverrideUsStateToOverride Nc = new(Values.Nc);

    public static readonly UsDriverRulesetOverrideUsStateToOverride Ok = new(Values.Ok);

    public static readonly UsDriverRulesetOverrideUsStateToOverride Or = new(Values.Or);

    public static readonly UsDriverRulesetOverrideUsStateToOverride Sc = new(Values.Sc);

    public static readonly UsDriverRulesetOverrideUsStateToOverride Tx = new(Values.Tx);

    public static readonly UsDriverRulesetOverrideUsStateToOverride Wi = new(Values.Wi);

    public UsDriverRulesetOverrideUsStateToOverride(string value)
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
    public static UsDriverRulesetOverrideUsStateToOverride FromCustom(string value)
    {
        return new UsDriverRulesetOverrideUsStateToOverride(value);
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
        UsDriverRulesetOverrideUsStateToOverride value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UsDriverRulesetOverrideUsStateToOverride value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(UsDriverRulesetOverrideUsStateToOverride value) =>
        value.Value;

    public static explicit operator UsDriverRulesetOverrideUsStateToOverride(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Empty = "";

        public const string Ak = "AK";

        public const string Ca = "CA";

        public const string Fl = "FL";

        public const string Ne = "NE";

        public const string Nc = "NC";

        public const string Ok = "OK";

        public const string Or = "OR";

        public const string Sc = "SC";

        public const string Tx = "TX";

        public const string Wi = "WI";
    }
}
