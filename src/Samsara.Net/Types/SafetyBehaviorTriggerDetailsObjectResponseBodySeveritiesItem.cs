using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<SafetyBehaviorTriggerDetailsObjectResponseBodySeveritiesItem>)
)]
[Serializable]
public readonly record struct SafetyBehaviorTriggerDetailsObjectResponseBodySeveritiesItem
    : IStringEnum
{
    public static readonly SafetyBehaviorTriggerDetailsObjectResponseBodySeveritiesItem Low = new(
        Values.Low
    );

    public static readonly SafetyBehaviorTriggerDetailsObjectResponseBodySeveritiesItem Medium =
        new(Values.Medium);

    public static readonly SafetyBehaviorTriggerDetailsObjectResponseBodySeveritiesItem High = new(
        Values.High
    );

    public SafetyBehaviorTriggerDetailsObjectResponseBodySeveritiesItem(string value)
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
    public static SafetyBehaviorTriggerDetailsObjectResponseBodySeveritiesItem FromCustom(
        string value
    )
    {
        return new SafetyBehaviorTriggerDetailsObjectResponseBodySeveritiesItem(value);
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
        SafetyBehaviorTriggerDetailsObjectResponseBodySeveritiesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SafetyBehaviorTriggerDetailsObjectResponseBodySeveritiesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SafetyBehaviorTriggerDetailsObjectResponseBodySeveritiesItem value
    ) => value.Value;

    public static explicit operator SafetyBehaviorTriggerDetailsObjectResponseBodySeveritiesItem(
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
