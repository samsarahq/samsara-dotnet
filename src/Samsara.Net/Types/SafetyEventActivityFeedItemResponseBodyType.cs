using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<SafetyEventActivityFeedItemResponseBodyType>))]
[Serializable]
public readonly record struct SafetyEventActivityFeedItemResponseBodyType : IStringEnum
{
    public static readonly SafetyEventActivityFeedItemResponseBodyType BehaviorLabelActivityType =
        new(Values.BehaviorLabelActivityType);

    public static readonly SafetyEventActivityFeedItemResponseBodyType CoachingStateActivityType =
        new(Values.CoachingStateActivityType);

    public static readonly SafetyEventActivityFeedItemResponseBodyType CreateSafetyEventActivityType =
        new(Values.CreateSafetyEventActivityType);

    public SafetyEventActivityFeedItemResponseBodyType(string value)
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
    public static SafetyEventActivityFeedItemResponseBodyType FromCustom(string value)
    {
        return new SafetyEventActivityFeedItemResponseBodyType(value);
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
        SafetyEventActivityFeedItemResponseBodyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SafetyEventActivityFeedItemResponseBodyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SafetyEventActivityFeedItemResponseBodyType value) =>
        value.Value;

    public static explicit operator SafetyEventActivityFeedItemResponseBodyType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string BehaviorLabelActivityType = "BehaviorLabelActivityType";

        public const string CoachingStateActivityType = "CoachingStateActivityType";

        public const string CreateSafetyEventActivityType = "CreateSafetyEventActivityType";
    }
}
