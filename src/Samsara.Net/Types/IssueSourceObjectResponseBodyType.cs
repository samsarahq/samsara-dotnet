using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<IssueSourceObjectResponseBodyType>))]
[Serializable]
public readonly record struct IssueSourceObjectResponseBodyType : IStringEnum
{
    public static readonly IssueSourceObjectResponseBodyType Form = new(Values.Form);

    public static readonly IssueSourceObjectResponseBodyType AdHoc = new(Values.AdHoc);

    public IssueSourceObjectResponseBodyType(string value)
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
    public static IssueSourceObjectResponseBodyType FromCustom(string value)
    {
        return new IssueSourceObjectResponseBodyType(value);
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

    public static bool operator ==(IssueSourceObjectResponseBodyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(IssueSourceObjectResponseBodyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(IssueSourceObjectResponseBodyType value) => value.Value;

    public static explicit operator IssueSourceObjectResponseBodyType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Form = "form";

        public const string AdHoc = "ad-hoc";
    }
}
