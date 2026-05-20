using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Issues;

[JsonConverter(typeof(StringEnumSerializer<IssuesPatchIssueRequestBodyPriority>))]
[Serializable]
public readonly record struct IssuesPatchIssueRequestBodyPriority : IStringEnum
{
    public static readonly IssuesPatchIssueRequestBodyPriority Low = new(Values.Low);

    public static readonly IssuesPatchIssueRequestBodyPriority Medium = new(Values.Medium);

    public static readonly IssuesPatchIssueRequestBodyPriority High = new(Values.High);

    public IssuesPatchIssueRequestBodyPriority(string value)
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
    public static IssuesPatchIssueRequestBodyPriority FromCustom(string value)
    {
        return new IssuesPatchIssueRequestBodyPriority(value);
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

    public static bool operator ==(IssuesPatchIssueRequestBodyPriority value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(IssuesPatchIssueRequestBodyPriority value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(IssuesPatchIssueRequestBodyPriority value) =>
        value.Value;

    public static explicit operator IssuesPatchIssueRequestBodyPriority(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Low = "low";

        public const string Medium = "medium";

        public const string High = "high";
    }
}
