using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FormsAssetObjectResponseBodyEntryType>))]
[Serializable]
public readonly record struct FormsAssetObjectResponseBodyEntryType : IStringEnum
{
    public static readonly FormsAssetObjectResponseBodyEntryType Tracked = new(Values.Tracked);

    public static readonly FormsAssetObjectResponseBodyEntryType Untracked = new(Values.Untracked);

    public FormsAssetObjectResponseBodyEntryType(string value)
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
    public static FormsAssetObjectResponseBodyEntryType FromCustom(string value)
    {
        return new FormsAssetObjectResponseBodyEntryType(value);
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

    public static bool operator ==(FormsAssetObjectResponseBodyEntryType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FormsAssetObjectResponseBodyEntryType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FormsAssetObjectResponseBodyEntryType value) =>
        value.Value;

    public static explicit operator FormsAssetObjectResponseBodyEntryType(string value) =>
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
