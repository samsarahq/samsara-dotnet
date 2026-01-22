using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<SafetyEventV2ObjectResponseBodyEventState>))]
[Serializable]
public readonly record struct SafetyEventV2ObjectResponseBodyEventState : IStringEnum
{
    public static readonly SafetyEventV2ObjectResponseBodyEventState Unknown = new(Values.Unknown);

    public static readonly SafetyEventV2ObjectResponseBodyEventState NeedsReview = new(
        Values.NeedsReview
    );

    public static readonly SafetyEventV2ObjectResponseBodyEventState Reviewed = new(
        Values.Reviewed
    );

    public static readonly SafetyEventV2ObjectResponseBodyEventState NeedsCoaching = new(
        Values.NeedsCoaching
    );

    public static readonly SafetyEventV2ObjectResponseBodyEventState Coached = new(Values.Coached);

    public static readonly SafetyEventV2ObjectResponseBodyEventState Dismissed = new(
        Values.Dismissed
    );

    public static readonly SafetyEventV2ObjectResponseBodyEventState NeedsRecognition = new(
        Values.NeedsRecognition
    );

    public static readonly SafetyEventV2ObjectResponseBodyEventState Recognized = new(
        Values.Recognized
    );

    public SafetyEventV2ObjectResponseBodyEventState(string value)
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
    public static SafetyEventV2ObjectResponseBodyEventState FromCustom(string value)
    {
        return new SafetyEventV2ObjectResponseBodyEventState(value);
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
        SafetyEventV2ObjectResponseBodyEventState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SafetyEventV2ObjectResponseBodyEventState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SafetyEventV2ObjectResponseBodyEventState value) =>
        value.Value;

    public static explicit operator SafetyEventV2ObjectResponseBodyEventState(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string NeedsReview = "needsReview";

        public const string Reviewed = "reviewed";

        public const string NeedsCoaching = "needsCoaching";

        public const string Coached = "coached";

        public const string Dismissed = "dismissed";

        public const string NeedsRecognition = "needsRecognition";

        public const string Recognized = "recognized";
    }
}
