using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DriverRulesetObjectResponseBodyBreak>))]
[Serializable]
public readonly record struct DriverRulesetObjectResponseBodyBreak : IStringEnum
{
    public static readonly DriverRulesetObjectResponseBodyBreak PropertyOffDutySleeper = new(
        Values.PropertyOffDutySleeper
    );

    public static readonly DriverRulesetObjectResponseBodyBreak ExplosivesHazMatOnDuty = new(
        Values.ExplosivesHazMatOnDuty
    );

    public DriverRulesetObjectResponseBodyBreak(string value)
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
    public static DriverRulesetObjectResponseBodyBreak FromCustom(string value)
    {
        return new DriverRulesetObjectResponseBodyBreak(value);
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

    public static bool operator ==(DriverRulesetObjectResponseBodyBreak value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DriverRulesetObjectResponseBodyBreak value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DriverRulesetObjectResponseBodyBreak value) =>
        value.Value;

    public static explicit operator DriverRulesetObjectResponseBodyBreak(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string PropertyOffDutySleeper = "Property (off-duty/sleeper)";

        public const string ExplosivesHazMatOnDuty = "Explosives/HazMat (on-duty)";
    }
}
