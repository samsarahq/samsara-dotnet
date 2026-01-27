using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DocumentResponseObjectResponseBodyState>))]
[Serializable]
public readonly record struct DocumentResponseObjectResponseBodyState : IStringEnum
{
    public static readonly DocumentResponseObjectResponseBodyState Submitted = new(
        Values.Submitted
    );

    public static readonly DocumentResponseObjectResponseBodyState Required = new(Values.Required);

    public static readonly DocumentResponseObjectResponseBodyState Archived = new(Values.Archived);

    public DocumentResponseObjectResponseBodyState(string value)
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
    public static DocumentResponseObjectResponseBodyState FromCustom(string value)
    {
        return new DocumentResponseObjectResponseBodyState(value);
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

    public static bool operator ==(DocumentResponseObjectResponseBodyState value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocumentResponseObjectResponseBodyState value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocumentResponseObjectResponseBodyState value) =>
        value.Value;

    public static explicit operator DocumentResponseObjectResponseBodyState(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Submitted = "submitted";

        public const string Required = "required";

        public const string Archived = "archived";
    }
}
