using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FormsPersonObjectResponseBodyEntryType>))]
[Serializable]
public readonly record struct FormsPersonObjectResponseBodyEntryType : IStringEnum
{
    public static readonly FormsPersonObjectResponseBodyEntryType Tracked = new(Values.Tracked);

    public static readonly FormsPersonObjectResponseBodyEntryType Untracked = new(Values.Untracked);

    public FormsPersonObjectResponseBodyEntryType(string value)
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
    public static FormsPersonObjectResponseBodyEntryType FromCustom(string value)
    {
        return new FormsPersonObjectResponseBodyEntryType(value);
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

    public static bool operator ==(FormsPersonObjectResponseBodyEntryType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FormsPersonObjectResponseBodyEntryType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FormsPersonObjectResponseBodyEntryType value) =>
        value.Value;

    public static explicit operator FormsPersonObjectResponseBodyEntryType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Tracked = "tracked";

        public const string Untracked = "untracked";
    }
}
