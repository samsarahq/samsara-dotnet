using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<SafetyBehaviorTriggerDetailsObjectResponseBodyStatusesItem>)
)]
[Serializable]
public readonly record struct SafetyBehaviorTriggerDetailsObjectResponseBodyStatusesItem
    : IStringEnum
{
    public static readonly SafetyBehaviorTriggerDetailsObjectResponseBodyStatusesItem NeedsCoaching =
        new(Values.NeedsCoaching);

    public static readonly SafetyBehaviorTriggerDetailsObjectResponseBodyStatusesItem NeedsRecognition =
        new(Values.NeedsRecognition);

    public static readonly SafetyBehaviorTriggerDetailsObjectResponseBodyStatusesItem NeedsReview =
        new(Values.NeedsReview);

    public static readonly SafetyBehaviorTriggerDetailsObjectResponseBodyStatusesItem Recognized =
        new(Values.Recognized);

    public static readonly SafetyBehaviorTriggerDetailsObjectResponseBodyStatusesItem Reviewed =
        new(Values.Reviewed);

    public SafetyBehaviorTriggerDetailsObjectResponseBodyStatusesItem(string value)
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
    public static SafetyBehaviorTriggerDetailsObjectResponseBodyStatusesItem FromCustom(
        string value
    )
    {
        return new SafetyBehaviorTriggerDetailsObjectResponseBodyStatusesItem(value);
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
        SafetyBehaviorTriggerDetailsObjectResponseBodyStatusesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SafetyBehaviorTriggerDetailsObjectResponseBodyStatusesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SafetyBehaviorTriggerDetailsObjectResponseBodyStatusesItem value
    ) => value.Value;

    public static explicit operator SafetyBehaviorTriggerDetailsObjectResponseBodyStatusesItem(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string NeedsCoaching = "NEEDS_COACHING";

        public const string NeedsRecognition = "NEEDS_RECOGNITION";

        public const string NeedsReview = "NEEDS_REVIEW";

        public const string Recognized = "RECOGNIZED";

        public const string Reviewed = "REVIEWED";
    }
}
