using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Issues;

[JsonConverter(typeof(StringEnumSerializer<IssuesPostIssueRequestBodyStatus>))]
[Serializable]
public readonly record struct IssuesPostIssueRequestBodyStatus : IStringEnum
{
    public static readonly IssuesPostIssueRequestBodyStatus Open = new(Values.Open);

    public static readonly IssuesPostIssueRequestBodyStatus InProgress = new(Values.InProgress);

    public static readonly IssuesPostIssueRequestBodyStatus Resolved = new(Values.Resolved);

    public static readonly IssuesPostIssueRequestBodyStatus Dismissed = new(Values.Dismissed);

    public IssuesPostIssueRequestBodyStatus(string value)
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
    public static IssuesPostIssueRequestBodyStatus FromCustom(string value)
    {
        return new IssuesPostIssueRequestBodyStatus(value);
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

    public static bool operator ==(IssuesPostIssueRequestBodyStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(IssuesPostIssueRequestBodyStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(IssuesPostIssueRequestBodyStatus value) => value.Value;

    public static explicit operator IssuesPostIssueRequestBodyStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Open = "open";

        public const string InProgress = "inProgress";

        public const string Resolved = "resolved";

        public const string Dismissed = "dismissed";
    }
}
