using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FormsActionObjectResponseBodyType>))]
[Serializable]
public readonly record struct FormsActionObjectResponseBodyType : IStringEnum
{
    public static readonly FormsActionObjectResponseBodyType AskFollowupQuestion = new(
        Values.AskFollowupQuestion
    );

    public static readonly FormsActionObjectResponseBodyType ShowSection = new(Values.ShowSection);

    public static readonly FormsActionObjectResponseBodyType RequirePhoto = new(
        Values.RequirePhoto
    );

    public static readonly FormsActionObjectResponseBodyType RequireNote = new(Values.RequireNote);

    public static readonly FormsActionObjectResponseBodyType CreateIssue = new(Values.CreateIssue);

    public FormsActionObjectResponseBodyType(string value)
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
    public static FormsActionObjectResponseBodyType FromCustom(string value)
    {
        return new FormsActionObjectResponseBodyType(value);
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

    public static bool operator ==(FormsActionObjectResponseBodyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FormsActionObjectResponseBodyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FormsActionObjectResponseBodyType value) => value.Value;

    public static explicit operator FormsActionObjectResponseBodyType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AskFollowupQuestion = "askFollowupQuestion";

        public const string ShowSection = "showSection";

        public const string RequirePhoto = "requirePhoto";

        public const string RequireNote = "requireNote";

        public const string CreateIssue = "createIssue";
    }
}
