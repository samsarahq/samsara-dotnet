using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Forms;

[JsonConverter(typeof(StringEnumSerializer<FormSubmissionsPatchFormSubmissionRequestBodyStatus>))]
[Serializable]
public readonly record struct FormSubmissionsPatchFormSubmissionRequestBodyStatus : IStringEnum
{
    public static readonly FormSubmissionsPatchFormSubmissionRequestBodyStatus NotStarted = new(
        Values.NotStarted
    );

    public static readonly FormSubmissionsPatchFormSubmissionRequestBodyStatus Archived = new(
        Values.Archived
    );

    public static readonly FormSubmissionsPatchFormSubmissionRequestBodyStatus InProgress = new(
        Values.InProgress
    );

    public static readonly FormSubmissionsPatchFormSubmissionRequestBodyStatus ChangesRequested =
        new(Values.ChangesRequested);

    public static readonly FormSubmissionsPatchFormSubmissionRequestBodyStatus Approved = new(
        Values.Approved
    );

    public FormSubmissionsPatchFormSubmissionRequestBodyStatus(string value)
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
    public static FormSubmissionsPatchFormSubmissionRequestBodyStatus FromCustom(string value)
    {
        return new FormSubmissionsPatchFormSubmissionRequestBodyStatus(value);
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
        FormSubmissionsPatchFormSubmissionRequestBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FormSubmissionsPatchFormSubmissionRequestBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FormSubmissionsPatchFormSubmissionRequestBodyStatus value
    ) => value.Value;

    public static explicit operator FormSubmissionsPatchFormSubmissionRequestBodyStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string NotStarted = "notStarted";

        public const string Archived = "archived";

        public const string InProgress = "inProgress";

        public const string ChangesRequested = "changesRequested";

        public const string Approved = "approved";
    }
}
