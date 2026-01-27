using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<SafetyEventCoachingState>))]
[Serializable]
public readonly record struct SafetyEventCoachingState : IStringEnum
{
    public static readonly SafetyEventCoachingState NeedsReview = new(Values.NeedsReview);

    public static readonly SafetyEventCoachingState Coached = new(Values.Coached);

    public static readonly SafetyEventCoachingState Dismissed = new(Values.Dismissed);

    public static readonly SafetyEventCoachingState Reviewed = new(Values.Reviewed);

    public static readonly SafetyEventCoachingState Archived = new(Values.Archived);

    public static readonly SafetyEventCoachingState ManualReview = new(Values.ManualReview);

    public static readonly SafetyEventCoachingState NeedsCoaching = new(Values.NeedsCoaching);

    public static readonly SafetyEventCoachingState AutoDismissed = new(Values.AutoDismissed);

    public static readonly SafetyEventCoachingState NeedsRecognition = new(Values.NeedsRecognition);

    public static readonly SafetyEventCoachingState Recognized = new(Values.Recognized);

    public static readonly SafetyEventCoachingState Invalid = new(Values.Invalid);

    public SafetyEventCoachingState(string value)
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
    public static SafetyEventCoachingState FromCustom(string value)
    {
        return new SafetyEventCoachingState(value);
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

    public static bool operator ==(SafetyEventCoachingState value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SafetyEventCoachingState value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SafetyEventCoachingState value) => value.Value;

    public static explicit operator SafetyEventCoachingState(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string NeedsReview = "needsReview";

        public const string Coached = "coached";

        public const string Dismissed = "dismissed";

        public const string Reviewed = "reviewed";

        public const string Archived = "archived";

        public const string ManualReview = "manualReview";

        public const string NeedsCoaching = "needsCoaching";

        public const string AutoDismissed = "autoDismissed";

        public const string NeedsRecognition = "needsRecognition";

        public const string Recognized = "recognized";

        public const string Invalid = "invalid";
    }
}
