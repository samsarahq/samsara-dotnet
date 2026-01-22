using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<IssueResponseObjectResponseBodyStatus>))]
[Serializable]
public readonly record struct IssueResponseObjectResponseBodyStatus : IStringEnum
{
    public static readonly IssueResponseObjectResponseBodyStatus Open = new(Values.Open);

    public static readonly IssueResponseObjectResponseBodyStatus InProgress = new(
        Values.InProgress
    );

    public static readonly IssueResponseObjectResponseBodyStatus Resolved = new(Values.Resolved);

    public static readonly IssueResponseObjectResponseBodyStatus Dismissed = new(Values.Dismissed);

    public IssueResponseObjectResponseBodyStatus(string value)
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
    public static IssueResponseObjectResponseBodyStatus FromCustom(string value)
    {
        return new IssueResponseObjectResponseBodyStatus(value);
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

    public static bool operator ==(IssueResponseObjectResponseBodyStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(IssueResponseObjectResponseBodyStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(IssueResponseObjectResponseBodyStatus value) =>
        value.Value;

    public static explicit operator IssueResponseObjectResponseBodyStatus(string value) =>
        new(value);

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
