using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<SafetyEventBehaviorLabelSource>))]
[Serializable]
public readonly record struct SafetyEventBehaviorLabelSource : IStringEnum
{
    public static readonly SafetyEventBehaviorLabelSource Automated = new(Values.Automated);

    public static readonly SafetyEventBehaviorLabelSource UserGenerated = new(Values.UserGenerated);

    public SafetyEventBehaviorLabelSource(string value)
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
    public static SafetyEventBehaviorLabelSource FromCustom(string value)
    {
        return new SafetyEventBehaviorLabelSource(value);
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

    public static bool operator ==(SafetyEventBehaviorLabelSource value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SafetyEventBehaviorLabelSource value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SafetyEventBehaviorLabelSource value) => value.Value;

    public static explicit operator SafetyEventBehaviorLabelSource(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Automated = "automated";

        public const string UserGenerated = "userGenerated";
    }
}
