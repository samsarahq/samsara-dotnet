using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<SafetyBehaviorTriggerDetailsObjectRequestBodyStatusesItem>)
)]
[Serializable]
public readonly record struct SafetyBehaviorTriggerDetailsObjectRequestBodyStatusesItem
    : IStringEnum
{
    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyStatusesItem NeedsCoaching =
        new(Values.NeedsCoaching);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyStatusesItem NeedsRecognition =
        new(Values.NeedsRecognition);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyStatusesItem NeedsReview =
        new(Values.NeedsReview);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyStatusesItem Recognized =
        new(Values.Recognized);

    public static readonly SafetyBehaviorTriggerDetailsObjectRequestBodyStatusesItem Reviewed = new(
        Values.Reviewed
    );

    public SafetyBehaviorTriggerDetailsObjectRequestBodyStatusesItem(string value)
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
    public static SafetyBehaviorTriggerDetailsObjectRequestBodyStatusesItem FromCustom(string value)
    {
        return new SafetyBehaviorTriggerDetailsObjectRequestBodyStatusesItem(value);
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
        SafetyBehaviorTriggerDetailsObjectRequestBodyStatusesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SafetyBehaviorTriggerDetailsObjectRequestBodyStatusesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SafetyBehaviorTriggerDetailsObjectRequestBodyStatusesItem value
    ) => value.Value;

    public static explicit operator SafetyBehaviorTriggerDetailsObjectRequestBodyStatusesItem(
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
