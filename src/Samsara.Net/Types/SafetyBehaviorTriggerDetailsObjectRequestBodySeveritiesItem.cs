using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<SafetyBehaviorTriggerDetailsObjectRequestBodySeveritiesItem>)
)]
[Serializable]
public readonly record struct SafetyBehaviorTriggerDetailsObjectRequestBodySeveritiesItem
    : IStringEnum
{
    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodySeveritiesItem Low = new(
        Values.Low
    );

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodySeveritiesItem Medium = new(
        Values.Medium
    );

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodySeveritiesItem High = new(
        Values.High
    );

    public SafetyBehaviorTriggerDetailsObjectRequestBodySeveritiesItem(string value)
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
    public static SafetyBehaviorTriggerDetailsObjectRequestBodySeveritiesItem FromCustom(
        string value
    )
    {
        return new SafetyBehaviorTriggerDetailsObjectRequestBodySeveritiesItem(value);
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
        SafetyBehaviorTriggerDetailsObjectRequestBodySeveritiesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SafetyBehaviorTriggerDetailsObjectRequestBodySeveritiesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SafetyBehaviorTriggerDetailsObjectRequestBodySeveritiesItem value
    ) => value.Value;

    public static explicit operator SafetyBehaviorTriggerDetailsObjectRequestBodySeveritiesItem(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Low = "low";

        public const string Medium = "medium";

        public const string High = "high";
    }
}
