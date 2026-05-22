using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Issues;

[JsonConverter(typeof(StringEnumSerializer<IssuesPostIssueRequestBodyPriority>))]
[Serializable]
public readonly record struct IssuesPostIssueRequestBodyPriority : IStringEnum
{
    public static readonly IssuesPostIssueRequestBodyPriority Low = new(Values.Low);

    public static readonly IssuesPostIssueRequestBodyPriority Medium = new(Values.Medium);

    public static readonly IssuesPostIssueRequestBodyPriority High = new(Values.High);

    public IssuesPostIssueRequestBodyPriority(string value)
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
    public static IssuesPostIssueRequestBodyPriority FromCustom(string value)
    {
        return new IssuesPostIssueRequestBodyPriority(value);
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

    public static bool operator ==(IssuesPostIssueRequestBodyPriority value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(IssuesPostIssueRequestBodyPriority value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(IssuesPostIssueRequestBodyPriority value) => value.Value;

    public static explicit operator IssuesPostIssueRequestBodyPriority(string value) => new(value);

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
