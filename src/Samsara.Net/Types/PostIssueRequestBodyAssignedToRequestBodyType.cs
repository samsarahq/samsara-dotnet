using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<PostIssueRequestBodyAssignedToRequestBodyType>))]
[Serializable]
public readonly record struct PostIssueRequestBodyAssignedToRequestBodyType : IStringEnum
{
    public static readonly PostIssueRequestBodyAssignedToRequestBodyType User = new(Values.User);

    public PostIssueRequestBodyAssignedToRequestBodyType(string value)
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
    public static PostIssueRequestBodyAssignedToRequestBodyType FromCustom(string value)
    {
        return new PostIssueRequestBodyAssignedToRequestBodyType(value);
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
        PostIssueRequestBodyAssignedToRequestBodyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostIssueRequestBodyAssignedToRequestBodyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostIssueRequestBodyAssignedToRequestBodyType value) =>
        value.Value;

    public static explicit operator PostIssueRequestBodyAssignedToRequestBodyType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string User = "user";
    }
}
