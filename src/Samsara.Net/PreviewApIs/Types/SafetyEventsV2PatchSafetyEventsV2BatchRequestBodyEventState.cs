using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.PreviewApIs;

[JsonConverter(
    typeof(StringEnumSerializer<SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyEventState>)
)]
[Serializable]
public readonly record struct SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyEventState
    : IStringEnum
{
    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyEventState NeedsReview =
        new(Values.NeedsReview);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyEventState Reviewed =
        new(Values.Reviewed);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyEventState NeedsCoaching =
        new(Values.NeedsCoaching);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyEventState Coached =
        new(Values.Coached);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyEventState Dismissed =
        new(Values.Dismissed);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyEventState NeedsRecognition =
        new(Values.NeedsRecognition);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyEventState Recognized =
        new(Values.Recognized);

    public SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyEventState(string value)
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
    public static SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyEventState FromCustom(
        string value
    )
    {
        return new SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyEventState(value);
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
        SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyEventState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyEventState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyEventState value
    ) => value.Value;

    public static explicit operator SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyEventState(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string NeedsReview = "needsReview";

        public const string Reviewed = "reviewed";

        public const string NeedsCoaching = "needsCoaching";

        public const string Coached = "coached";

        public const string Dismissed = "dismissed";

        public const string NeedsRecognition = "needsRecognition";

        public const string Recognized = "recognized";
    }
}
