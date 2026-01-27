using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<FormSubmissionPdfExportResponseObjectResponseBodyJobStatus>)
)]
[Serializable]
public readonly record struct FormSubmissionPdfExportResponseObjectResponseBodyJobStatus
    : IStringEnum
{
    public static readonly FormSubmissionPdfExportResponseObjectResponseBodyJobStatus Unknown = new(
        Values.Unknown
    );

    public static readonly FormSubmissionPdfExportResponseObjectResponseBodyJobStatus Pending = new(
        Values.Pending
    );

    public static readonly FormSubmissionPdfExportResponseObjectResponseBodyJobStatus Done = new(
        Values.Done
    );

    public static readonly FormSubmissionPdfExportResponseObjectResponseBodyJobStatus Failed = new(
        Values.Failed
    );

    public FormSubmissionPdfExportResponseObjectResponseBodyJobStatus(string value)
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
    public static FormSubmissionPdfExportResponseObjectResponseBodyJobStatus FromCustom(
        string value
    )
    {
        return new FormSubmissionPdfExportResponseObjectResponseBodyJobStatus(value);
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
        FormSubmissionPdfExportResponseObjectResponseBodyJobStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FormSubmissionPdfExportResponseObjectResponseBodyJobStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FormSubmissionPdfExportResponseObjectResponseBodyJobStatus value
    ) => value.Value;

    public static explicit operator FormSubmissionPdfExportResponseObjectResponseBodyJobStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string Pending = "pending";

        public const string Done = "done";

        public const string Failed = "failed";
    }
}
