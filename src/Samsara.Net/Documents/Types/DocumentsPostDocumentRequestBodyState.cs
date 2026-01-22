using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Documents;

[JsonConverter(typeof(StringEnumSerializer<DocumentsPostDocumentRequestBodyState>))]
[Serializable]
public readonly record struct DocumentsPostDocumentRequestBodyState : IStringEnum
{
    public static readonly DocumentsPostDocumentRequestBodyState Submitted = new(Values.Submitted);

    public static readonly DocumentsPostDocumentRequestBodyState Required = new(Values.Required);

    public DocumentsPostDocumentRequestBodyState(string value)
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
    public static DocumentsPostDocumentRequestBodyState FromCustom(string value)
    {
        return new DocumentsPostDocumentRequestBodyState(value);
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

    public static bool operator ==(DocumentsPostDocumentRequestBodyState value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocumentsPostDocumentRequestBodyState value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocumentsPostDocumentRequestBodyState value) =>
        value.Value;

    public static explicit operator DocumentsPostDocumentRequestBodyState(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Submitted = "submitted";

        public const string Required = "required";
    }
}
