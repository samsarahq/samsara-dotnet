using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DocumentPdfQueryResponseDataJobStatus>))]
[Serializable]
public readonly record struct DocumentPdfQueryResponseDataJobStatus : IStringEnum
{
    public static readonly DocumentPdfQueryResponseDataJobStatus Requested = new(Values.Requested);

    public static readonly DocumentPdfQueryResponseDataJobStatus Processing = new(
        Values.Processing
    );

    public static readonly DocumentPdfQueryResponseDataJobStatus Completed = new(Values.Completed);

    public DocumentPdfQueryResponseDataJobStatus(string value)
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
    public static DocumentPdfQueryResponseDataJobStatus FromCustom(string value)
    {
        return new DocumentPdfQueryResponseDataJobStatus(value);
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

    public static bool operator ==(DocumentPdfQueryResponseDataJobStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocumentPdfQueryResponseDataJobStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocumentPdfQueryResponseDataJobStatus value) =>
        value.Value;

    public static explicit operator DocumentPdfQueryResponseDataJobStatus(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Requested = "requested";

        public const string Processing = "processing";

        public const string Completed = "completed";
    }
}
