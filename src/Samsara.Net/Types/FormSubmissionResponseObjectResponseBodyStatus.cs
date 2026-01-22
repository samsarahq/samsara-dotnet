using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FormSubmissionResponseObjectResponseBodyStatus>))]
[Serializable]
public readonly record struct FormSubmissionResponseObjectResponseBodyStatus : IStringEnum
{
    public static readonly FormSubmissionResponseObjectResponseBodyStatus NotStarted = new(
        Values.NotStarted
    );

    public static readonly FormSubmissionResponseObjectResponseBodyStatus Completed = new(
        Values.Completed
    );

    public static readonly FormSubmissionResponseObjectResponseBodyStatus Archived = new(
        Values.Archived
    );

    public static readonly FormSubmissionResponseObjectResponseBodyStatus InProgress = new(
        Values.InProgress
    );

    public static readonly FormSubmissionResponseObjectResponseBodyStatus NeedsReview = new(
        Values.NeedsReview
    );

    public static readonly FormSubmissionResponseObjectResponseBodyStatus ChangesRequested = new(
        Values.ChangesRequested
    );

    public static readonly FormSubmissionResponseObjectResponseBodyStatus Approved = new(
        Values.Approved
    );

    public FormSubmissionResponseObjectResponseBodyStatus(string value)
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
    public static FormSubmissionResponseObjectResponseBodyStatus FromCustom(string value)
    {
        return new FormSubmissionResponseObjectResponseBodyStatus(value);
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
        FormSubmissionResponseObjectResponseBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FormSubmissionResponseObjectResponseBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(FormSubmissionResponseObjectResponseBodyStatus value) =>
        value.Value;

    public static explicit operator FormSubmissionResponseObjectResponseBodyStatus(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string NotStarted = "notStarted";

        public const string Completed = "completed";

        public const string Archived = "archived";

        public const string InProgress = "inProgress";

        public const string NeedsReview = "needsReview";

        public const string ChangesRequested = "changesRequested";

        public const string Approved = "approved";
    }
}
