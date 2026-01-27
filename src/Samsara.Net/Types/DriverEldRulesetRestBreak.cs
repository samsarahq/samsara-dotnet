using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DriverEldRulesetRestBreak>))]
[Serializable]
public readonly record struct DriverEldRulesetRestBreak : IStringEnum
{
    public static readonly DriverEldRulesetRestBreak PropertyOffDutySleeper = new(
        Values.PropertyOffDutySleeper
    );

    public static readonly DriverEldRulesetRestBreak ExplosivesHazMatOnDuty = new(
        Values.ExplosivesHazMatOnDuty
    );

    public DriverEldRulesetRestBreak(string value)
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
    public static DriverEldRulesetRestBreak FromCustom(string value)
    {
        return new DriverEldRulesetRestBreak(value);
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

    public static bool operator ==(DriverEldRulesetRestBreak value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DriverEldRulesetRestBreak value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DriverEldRulesetRestBreak value) => value.Value;

    public static explicit operator DriverEldRulesetRestBreak(string value) => new(value);

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
